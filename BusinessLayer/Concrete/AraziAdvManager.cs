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
    public class AraziAdvManager : IAraziAdvService
    {
        IAraziAdvDal _araziAdvDal;

        public AraziAdvManager(IAraziAdvDal araziAdvDal)
        {
            _araziAdvDal = araziAdvDal;
        }

        public void TAdd(AraziAdv t)
        {
            _araziAdvDal.Add(t);
        }

        public void TDelete(AraziAdv t)
        {
            _araziAdvDal.Delete(t);
        }

        public AraziAdv TGetByID(int id)
        {
            return _araziAdvDal.GetByID(id);
        }

        public List<AraziAdv> TGetList()
        {
            return _araziAdvDal.GetListAll();
        }

        public void TUpdate(AraziAdv t)
        {
            _araziAdvDal.Update(t);
        }
    }
}
