namespace RealEstateApp.Web.Models
{
    public class PropertyClientRequestModel
    {
        public int PropertyType { get; set; }
        public bool PropertyGated { get; set; }
        public string PropertyTitle { get; set; }
        public string PropertyDescription { get; set; }
        public int PropertyRooms { get; set; }
        public decimal PropertyPrice { get; set; }
        public string PropertyLocation { get; set; }    
        public string PropertyLandmark { get; set; }
        public IFormFile[] PropertyPics { get; set; }
    }
}
