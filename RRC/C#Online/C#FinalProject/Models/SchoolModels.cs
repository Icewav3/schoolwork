using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_FinalProject.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Required]
        public int GradePointStateId { get; set; }

        public int? AcademicProgramId { get; set; }

        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Student Number must be between 10000000 and 99999999.")]
        [Display(Name = "Student Number")]
        public long StudentNumber { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "First Name must be between 1 and 35 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Last Name must be between 1 and 35 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "Address must be between 1 and 35 characters.")]
        public string Address { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 1, ErrorMessage = "City must be between 1 and 35 characters.")]
        public string City { get; set; }

        [Required]
        [RegularExpression("^(AB|BC|MB|NB|NL|NS|NT|NU|ON|PE|QC|SK|YT)$", ErrorMessage = "Invalid Canadian Province Code.")]
        public string Province { get; set; }

        [Required]
        [RegularExpression("^[ABCEGHJKLMNPRSTVXY][0-9][A-Z] [0-9][A-Z][0-9]$", ErrorMessage = "Invalid Postal Code Format. Example: A9A 9A9")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public double? GradePointAverage { get; set; }

        [Range(0, 4.5, ErrorMessage = "Grade Point Average must be between 0 and 4.5.")]
        [Display(Name = "Grade Point Average")]
        [DisplayFormat(DataFormatString = "{0:F2}")]

        public double OutstandingFees { get; set; }
        [Required]
        [Display(Name = "Outstanding Fees")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        
        public string Notes { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [NotMapped]
        public string FullAddress => $"{Address}, {City}, {PostalCode}";

        [ForeignKey("GradePointStateId")]
        public GradePointState GradePointState { get; set; }

        [ForeignKey("AcademicProgramId")]
        public AcademicProgram AcademicProgram { get; set; }
    }
    public class GradePointState
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradePointStateId { get; set; }

        [Required]
        [Display(Name = "Lower Limit")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double LowerLimit { get; set; }

        [Required]
        [Display(Name = "Upper Limit")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double UpperLimit { get; set; }

        [Required]
        [Display(Name = "Tuition Rate Factor")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double TuitionRateFactor { get; set; }

        [Display(Name = "Grade Point State")]
        public string Description => GetType().Name.Replace("State", "");
    }
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Registration Number")]
        public long RegistrationNumber { get; set; }

        [Required]
        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [DisplayFormat(NullDisplayText = "Ungraded")]
        [Range(0, 1, ErrorMessage = "Grade must be between 0 and 1.")]
        public double? Grade { get; set; }

        public string Notes { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [ForeignKey("AcademicProgramId")]
        public int? AcademicProgramId { get; set; }

        [Required]
        [Display(Name = "Course Number")]
        public string CourseNumber { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Credit Hours")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double CreditHours { get; set; }

        [Required]
        [Display(Name = "Tuition Amount")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double TuitionAmount { get; set; }

        [Display(Name = "Course Type")]
        public string CourseType => GetType().Name.Replace("Course", "");

        public string Notes { get; set; }

        [ForeignKey("AcademicProgramId")]
        public AcademicProgram AcademicProgram { get; set; }
    }
    public class GradedCourse : Course
    {
        [Required]
        [Display(Name = "Assignment Weight")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double AssignmentWeight { get; set; }

        [Required]
        [Display(Name = "Midterm Weight")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double MidtermWeight { get; set; }

        [Required]
        [Display(Name = "Final Weight")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double FinalWeight { get; set; }
    }
    public class AcademicProgram
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int AcademicProgramId { get; set; }

        [Required]
        [Display(Name = "Program")]
        public string ProgramAcronym { get; set; }

        [Required]
        [Display(Name = "Program Name")]
        public string Description { get; set; }
    }
    public class AuditCourse : Course
    {

    }
    public class MasteryCourse : Course
    {
        [Required]
        [Display(Name = "Maximum Attempts")]
        public int MaximumAttempts { get; set; }
    }
}
