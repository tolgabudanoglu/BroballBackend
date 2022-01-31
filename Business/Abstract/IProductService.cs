using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product> >GetAll();
        IResult Add(Product Product);
        IResult Delete(Product product);
        IResult Update(Product product);
        Product GetById(int ProductId);
    }
}