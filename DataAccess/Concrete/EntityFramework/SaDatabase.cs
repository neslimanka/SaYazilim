using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class SaDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PISI\SQLEXPRESS;Database=SaDatabase;Trusted_Connection=true");
        }

        public DbSet<Bakiye_Banka> Bakiye_Bankas { get; set; }
        public DbSet<Bakiye_Kasa> Bakiye_Kasas { get; set; }
        public DbSet<Banka> Bankas { get; set; }
        public DbSet<Kasa> Kasas { get; set; }
        public DbSet<Tahsilat_odeme> Tahsilat_Odemes { get; set; }

  

    }
}
