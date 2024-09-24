namespace RealEstateApp.Model.ViewModel.Responses
{
	public class RentLogListResponseModel: BaseResponseModel
	{
		public List<RentLogResponse> Data { get; set; }
	}

	public class RentLogResponseModel : BaseResponseModel
	{
		public RentLogResponse Data { get; set; }
	}

	public class RentLogResponse
	{
		public string? Message { get; set; }
		public string VisitorName { get; set; }
		public string VisitorPhoneNumber { get; set; }
		public string? VisitorEmail { get; set; }
	}
}
