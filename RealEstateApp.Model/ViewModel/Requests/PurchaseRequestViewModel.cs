using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests;

public class PurchaseRequestViewModel
{
    public string Title { get; set; }
    public string Location { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public int NoOfRoom { get; set; }
    public bool IsGated { get; set; }
    public string Landmark { get; set; }
    public string Status { get; set; }
    public string Description { get; set; }
    public string Measurement { get; set; }
}
