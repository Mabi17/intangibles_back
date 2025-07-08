using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace Intangibles.Models
{
    public partial class BdProductContext : DbContext
    {
        public BdProductContext()
        {
        }

        public BdProductContext(DbContextOptions<BdProductContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto).HasName("PK__producto__756A540241725624");

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
                entity.Property(e => e.Precio).HasColumnName("precio");
                entity.Property(e => e.IdCatalogo).HasColumnName("idCatalogo");
                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");
                entity.Property(e => e.img).HasColumnName("img");

            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
