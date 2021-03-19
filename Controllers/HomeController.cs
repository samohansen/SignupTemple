using Microsoft.AspNetCore.Mvc;
using SignupTemple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignupTemple.Models.ViewModels;

namespace SignupTemple.Controllers
{
    public class HomeController : Controller
    {
        private ProjectDBContext _context { get; set; }

        // Constructor Method:
        public HomeController(ProjectDBContext con)
        {
            _context = con;
        }
        public IActionResult Index()
        {
            //maybe add _context.GroupInfo
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            // *** Add IF statement in here to determine if the datetime is available or not
            List<string> times = new List<string>();
            foreach (Timeslot s in Timeslot.GetTimeslots())
            {
                times.Add($"{s.Date}");
            }
            return View(times);
        }
        [HttpPost]
        public IActionResult Signup(string time)
        {
            return View("SignupForm", new GroupListViewModel
            {
                Time = time
            }) ;
        }
        [HttpGet]
        public IActionResult SignupForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignupForm(GroupInfo groupInfo)
        {
            if (ModelState.IsValid)
            {
                // When a user submits a Signup sheet...
                // Update database:
                _context.Groups.Add(groupInfo);
                _context.SaveChanges();
            }
            return View("ViewAppointments");
        }

        [HttpGet("Click to see scheduled appointments!")]
        public IActionResult ViewAppointments()
        {
            return View("ViewAppointments");
        }
    }
}