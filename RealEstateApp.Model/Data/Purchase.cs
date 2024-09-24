using RealEstateApp.Model.Enum;

namespace RealEstateApp.Model.Data
{
	public class Purchase : BaseEntity
	{
		public string Title { get; set; }
		public string Location { get; set; }
		public decimal Price { get; set; }
		public string Type { get; set; }
		public int NoOfRoom { get; set; }
		public bool IsGated { get; set; }
		public string Landmark { get; set; }
		public string Status { get; set; }
		public bool IsVerified { get; set; }
		public string Description { get; set; }
		public ApprovalType ApprovalType { get; set; }
		public string Measurement { get; set; }
	}
}
