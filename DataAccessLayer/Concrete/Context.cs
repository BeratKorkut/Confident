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
            optionsBuilder.UseSqlServer("server=BERATKORKUT\\SQLEXPRESS;database=ConfidentDb; integrated security=true;");
        }

        public DbSet<EmlakDetay>? emlakDetays { get; set; }
        public DbSet<EmlakIlan>? emlakIlans { get; set; }
        public DbSet<EmlakTipi>? emlakTipis { get; set; }
        public DbSet<IlanArazi>? ılanArazis { get; set; }
        public DbSet<IlanKonut>? ılanKonuts { get; set; }
    }
}
