namespace DataAnnotation.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentName { get; set; }

        [Range(18, 25)]
        public int StudentAge { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Please enter a valid email address")]
        public string EmailID { get; set; }

        [Required, StringLength(10, MinimumLength = 4)]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        public string RetypePassword { get; set; }
    }
}
