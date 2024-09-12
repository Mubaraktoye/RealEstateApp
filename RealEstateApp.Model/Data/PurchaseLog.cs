namespace RealEstateApp.Model.Data;

public class PurchaseLog : BaseEntity
{
	public Guid PurchaseId { get; set; }
	public string? Message { get; set; }
	public string VisitorName { get; set; }
	public string VisitorPhoneNumber { get; set; }
	public string? VisitorEmail { get; set; }
}
