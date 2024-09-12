using RealEstateApp.Model.Enum;
namespace RealEstateApp.Model.Data;

public class Picture: BaseEntity
{
	public PictureType PictureType { get; set; }
	public Guid ReferenceId { get; set; }
	public string Image { get; set; } //base64 string for pic.
}
