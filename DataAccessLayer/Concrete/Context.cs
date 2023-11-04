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

        public DbSet<EmlakDetay>? EmlakDetays { get; set; }
        public DbSet<EmlakIlan>? EmlakIlans { get; set; }
        public DbSet<EmlakTipi>? EmlakTipis { get; set; }
        public DbSet<IlanArazi>? IlanArazis { get; set; }
        public DbSet<IlanKonut>? IlanKonuts { get; set; }
    }
}
