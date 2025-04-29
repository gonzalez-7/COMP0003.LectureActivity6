using COMP0003.LectureActivity6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP0003.LectureActivity6.Data
{
	public class WebDevAcademyContext : DbContext
	{
		public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
		{ 
		}
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
	}
}
