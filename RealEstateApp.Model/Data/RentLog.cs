namespace RealEstateApp.Model.Data;

public class RentLog : BaseEntity
{
	public Guid RentId { get; set; }
	public string? Message { get; set; }
	public string VisitorName { get; set; }
	public string VisitorPhoneNumber { get; set; }
	public string? VisitorEmail { get; set; }
	public bool IsContacted {  get; set; }
}
