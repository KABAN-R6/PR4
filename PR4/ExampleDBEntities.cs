using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace PR4
{
    internal class ExampleDBEntities : DbContext
    {
        public ExampleDBEntities() 
            : base(nameOrConnectionString: "name= ExampleDbEntities") 
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();

        }
        public virtual DbSet<Permit> Permit { get; set; }
        public virtual DbSet<Hotell> Hotell { get; set; }
        public virtual DbSet<Servicce> Servicce { get; set; }
        public virtual DbSet<Routee> Routees { get; set; }
        public virtual DbSet<Countryy> Countryy { get; set; }
        public virtual DbSet<Cityy> Cityy { get; set; }
        public virtual DbSet<Humann> Humann { get; set; }


    }
}
