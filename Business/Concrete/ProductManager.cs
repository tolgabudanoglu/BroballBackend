using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;





namespace Business.Concrete

{

    public class ProductManager : IProductService
    {
        
        IProductDal _productdal;

        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;
        }

        public IResult Add(Product product)
        {
            _productdal.Add(product);



            return new Result(true, "ürün eklendi");
        }
        public IResult Delete(Product product)
        {
            _productdal.Delete(product);
            return new Result(true, "ürün silindi");
        }

        public List<Product> GetAll()
        {
            return _productdal.GetAll();
        }

        public Product GetById(int productId)
        {
            return _productdal.Get(x => x.ProductId == productId);
        }

        public IResult Update(Product product)
        {
            _productdal.Update(product);
            return new Result(true, "ürün başarıyla güncellendi");
        }


    }
}