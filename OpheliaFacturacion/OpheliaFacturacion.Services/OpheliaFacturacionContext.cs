using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class OpheliaFacturacionContext : DbContext
    {
        public OpheliaFacturacionContext()
        {
        }

        public OpheliaFacturacionContext(DbContextOptions<OpheliaFacturacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalles { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5GILTJU\\SQLEXPRESS;Database=OpheliaFacturacion;User ID=OpheliaFacturacion1;Password=OpheliaFacturacion1;MultipleActiveResultSets=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(200)
                    .HasColumnName("nombres")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.ToTable("factura");

                entity.Property(e => e.FacturaId).HasColumnName("facturaId");

                entity.Property(e => e.ClienteId).HasColumnName("clienteId");

                entity.Property(e => e.FechaCompra)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaCompra");

                entity.Property(e => e.TotalFactura).HasColumnName("totalFactura");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("fk_factura_Cliente_1");
            });

            modelBuilder.Entity<FacturaDetalle>(entity =>
            {
                entity.ToTable("FacturaDetalle");

                entity.Property(e => e.FacturaDetalleId).HasColumnName("facturaDetalleId");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.FacturaId).HasColumnName("facturaId");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.FacturaDetalles)
                    .HasForeignKey(d => d.FacturaId)
                    .HasConstraintName("fk_FacturaDetalle_factura_1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.FacturaDetalles)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("fk_FacturaDetalle_Producto_1");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IntentarioId);

                entity.ToTable("Inventario");

                entity.Property(e => e.IntentarioId).HasColumnName("intentarioId");

                entity.Property(e => e.CantidadActual).HasColumnName("cantidadActual");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Inventarios)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("fk_Inventario_Producto_1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.ProductoId).HasColumnName("productoId");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
