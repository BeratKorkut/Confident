using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BERATKORKUT\\SQLEXPRESS;database=ConfidentDb; integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Detail>? EMLAKDETAY { get; set; }
        public DbSet<Advert>? EMLAKILAN { get; set; }
        //public DbSet<Typee>? EMLAKTİP { get; set; }
        public DbSet<AraziAdv>? ILANARAZI { get; set; }
        public DbSet<KonutAdv>? ILANKONUT { get; set; }
    }
}
