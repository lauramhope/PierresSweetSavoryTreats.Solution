using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "Course name field cannot be empty!")]
    public string CourseName { get; set; }
    [Required(ErrorMessage = "Course number field cannot be empty!")]
    public string CourseNumber { get; set; }
    public List<CourseStudent> JoinEntities { get; set; }
  }
}