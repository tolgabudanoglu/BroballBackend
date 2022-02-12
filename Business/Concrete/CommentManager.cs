using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new Result(true, "Başarıyla eklendi");
        }

        public IDataResult<List<Comment>> GetAll()
        {
            var result = _commentDal.GetAll();
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<List<Comment>> GetCommentsByEmail(string mail)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(p => p.Email == mail));
        }
        //public IDataResult<List<Comments>> GetCommentDetails()
        //{
        //    var result = _commentDal.GetAll();
        //    return new SuccessDataResult<:>
        //}
    }
}
