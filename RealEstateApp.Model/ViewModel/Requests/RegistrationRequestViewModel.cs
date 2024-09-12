using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests
{
    public class RegistrationRequestViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public string AccessType { get; set; }
    }
}
