using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FieldManager : IFieldService
    {
        IFieldDal _fieldDal;

        public FieldManager(IFieldDal fieldDal)
        {
            _fieldDal = fieldDal;
        }

        public IResult Add(Field field)
        {
            _fieldDal.Add(field);
            return new Result(true,"Halısaha başarıyla eklendi");
        }

        public IResult Delete(Field field)
        {
            _fieldDal.Delete(field);
            return new Result(true,"Halısaha başarıyla silindi");
        }

        public IDataResult<List<Field>> GetAll()
        {
            return new SuccessDataResult<List<Field>>(_fieldDal.GetAll());
        }

        public IDataResult<List<Field>> GetFieldsByCityId(int id)
        {
            return new SuccessDataResult<List<Field>>(_fieldDal.GetAll(p => p.CitiesId == id));
        }

        public IResult Update(Field field)
        {
            _fieldDal.Update(field);
            return new Result(true,"Şehir başarıyla eklendi");
        }
    }
}
