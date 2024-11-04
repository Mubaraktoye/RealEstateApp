using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Model.ViewModel.Requests
{
	public class UserRequestViewModel
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Password { get; set; }
	}

    public class UserLoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
