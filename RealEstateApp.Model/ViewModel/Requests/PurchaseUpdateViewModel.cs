using RealEstateApp.Model.Enum;

namespace RealEstateApp.Model.ViewModel.Requests
{
	public class PurchaseUpdateViewModel
	{
		public Guid Id { get; set; }
		public string Location { get; set; }
		public decimal Price { get; set; }
		public string Type { get; set; }
		public int NoOfRoom { get; set; }
		public bool IsGated { get; set; }
		public string Landmark { get; set; }
		public string Status { get; set; }//
		public string Description { get; set; }
	}

	public class PurchaseApprovalViewModel
	{
		public Guid Id { get; set; }
		public ApprovalType ApprovalType { get; set; }
	}
}
