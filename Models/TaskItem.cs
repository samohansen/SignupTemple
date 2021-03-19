using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignupTemple.Models
{
	public class TaskItem
	{
		[Key]
		[Required]
		public int TaskId { get; set; }
		[Required]
		public string TaskDescription { get; set; }
		[Required]
		public bool Urgent { get; set; }
		[Required]
		public bool Important { get; set; }

		// A lot of business logic takes place in Models:
		// We can build a method inside the model
		// This method will assign a quadrant to an item

		public string GetQuadrant()
		{
			string quadrantName = "";
			// we don't need == true; it's implied.
			// if (Urgent == true && Important == true)
			if (Urgent && Important)
			{
				quadrantName = "Quadrant I";
			}
			else if (!Urgent && Important)
			{
				quadrantName = "Quadrant II";
			}
			else if (Urgent && !Important)
			{
				quadrantName = "Quadrant III";
			}
			else if (!Urgent && !Important)
			{
				quadrantName = "Quadrant IV";
			}
			return quadrantName;
		}
	}
}
