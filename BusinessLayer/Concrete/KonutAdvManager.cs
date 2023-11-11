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
    public class KonutAdvManager :IKonutAdvService
    {
        IKonutAdvDal _konutAdvDal;

        public KonutAdvManager(IKonutAdvDal konutAdvDal)
        {
            _konutAdvDal = konutAdvDal;
        }

        public void TAdd(KonutAdv t)
        {
            _konutAdvDal.Add(t);
        }

        public void TDelete(KonutAdv t)
        {
            _konutAdvDal.Delete(t);
        }

        public KonutAdv TGetByID(int id)
        {
            return _konutAdvDal.GetByID(id);
        }

        public List<KonutAdv> TGetList()
        {
            return _konutAdvDal.GetListAll();
        }

        public void TUpdate(KonutAdv t)
        {
            _konutAdvDal.Update(t);
        }
    }
}
