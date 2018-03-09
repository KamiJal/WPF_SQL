namespace ADONET
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SQLDB : DbContext
    {
        public SQLDB()
            : base("name=SQLDB")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .Property(e => e.IP)
                .IsUnicode(false);
        }
    }
}
