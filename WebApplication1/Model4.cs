namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model4")
        {
        }

        public virtual DbSet<TIPOIVA> TIPOIVA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.descrip)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.abrevia)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.porcen1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.porcen2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.cuenta1)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.cuenta2)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOIVA>()
                .Property(e => e.abc)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
