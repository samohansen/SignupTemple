using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignupTemple.Models
{
    public class GroupInfo
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [RegularExpression("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")]
        public string Email { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Enter a phone number as the following: ###-###-####")] // valid format (using Regex)
        public string Phone { get; set; }
        [ForeignKey("Date")]
        public DateTime TimeSlot { get; set; }
    }
}