namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model31")
        {
        }

        public virtual DbSet<Proveedor> Proveedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>()
                .Property(e => e.rsocial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.resum)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.localidad)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.codpostal)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.provin)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.cuit)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.contab)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.contab1)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.calle)
                .IsUnicode(false);
        }
    }
}
