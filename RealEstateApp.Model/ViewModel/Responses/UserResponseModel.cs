using RealEstateApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Responses
{
    public class UserResponseModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public AccessType AccessType { get; set; }
        public ApprovalType ApprovalType { get; set; }
    }

    public class LoginResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public UserResponseModel Data { get; set; }
        public string Token { get; set; }
        public  string RefreshToken { get; set; }
    }
}
