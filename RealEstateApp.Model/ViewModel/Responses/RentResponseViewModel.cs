using RealEstateApp.Model.Data;
using RealEstateApp.Model.Enum;

namespace RealEstateApp.Model.ViewModel.Responses
{
    public class RentListResponseViewModel : BaseResponseModel
    {
        public List<RestResponse> Data { get; set; }
    }

    public class RentResponseViewModel : BaseResponseModel
    {
        public RestResponse Data { get; set; }
    }

    public class RestResponse
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

}
