using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using IzinYonetim.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IzinYonetim.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<IzinHareketi> IzinHareketleri  { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<IzinTipleri> IzinTipleri { get; set; }
    }
}
