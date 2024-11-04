using Arch.EntityFrameworkCore.UnitOfWork;
using RealEstateApp.Model.Data;
using RealEstateApp.Model.Enum;
using RealEstateApp.Services.Interfaces;

namespace RealEstateApp.Services.Implementations
{
    public class PictureService: IPictureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PictureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreatePicture(PictureType type, Guid refId, string url)
        {
            var picture = new Picture
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ReferenceId = refId,
                PictureType = type,
                Image = url
            };

            _unitOfWork.GetRepository<Picture>().Insert(picture);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
