using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Responses
{
	public class PurchaseLogListResponseModel : BaseResponseModel
	{
		public List<PurchaseLogResponse> Data { get; set; }
	}

	public class PurchaseLogResponseModel : BaseResponseModel
	{
		public PurchaseLogResponse Data { get; set; }
	}

	public class PurchaseLogResponse
	{
		public string? Message { get; set; }
		public string VisitorName { get; set; }
		public string VisitorPhoneNumber { get; set; }
		public string? VisitorEmail { get; set; }
	}
}
