using RealEstateApp.Model.Enum;

namespace RealEstateApp.Model.Data
{
	public class User
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }
		public AccessType AccessType { get; set; }
		public ApprovalType ApprovalType { get; set; }
	}
}
