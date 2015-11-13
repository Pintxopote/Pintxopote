using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Pintxopote.Models;

namespace Pintxopote.Konexioa
{
    public class PintxopoteDbContext : DbContext
    {
        public DbSet<Tabernak> Taberna { get; set; }
        public DbSet<Pintxo> Pintxo { get; set; }

        protected override void OnConfiguring(EntityOptionsBuilder optionsBuilder)
        {
            /*DESKTOP-6OSC2VD\SQLEXPRESS*/
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6OSC2VD\SQLEXPRESS;Database=Pintxopote;integrated security=True;");
        }

    }
}
