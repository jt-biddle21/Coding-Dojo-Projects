using System.ComponentModel.DataAnnotations;
namespace formSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="Must have a first name!")]
        [MinLength(3, ErrorMessage="Name cant be less than 3 characters")]
        public string First_Name { get; set; }

        [Required(ErrorMessage="Must have a last name!")]
        [MinLength(3, ErrorMessage="Last name cant be less than 3 characters")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage="Must have an age!")]
        [Range(1,100, ErrorMessage="Age needs to be between 1 and 100")]
        public int Age { get; set; }
 
        [Required(ErrorMessage="Must have an Email!")]
        [EmailAddress(ErrorMessage="Must enter in a valid email!")]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Please enter in a password!")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password needs to be 8 or more characters")]
        public string Password { get; set; }
    }
}