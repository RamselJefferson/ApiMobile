using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiMobile.Models;

public partial class ApiContext : DbContext
{
    public ApiContext()
    {
    }

    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Conferencia> Conferencias { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Items> Items { get; set; }
    public virtual DbSet<VwItemsCategoria> VwItemsCategoria { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<VwModelo> VwModelos { get; set; }

    public virtual DbSet<VwVehiculo> VwVehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2VPR9IB\\SQLEXPRESS;Initial Catalog=Api;User ID=jdelacruz;Password=ramsel2001;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Conferencia>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Creador)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Duracion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });


        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.MarId).HasName("PK__Marcas__32E17527933EC3DD");

            entity.Property(e => e.MarId).ValueGeneratedNever();
            entity.Property(e => e.MarDecripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Message__3214EC0757556BD8");

            entity.ToTable("Message");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Message1)
                .IsUnicode(false)
                .HasColumnName("Message");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.ModId).HasName("PK__Modelos__FB1F17879ED9A018");

            entity.Property(e => e.ModId)
                .ValueGeneratedNever()
                .HasColumnName("ModID");
            entity.Property(e => e.ModDescripcion)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Mar).WithMany(p => p.Modelos)
                .HasForeignKey(d => d.MarId)
                .HasConstraintName("fk_Modelos_Marcas");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Usuario");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.UsuarioName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehId).HasName("PK__Vehiculo__3CB7EFE054F34A6C");

            entity.Property(e => e.VehId).ValueGeneratedNever();
            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Estatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Img)
                .IsUnicode(false)
                .HasColumnName("img");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.VehDecripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwModelo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwModelos");

            entity.Property(e => e.MarDecripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ModDescripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwVehiculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwVehiculos");

            entity.Property(e => e.Año).HasColumnName("año");
            entity.Property(e => e.Estatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
            entity.Property(e => e.Img)
                .IsUnicode(false)
                .HasColumnName("img");
            entity.Property(e => e.MarDecripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ModDescripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehDecripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vehid).HasColumnName("vehid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
