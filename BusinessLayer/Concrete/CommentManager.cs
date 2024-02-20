using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _iCommentDal;

        public CommentManager(ICommentDal iCommentDal)
        {
            _iCommentDal = iCommentDal;
        }

        public void TAdd(Comment t)
        {
            _iCommentDal.Insert(t); 
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetServiceByID(int id)
        {
            return _iCommentDal.GetListByFilter(x=>x.ServiceId == id);  
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
