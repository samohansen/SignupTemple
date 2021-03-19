using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignupTemple.Models
{
	public class ProjectDBContext : DbContext
	{
		public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
		{
		}
		// <TaskItem> Is the class we built for our form
		// import the table into ASP.Net
		public DbSet<Timeslot> Times  { get; set; }
		public DbSet<GroupInfo> Groups { get; set; }
	}
}

