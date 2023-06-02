using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "Student name field cannot be empty!")]
    public string StudentName { get; set; }
    [Required(ErrorMessage = "Enrollment date field cannot be empty!")]
    public string EnrollmentDate { get; set; }
    // [Range(1, int.MaxValue, ErrorMessage = "You must add a student to a course. Have you created a course yet?")]
    public int CourseId { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}