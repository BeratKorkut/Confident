using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework.Repositories;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
    public class EfTypeeRepository : GenericRepository<Typee>,ITypeeDal
    {
    }
}
