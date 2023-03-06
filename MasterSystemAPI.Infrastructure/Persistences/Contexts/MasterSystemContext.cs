using System;
using System.Collections.Generic;
using System.Reflection;
using MasterSystemAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MasterSystemAPI.Infrastructure.Persistences.Contexts
{
public partial class MasterSystemContext : DbContext
{
    public MasterSystemContext()
    {
    }

    public MasterSystemContext(DbContextOptions<MasterSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Antena> Antenas { get; set; }

    public virtual DbSet<AtencionCliente> AtencionClientes { get; set; }

    public virtual DbSet<CatEquipo> CatEquipos { get; set; }

    public virtual DbSet<CatServicio> CatServicios { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Colonia> Colonia { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Evidencia> Evidencias { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Instalacione> Instalaciones { get; set; }

    public virtual DbSet<Ip> Ips { get; set; }

    public virtual DbSet<IpSegmento> IpSegmentos { get; set; }

    public virtual DbSet<MasterSystemRole> MasterSystemRoles { get; set; }

    public virtual DbSet<MasterSystemUser> MasterSystemUsers { get; set; }

    public virtual DbSet<MasterSystemUserRole> MasterSystemUserRoles { get; set; }

    public virtual DbSet<Materiales> Materiales { get; set; }

    public virtual DbSet<Modalidad> Modalidads { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<Prorroga> Prorrogas { get; set; }

    public virtual DbSet<Router> Routers { get; set; }

    public virtual DbSet<Sectore> Sectores { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServidorSegmento> ServidorSegmentos { get; set; }

    public virtual DbSet<Servidore> Servidores { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<TelefonoSucursal> TelefonoSucursals { get; set; }

    public virtual DbSet<Torre> Torres { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-DFMDME5;Database=MasterSystem;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
