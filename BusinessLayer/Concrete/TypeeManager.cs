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
    public class TypeeManager : ITypeeService
    {
        ITypeeDal _typeeDal;

        public TypeeManager(ITypeeDal typeeDal)
        {
            _typeeDal = typeeDal;
        }

        public void TAdd(Typee t)
        {
            _typeeDal.Add(t);
        }

        public void TDelete(Typee t)
        {
            _typeeDal.Delete(t);
        }

        public Typee TGetByID(int id)
        {
            return _typeeDal.GetByID(id);
        }

        public List<Typee> TGetList()
        {
            return _typeeDal.GetListAll();
        }

        public void TUpdate(Typee t)
        {
            _typeeDal.Update(t);
        }
    }
}
