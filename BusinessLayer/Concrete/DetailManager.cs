using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DetailManager : IDetailService
    {
        IDetailDal _detailDal;

        public DetailManager(IDetailDal detailDal)
        {
            _detailDal = detailDal;
        }

        public void TAdd(Detail t)
        {
            _detailDal.Add(t);
        }

        public void TDelete(Detail t)
        {
            _detailDal.Delete(t);
        }

        public Detail TGetByID(int id)
        {
            return _detailDal.GetByID(id);
        }

        public List<Detail> TGetList()
        {
            return _detailDal.GetListAll();
        }

        public void TUpdate(Detail t)
        {
            _detailDal.Update(t);
        }
    }
}
