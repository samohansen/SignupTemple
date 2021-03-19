using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignupTemple.Models
{
    public class Timeslot
    {
        [Key]
        public int TimeslotId { get; set; }
        public DateTime Date { get; set; }

        public static Timeslot[] GetTimeslots()
        {
            Timeslot r1 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 21, 10, 0, 0)
            };
            Timeslot r2 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 21, 11, 0, 0)
            };
            Timeslot r3 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 22, 10, 0, 0)
            };
            Timeslot r4 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 22, 11, 0, 0)
            };
            Timeslot r5 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 23, 10, 0, 0)
            };
            Timeslot r6 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 23, 11, 0, 0)
            };
            Timeslot r7 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 24, 10, 0, 0)
            };
            Timeslot r8 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 24, 11, 0, 0)
            };
            Timeslot r9 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 25, 10, 0, 0)
            };
            Timeslot r10 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 25, 11, 0, 0)
            };
            Timeslot r11 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 26, 10, 0, 0)
            };
            Timeslot r12 = new Timeslot()
            {
                Date = new DateTime(2021, 3, 26, 11, 0, 0)
            };

            return new Timeslot[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 };
        }
    }
}