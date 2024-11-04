using RealEstateApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services.Interfaces
{
    public interface IPictureService
    {
        Task CreatePicture(PictureType type, Guid refId, string url);
    }
}
