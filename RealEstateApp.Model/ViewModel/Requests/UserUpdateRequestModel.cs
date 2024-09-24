using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests
{
	public class UserUpdateRequestModel
	{
		public Guid Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public string? PhoneNumber { get; set; }
	}

	public class PasswordUpdateRequestModel
	{
		public string OldPassword { get; set; }
		public string NewPassword { get; set; }
	}
}
