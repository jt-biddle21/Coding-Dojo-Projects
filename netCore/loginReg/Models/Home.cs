using System.ComponentModel.DataAnnotations;
namespace loginReg.Models
{
    public class User
    {
        
        [Required(ErrorMessage="You need to enter in a first name!")]
        [MinLength(3, ErrorMessage="Name too short!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can only contain letters")]
        public string First_Name { get; set; }

		[Required(ErrorMessage="You need to enter in a last name!")]
        [MinLength(3, ErrorMessage="Name too short!")]
        public string Last_Name { get; set; }
 
        [Required(ErrorMessage="You need to enter in an email!")]
        [EmailAddress(ErrorMessage="You need to enter in a valid email!")]
        public string Email { get; set; }
 
        [Required(ErrorMessage="Please enter in a password!")]
		[MinLength(8, ErrorMessage="Password cannot be shorter than 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class Comment
    {
        [Required]
        [MinLength(1, ErrorMessage="You need to enter in text to post a comment!")]
        public string PostComment { get; set; }
    }
    public class Message
    {
        [Required]
        [MinLength(1, ErrorMessage="You need to enter in text to post a message!")]
        public string MessagePost { get; set; }
    }
}
