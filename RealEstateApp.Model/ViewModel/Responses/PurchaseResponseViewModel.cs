using RealEstateApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Responses
{
	public class PurchaseResponse
	{
		public string Location { get; set; }
		public decimal Price { get; set; }
		public string Type { get; set; }
		public int NoOfRoom { get; set; }
		public bool IsGated { get; set; }
		public string Landmark { get; set; }
		public string Status { get; set; }//
		public bool IsVerified { get; set; }
		public string Description { get; set; }
		public ApprovalType ApprovalType { get; set; }
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public UserResponseModel CreatedBy { get; set; }
		public UserResponseModel? ModifiedBy { get; set; }
	}

	public class PurchaseListResponseViewModel : BaseResponseModel
	{
		public List<PurchaseResponse> Data { get; set; }
	}

	public class PurchaseResponseViewModel : BaseResponseModel
	{
		public PurchaseResponse Data { get; set; }
	}
}
