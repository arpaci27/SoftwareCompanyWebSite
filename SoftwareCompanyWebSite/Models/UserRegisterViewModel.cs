using System.ComponentModel.DataAnnotations;

namespace SoftwareCompanyWebSite.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage = "Please enter your name!")]
        public String Name { get; set; }

		[Required(ErrorMessage = "Please enter your surname!")]
		public String Surname { get; set; }

		[Required(ErrorMessage = "Please enter your username!")]
		public String Username { get; set; }

		[Required(ErrorMessage = "Please enter your mail!")]
		public String Mail { get; set; }

		[Required(ErrorMessage = "Please enter your password!")]
		public String Password { get; set; }

		[Required(ErrorMessage = "Please confirm your password!")]

		[Compare("Password")]
		public String ConfirmPassword { get; set; }


	}
}
