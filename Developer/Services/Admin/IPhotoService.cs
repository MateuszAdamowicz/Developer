using System.Collections.Generic;
using System.Web;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;

namespace Developer.Services.Admin
{
    public interface IPhotoService
    {
        Result<string> AddWorkerPhoto(HttpPostedFileBase file, string fileName);
        List<Photo> AddAdvertPhotos(IEnumerable<HttpPostedFileBase> files);
        Result<string> ReplaceWorkerPhoto(HttpPostedFileBase file, string fileName, string oldPhoto);
    }
}