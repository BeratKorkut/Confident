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
    public class AdvertManager : IAdvertService
    {
        IAdvertDal _advertDal;

        public AdvertManager(IAdvertDal advertDal)
        {
            _advertDal = advertDal;
        }

        public void TAdd(Advert t)
        {
            _advertDal.Add(t);
        }

        public void TDelete(Advert t)
        {
            _advertDal.Delete(t);
        }

        public Advert TGetByID(int id)
        {
            return _advertDal.GetByID(id);
        }

        public List<Advert> TGetList()
        {
            return _advertDal.GetListAll();
        }

        public void TUpdate(Advert t)
        {
            _advertDal.Update(t);
        }
    }
}
