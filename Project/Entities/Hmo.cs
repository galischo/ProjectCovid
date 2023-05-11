using Entities.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Hmo:DbContext
    {
        public Hmo(DbContextOptions<Hmo> options)
            : base(options)
        {
          
        }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Corona> Coronas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-QM3UF42;database=db;trusted_connection=true;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(e => e.coronaDates)
                .WithOne(e => e.patient)
                .HasForeignKey(e => e.patientId)
                .HasPrincipalKey(e => e.id);
        }
    }

}

