using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAGA0._3.Api.Domain.Models;

namespace SAGA0._3.Api.InfraEstructura.Context;

public partial class BootcampG6Context : IdentityDbContext
{
    public BootcampG6Context()
    {
        ChangeTracker.LazyLoadingEnabled = false;
        ChangeTracker.LazyLoadingEnabled = false;
        base.ChangeTracker.LazyLoadingEnabled = false;
    }

    public BootcampG6Context(DbContextOptions<BootcampG6Context> options)
        : base(options)
    {
        ChangeTracker.LazyLoadingEnabled = false;
        ChangeTracker.LazyLoadingEnabled = false;
        base.ChangeTracker.LazyLoadingEnabled = false;
    }

    //public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    //public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }

    //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<Cargos> Cargos { get; set; }

    public virtual DbSet<CertificadoAmbiental> CertificadoAmbiental { get; set; }

    public virtual DbSet<DetallesGastos> DetallesGastos { get; set; }

    public virtual DbSet<DetallesProyectos> DetallesProyectos { get; set; }

    public virtual DbSet<DocumentosAdjuntos> DocumentosAdjuntos { get; set; }

    public virtual DbSet<Empresas> Empresas { get; set; }

    public virtual DbSet<Indicadores> Indicadores { get; set; }

    public virtual DbSet<Iniciativas> Iniciativas { get; set; }

    public virtual DbSet<PlanEmpresarial> PlanEmpresarial { get; set; }

    public virtual DbSet<Proyectos> Proyectos { get; set; }

    public virtual DbSet<Responsables> Responsables { get; set; }

    public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }

    public virtual DbSet<TipoGasto> TipoGasto { get; set; }

    public virtual DbSet<UbicacionGeografica> UbicacionGeografica { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:190.123.36.244,2527;Initial Catalog=BOOTCAMP-G6;Persist Security Info=False;User ID=sa;Password=Nathasha2023*;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.Entity<AspNetRoleClaims>(entity =>
        //{
        //    entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

        //    entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        //});

        //modelBuilder.Entity<AspNetRoles>(entity =>
        //{
        //    entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
        //        .IsUnique()
        //        .HasFilter("([NormalizedName] IS NOT NULL)");

        //    entity.Property(e => e.Name).HasMaxLength(256);
        //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
        //});

        //modelBuilder.Entity<AspNetUserClaims>(entity =>
        //{
        //    entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        //});

        //modelBuilder.Entity<AspNetUserLogins>(entity =>
        //{
        //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

        //    entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

        //    entity.Property(e => e.LoginProvider).HasMaxLength(128);
        //    entity.Property(e => e.ProviderKey).HasMaxLength(128);

        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        //});

        //modelBuilder.Entity<AspNetUserTokens>(entity =>
        //{
        //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

        //    entity.Property(e => e.LoginProvider).HasMaxLength(128);
        //    entity.Property(e => e.Name).HasMaxLength(128);

        //    entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        //});

        //modelBuilder.Entity<AspNetUsers>(entity =>
        //{
        //    entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

        //    entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
        //        .IsUnique()
        //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

        //    entity.Property(e => e.Email).HasMaxLength(256);
        //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
        //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
        //    entity.Property(e => e.UserName).HasMaxLength(256);

        //    entity.HasMany(d => d.Role).WithMany(p => p.User)
        //        .UsingEntity<Dictionary<string, object>>(
        //            "AspNetUserRoles",
        //            r => r.HasOne<AspNetRoles>().WithMany().HasForeignKey("RoleId"),
        //            l => l.HasOne<AspNetUsers>().WithMany().HasForeignKey("UserId"),
        //            j =>
        //            {
        //                j.HasKey("UserId", "RoleId");
        //                j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
        //            });
        //});

        modelBuilder.Entity<Cargos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cargos__3213E83FF2FEB091");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.DescripcionCargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcionCargo");
        });

        modelBuilder.Entity<CertificadoAmbiental>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Certific__3213E83FCB2FB320");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.NombreCertificado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCertificado");
        });

        modelBuilder.Entity<DetallesGastos>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");
            entity.Property(e => e.IdentificacionProveedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("identificacionProveedor");
            entity.Property(e => e.NombresProveedor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombresProveedor");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroFactura");
            entity.Property(e => e.TipoGastoId).HasColumnName("tipoGastoId");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany()
                .HasForeignKey(d => d.IdProyecto)
                .HasConstraintName("FK_DetallesGastos_Proyectos");

            entity.HasOne(d => d.TipoGasto).WithMany()
                .HasForeignKey(d => d.TipoGastoId)
                .HasConstraintName("FK_DetallesGastos_TipoGasto");
        });

        modelBuilder.Entity<DetallesProyectos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Detalles__3213E83F618222DC");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ActividadRealizada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("actividadRealizada");
            entity.Property(e => e.DetalleActividad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("detalleActividad");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fechaFinal");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");
            entity.Property(e => e.PorcentajeAvance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("porcentajeAvance");
            entity.Property(e => e.Prioridad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prioridad");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.DetallesProyectos)
                .HasForeignKey(d => d.IdProyecto)
                .HasConstraintName("FK_DetallesProyectos_Proyectos");
        });

        modelBuilder.Entity<DocumentosAdjuntos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3213E83F85B68372");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.FechaCreado)
                .HasColumnType("datetime")
                .HasColumnName("fechaCreado");
            entity.Property(e => e.FilePath)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("filePath");
            entity.Property(e => e.IdDetalleProyecto).HasColumnName("idDetalleProyecto");
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreDocumento");

            entity.HasOne(d => d.IdDetalleProyectoNavigation).WithMany(p => p.DocumentosAdjuntos)
                .HasForeignKey(d => d.IdDetalleProyecto)
                .HasConstraintName("FK_DocumentosAdjuntos_DetallesProyectos");
        });

        modelBuilder.Entity<Empresas>(entity =>
        {
            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Ruc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ruc");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UbicacionGeograficaId).HasColumnName("ubicacionGeograficaId");

            entity.HasOne(d => d.UbicacionGeografica).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.UbicacionGeograficaId)
                .HasConstraintName("FK_Empresas_UbicacionGeografica");
        });

        modelBuilder.Entity<Indicadores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Indicado__3213E83F92DB962D");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");
            entity.Property(e => e.NombreIndicador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreIndicador");
            entity.Property(e => e.SiglaIndicador)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("siglaIndicador");
            entity.Property(e => e.TipoIndicador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoIndicador");
            entity.Property(e => e.ValorIndicador)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("valorIndicador");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.Indicadores)
                .HasForeignKey(d => d.IdProyecto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Indicadores_Proyectos");
        });

        modelBuilder.Entity<Iniciativas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Iniciati__3213E83F8D0C7875");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.DescripcionIniciativa)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcionIniciativa");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.NombreIniciativa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreIniciativa");
        });

        modelBuilder.Entity<PlanEmpresarial>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Indicador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("indicador");
            entity.Property(e => e.MetaPrincipal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("metaPrincipal");
            entity.Property(e => e.MetaSecundaria)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("metaSecundaria");
            entity.Property(e => e.Objetivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("objetivo");
            entity.Property(e => e.Politica)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("politica");
        });

        modelBuilder.Entity<Proyectos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proyecto__3213E83FB1E2FE4A");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Anio)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("anio");
            entity.Property(e => e.CertificadoAmbientalId).HasColumnName("certificadoAmbientalId");
            entity.Property(e => e.DescripcionProyecto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcionProyecto");
            entity.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("fechaFinal");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdIniciativa).HasColumnName("idIniciativa");
            entity.Property(e => e.ResponsablesId).HasColumnName("responsablesId");
            entity.Property(e => e.TituloProyecto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tituloProyecto");
            entity.Property(e => e.UbicacionGeograficaId).HasColumnName("ubicacionGeograficaId");
            entity.Property(e => e.UsuarioCrea).HasColumnName("usuarioCrea");

            entity.HasOne(d => d.CertificadoAmbiental).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.CertificadoAmbientalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proyectos_CertificadoAmbiental");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_Proyectos_Empresas");

            entity.HasOne(d => d.IdIniciativaNavigation).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.IdIniciativa)
                .HasConstraintName("FK_Proyectos_Iniciativas");

            entity.HasOne(d => d.IdPlanEmpresarialNavigation).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.IdPlanEmpresarial)
                .HasConstraintName("FK_Proyectos_PlanEmpresarial");

            entity.HasOne(d => d.Responsables).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.ResponsablesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proyectos_Responsables");

            entity.HasOne(d => d.UbicacionGeografica).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.UbicacionGeograficaId)
                .HasConstraintName("FK_Proyectos_UbicacionGeografica");
        });

        modelBuilder.Entity<Responsables>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Responsa__3213E83F555D277B");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CargoId).HasColumnName("cargoId");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.NombreCargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCargo");
            entity.Property(e => e.Nombres)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombres");

            entity.HasOne(d => d.Cargo).WithMany(p => p.Responsables)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK_Responsables_Cargos");
        });

        modelBuilder.Entity<Sysdiagrams>(entity =>
        {
            entity.HasKey(e => e.DiagramId).HasName("PK__sysdiagr__C2B05B61BD0BD5F0");

            entity.ToTable("sysdiagrams");

            entity.HasIndex(e => new { e.PrincipalId, e.Name }, "UK_principal_name").IsUnique();

            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TipoGasto>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Detalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
        });

        modelBuilder.Entity<UbicacionGeografica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ubicacio__3213E83FA1B59553");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Canton)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("canton");
            entity.Property(e => e.Latitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("longitud");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parroquia");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("provincia");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sector");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.HasIndex(e => e.Identificacion, "Usuario_Identificacion_IDX")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.IdUsuario).HasDefaultValueSql("(newid())");
            entity.Property(e => e.EsAdministradorSistema).HasDefaultValueSql("((0))");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
