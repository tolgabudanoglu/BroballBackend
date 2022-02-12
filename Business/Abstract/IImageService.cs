using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IImageService
    {

        IResult Add(IFormFile file, Image Image);
        IResult Delete(Image Image);
        IResult Update(IFormFile file, Image Image);

        IDataResult<List<Image>> GetAll();
        
        IDataResult<Image> GetByImageId(int imageId);
        
    }
}
