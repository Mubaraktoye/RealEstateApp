using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Responses
{
    public class BaseResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
