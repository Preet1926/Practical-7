using System.ComponentModel.DataAnnotations;
namespace Practical7.Models
{
    public class FeedbackViewModel
    {
        [Required(ErrorMessage = "Student Name is required.")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Roll Number is required.")]
        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }

        [Required(ErrorMessage = "Please select your course.")]
        [Display(Name = "Course / Department")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Please select semester.")]
        [Display(Name = "Semester")]
        public string Semester { get; set; }

        [Required(ErrorMessage = "Subject name is required.")]
        [Display(Name = "Subject Name")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Faculty/Teacher name is required.")]
        [Display(Name = "Faculty Name")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Please rate teaching quality.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Teaching Quality Rating (1-5)")]
        public int TeachingRating { get; set; }

        [Required(ErrorMessage = "Please rate course content.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Course Content Rating (1-5)")]
        public int CourseRating { get; set; }

        [Required(ErrorMessage = "Suggestions/Comments are required.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Feedback must be 10 to 500 characters long.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Detailed Feedback / Suggestions")]
        public string Comments { get; set; }
    }
}
