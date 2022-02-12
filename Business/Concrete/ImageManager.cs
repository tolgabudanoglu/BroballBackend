using Business.Abstract;
using Business.constan;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _ImageDal;
        IFileHelper _fileHelper;
        public ImageManager(IImageDal ImageDal, IFileHelper fileHelper)
        {
            _ImageDal = ImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, Image Image)
        {
           
            Image.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
           
            _ImageDal.Add(Image);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(Image Image)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + Image.ImagePath);
            _ImageDal.Delete(Image);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, Image Image)
        {
            Image.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + Image.ImagePath, PathConstants.ImagesPath);
            _ImageDal.Update(Image);
            return new SuccessResult();
        }

        
        public IDataResult<Image> GetByImageId(int imageId)
        {
            return new SuccessDataResult<Image>(_ImageDal.Get(c => c.ImageId == imageId));
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_ImageDal.GetAll());
        }
       
    }
}