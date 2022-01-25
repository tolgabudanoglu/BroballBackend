using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface IFieldService
    {
        List<Field> GetAll();
        IResult Add(Field field);
        IResult Delete(Field field);
        IResult Update(Field field);
        
    }
}
