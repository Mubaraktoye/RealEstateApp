using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests;

public class PurchaseLogRequestViewModel
{
    public string Message { get; set; }
    public string VisitorName { get; set; }
    public string VisitorPhoneNumber { get; set; }
    public string VisitorEmail { get; set; }
}
