using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HighlightManager: IHighlightService
    {
        IHighlightDal highlightDal;

        public HighlightManager(IHighlightDal _highlightdal)
        {
            highlightDal = _highlightdal;
        }

        public void TAdd(Highlight t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Highlight t)
        {
            throw new NotImplementedException();
        }

        public Highlight TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Highlight> TGetList()
        {
            return highlightDal.GetList();
        }

        public void TUpdate(Highlight t)
        {
            throw new NotImplementedException();
        }
    }
}
