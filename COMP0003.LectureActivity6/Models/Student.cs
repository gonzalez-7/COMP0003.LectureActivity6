using System.ComponentModel.DataAnnotations;

namespace COMP0003.LectureActivity6.Models
{
	public class Student
	{
		public int StudentId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		//Collection navigation property

		public virtual ICollection<Enrollment>? Enrollments { get; set; }
		public int Age { get; set; } // New property added
	}
}