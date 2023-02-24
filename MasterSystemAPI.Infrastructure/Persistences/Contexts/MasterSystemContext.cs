using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MasterSystemAPI.Domain.Entities;

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

    public virtual DbSet<Colonium> Colonia { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Evidencia> Evidencias { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Instalacione> Instalaciones { get; set; }

    public virtual DbSet<Ip> Ips { get; set; }

    public virtual DbSet<IpSegmento> IpSegmentos { get; set; }

    public virtual DbSet<MasterSystemRole> MasterSystemRoles { get; set; }

    public virtual DbSet<MasterSystemUser> MasterSystemUsers { get; set; }

    public virtual DbSet<MasterSystemUserRole> MasterSystemUserRoles { get; set; }

    public virtual DbSet<Materiale> Materiales { get; set; }

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
        modelBuilder.Entity<Antena>(entity =>
        {
            entity.HasKey(e => e.Idantena);

            entity.Property(e => e.Idantena).HasColumnName("IDAntena");
            entity.Property(e => e.Equipo).HasMaxLength(100);
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Marca).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Antenas_Clientes");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Antenas_Servicios");

            entity.HasOne(d => d.UsuarioInstaladorNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.UsuarioInstalador)
                .HasConstraintName("FK_Antenas_MasterSystemUsers");
        });

        modelBuilder.Entity<AtencionCliente>(entity =>
        {
            entity.HasKey(e => e.Idatencion);

            entity.ToTable("AtencionCliente");

            entity.Property(e => e.Idatencion).HasColumnName("IDAtencion");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Status).HasMaxLength(100);

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_AtencionCliente_Clientes");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_AtencionCliente_Servicios");

            entity.HasOne(d => d.UsuarioAtencionNavigation).WithMany(p => p.AtencionClientes)
                .HasForeignKey(d => d.UsuarioAtencion)
                .HasConstraintName("FK_AtencionCliente_MasterSystemUsers");
        });

        modelBuilder.Entity<CatEquipo>(entity =>
        {
            entity.ToTable("Cat_Equipo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<CatServicio>(entity =>
        {
            entity.ToTable("Cat_Servicios");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApMaterno).HasMaxLength(100);
            entity.Property(e => e.ApPaterno).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Nombreempresa).HasMaxLength(2500);
            entity.Property(e => e.Telefono).HasMaxLength(50);

            entity.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Clientes_Colonia");

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Clientes_Municipio");
        });

        modelBuilder.Entity<Colonium>(entity =>
        {
            entity.HasKey(e => e.Idcolonia);

            entity.Property(e => e.Idcolonia).HasColumnName("IDColonia");
            entity.Property(e => e.CodigoPostal).HasMaxLength(50);
            entity.Property(e => e.Colonia).HasMaxLength(150);
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.ToTable("Equipo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Nombre).HasMaxLength(250);

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Equipo_Cat_Equipo");
        });

        modelBuilder.Entity<Evidencia>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idservicios).HasColumnName("IDServicios");
            entity.Property(e => e.Nombre).HasMaxLength(250);

            entity.HasOne(d => d.IdserviciosNavigation).WithMany(p => p.Evidencia)
                .HasForeignKey(d => d.Idservicios)
                .HasConstraintName("FK_Evidencias_Servicios");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Idfactura);

            entity.ToTable("Factura");

            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.Cambio).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FolioPago).HasMaxLength(250);
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idpago).HasColumnName("IDPago");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            entity.Property(e => e.Iva).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Link).HasMaxLength(150);
            entity.Property(e => e.Pago).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TipoPago).HasMaxLength(150);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Factura_Clientes");

            entity.HasOne(d => d.IdpagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idpago)
                .HasConstraintName("FK_Factura_Pagos");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Factura_Servicios");

            entity.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_Factura_Sucursal");

            entity.HasOne(d => d.UsuarioCobroNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.UsuarioCobro)
                .HasConstraintName("FK_Factura_MasterSystemUsers");
        });

        modelBuilder.Entity<Instalacione>(entity =>
        {
            entity.HasKey(e => e.Idinstalacion);

            entity.Property(e => e.Idinstalacion).HasColumnName("IDInstalacion");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Equipo).HasMaxLength(100);
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        modelBuilder.Entity<Ip>(entity =>
        {
            entity.HasKey(e => e.Idip);

            entity.ToTable("Ip");

            entity.Property(e => e.Idip).HasColumnName("IDIp");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Idservidor).HasColumnName("IDServidor");
            entity.Property(e => e.Target).HasMaxLength(250);

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Ip_Clientes");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Ip_Servicios");

            entity.HasOne(d => d.IdservidorNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.Idservidor)
                .HasConstraintName("FK_Ip_Servidores");

            entity.HasOne(d => d.UsuarioInfraNavigation).WithMany(p => p.Ips)
                .HasForeignKey(d => d.UsuarioInfra)
                .HasConstraintName("FK_Ip_MasterSystemUsers");
        });

        modelBuilder.Entity<IpSegmento>(entity =>
        {
            entity.HasKey(e => e.Idsegmento);

            entity.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
        });

        modelBuilder.Entity<MasterSystemRole>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(450);
            entity.Property(e => e.RoleName).HasMaxLength(450);
        });

        modelBuilder.Entity<MasterSystemUser>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApMaterno).HasMaxLength(100);
            entity.Property(e => e.ApPaterno).HasMaxLength(100);
            entity.Property(e => e.Correo).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(250);

            entity.HasOne(d => d.SucursalNavigation).WithMany(p => p.MasterSystemUsers)
                .HasForeignKey(d => d.Sucursal)
                .HasConstraintName("FK_MasterSystemUsers_Sucursal");
        });

        modelBuilder.Entity<MasterSystemUserRole>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.Role).WithMany()
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_MasterSystemUserRoles_MasterSystemRoles");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MasterSystemUserRoles_MasterSystemUsers");
        });

        modelBuilder.Entity<Materiale>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idservicios).HasColumnName("IDServicios");
            entity.Property(e => e.Nombre).HasMaxLength(250);

            entity.HasOne(d => d.IdserviciosNavigation).WithMany(p => p.Materiales)
                .HasForeignKey(d => d.Idservicios)
                .HasConstraintName("FK_Materiales_Servicios");
        });

        modelBuilder.Entity<Modalidad>(entity =>
        {
            entity.HasKey(e => e.Idmodalidad);

            entity.ToTable("Modalidad");

            entity.Property(e => e.Idmodalidad).HasColumnName("IDModalidad");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Nombre).HasMaxLength(250);
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.Idmunicipio);

            entity.ToTable("Municipio");

            entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");
            entity.Property(e => e.Estado).HasMaxLength(150);
            entity.Property(e => e.Municipio1)
                .HasMaxLength(150)
                .HasColumnName("Municipio");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Idpago);

            entity.Property(e => e.Idpago).HasColumnName("IDPago");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.Idprorroga).HasColumnName("IDProrroga");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Idsucursal).HasColumnName("IDSucursal");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Pagos_Clientes");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idfactura)
                .HasConstraintName("FK_Pagos_Factura");

            entity.HasOne(d => d.IdprorrogaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idprorroga)
                .HasConstraintName("FK_Pagos_Prorroga");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Pagos_Servicios");

            entity.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_Pagos_Sucursal");

            entity.HasOne(d => d.UsuarioCobroNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.UsuarioCobro)
                .HasConstraintName("FK_Pagos_MasterSystemUsers");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Paquete");

            entity.Property(e => e.Idequipo).HasColumnName("IDEquipo");
            entity.Property(e => e.Idinstalacion).HasColumnName("IDInstalacion");

            entity.HasOne(d => d.IdequipoNavigation).WithMany()
                .HasForeignKey(d => d.Idequipo)
                .HasConstraintName("FK_Paquete_Equipo");

            entity.HasOne(d => d.IdinstalacionNavigation).WithMany()
                .HasForeignKey(d => d.Idinstalacion)
                .HasConstraintName("FK_Paquete_Instalaciones");
        });

        modelBuilder.Entity<Prorroga>(entity =>
        {
            entity.HasKey(e => e.Idprorroga);

            entity.ToTable("Prorroga");

            entity.Property(e => e.Idprorroga).HasColumnName("IDProrroga");
            entity.Property(e => e.FechaRevision).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
        });

        modelBuilder.Entity<Router>(entity =>
        {
            entity.HasKey(e => e.Idrouter);

            entity.Property(e => e.Idrouter).HasColumnName("IDRouter");
            entity.Property(e => e.Equipo).HasMaxLength(100);
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idservicio).HasColumnName("IDServicio");
            entity.Property(e => e.Marca).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Routers_Clientes");

            entity.HasOne(d => d.IdservicioNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.Idservicio)
                .HasConstraintName("FK_Routers_Servicios");

            entity.HasOne(d => d.UsuarioInstaladorNavigation).WithMany(p => p.Routers)
                .HasForeignKey(d => d.UsuarioInstalador)
                .HasConstraintName("FK_Routers_MasterSystemUsers");
        });

        modelBuilder.Entity<Sectore>(entity =>
        {
            entity.HasKey(e => e.Idsector);

            entity.Property(e => e.Idsector).HasColumnName("IDSector");
            entity.Property(e => e.Cmh3)
                .HasMaxLength(100)
                .HasColumnName("CMH3");
            entity.Property(e => e.Contraseña).HasMaxLength(100);
            entity.Property(e => e.Frecuencia).HasMaxLength(100);
            entity.Property(e => e.Idtorre).HasColumnName("IDTorre");
            entity.Property(e => e.IpFinal).HasMaxLength(100);
            entity.Property(e => e.IpInicio).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Red).HasMaxLength(100);
            entity.Property(e => e.Ssid)
                .HasMaxLength(100)
                .HasColumnName("SSID");
            entity.Property(e => e.Usuario).HasMaxLength(100);

            entity.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Sectores)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Sectores_Colonia");

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Sectores)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Sectores_Municipio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaCorte).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioCorte).HasColumnType("datetime");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idevidencias).HasColumnName("IDEvidencias");
            entity.Property(e => e.Idmateriales).HasColumnName("IDMateriales");
            entity.Property(e => e.Servicio1).HasColumnName("Servicio");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK_Servicios_Clientes");

            entity.HasOne(d => d.IdevidenciasNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idevidencias)
                .HasConstraintName("FK_Servicios_Evidencias");

            entity.HasOne(d => d.IdmaterialesNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Idmateriales)
                .HasConstraintName("FK_Servicios_Materiales");

            entity.HasOne(d => d.InstalacionNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Instalacion)
                .HasConstraintName("FK_Servicios_Instalaciones");

            entity.HasOne(d => d.ProrrogaNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Prorroga)
                .HasConstraintName("FK_Servicios_Prorroga");

            entity.HasOne(d => d.SectorNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Sector)
                .HasConstraintName("FK_Servicios_Sectores");

            entity.HasOne(d => d.Servicio1Navigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Servicio1)
                .HasConstraintName("FK_Servicios_Modalidad");

            entity.HasOne(d => d.ServidorNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Servidor)
                .HasConstraintName("FK_Servicios_Servidores");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Servicios_Cat_Servicios");

            entity.HasOne(d => d.TorreNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.Torre)
                .HasConstraintName("FK_Servicios_Torres");

            entity.HasOne(d => d.UsuarioServicioNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.UsuarioServicio)
                .HasConstraintName("FK_Servicios_MasterSystemUsers");
        });

        modelBuilder.Entity<ServidorSegmento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Servidor_Segmento");

            entity.Property(e => e.Idsegmento).HasColumnName("IDSegmento");
            entity.Property(e => e.Idservidor).HasColumnName("IDServidor");

            entity.HasOne(d => d.IdsegmentoNavigation).WithMany()
                .HasForeignKey(d => d.Idsegmento)
                .HasConstraintName("FK_Servidor_Segmento_IpSegmentos");

            entity.HasOne(d => d.IdservidorNavigation).WithMany()
                .HasForeignKey(d => d.Idservidor)
                .HasConstraintName("FK_Servidor_Segmento_Servidores");
        });

        modelBuilder.Entity<Servidore>(entity =>
        {
            entity.HasKey(e => e.Idservidor);

            entity.Property(e => e.Idservidor).HasColumnName("IDServidor");
            entity.Property(e => e.Idsector).HasColumnName("IDSector");
            entity.Property(e => e.Idtorre).HasColumnName("IDTorre");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.IdsectorNavigation).WithMany(p => p.Servidores)
                .HasForeignKey(d => d.Idsector)
                .HasConstraintName("FK_Servidores_Sectores");

            entity.HasOne(d => d.IdtorreNavigation).WithMany(p => p.Servidores)
                .HasForeignKey(d => d.Idtorre)
                .HasConstraintName("FK_Servidores_Torres");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.Idsucursal);

            entity.ToTable("Sucursal");

            entity.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.ColoniaNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.Colonia)
                .HasConstraintName("FK_Sucursal_Colonia");

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Sucursals)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Sucursal_Municipio");
        });

        modelBuilder.Entity<TelefonoSucursal>(entity =>
        {
            entity.HasKey(e => e.Idtelefono);

            entity.ToTable("TelefonoSucursal");

            entity.Property(e => e.Idtelefono).HasColumnName("IDTelefono");
            entity.Property(e => e.Idsucursal).HasColumnName("IDSucursal");
            entity.Property(e => e.Numero).HasMaxLength(150);
            entity.Property(e => e.Tipo).HasMaxLength(100);

            entity.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.TelefonoSucursals)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_TelefonoSucursal_Sucursal");
        });

        modelBuilder.Entity<Torre>(entity =>
        {
            entity.HasKey(e => e.Idtorre);

            entity.Property(e => e.Idtorre).HasColumnName("IDTorre");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.MunicipioNavigation).WithMany(p => p.Torres)
                .HasForeignKey(d => d.Municipio)
                .HasConstraintName("FK_Torres_Municipio");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Zona");

            entity.Property(e => e.Idcolonia).HasColumnName("IDColonia");
            entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

            entity.HasOne(d => d.IdcoloniaNavigation).WithMany()
                .HasForeignKey(d => d.Idcolonia)
                .HasConstraintName("FK_Zona_Colonia");

            entity.HasOne(d => d.IdmunicipioNavigation).WithMany()
                .HasForeignKey(d => d.Idmunicipio)
                .HasConstraintName("FK_Zona_Municipio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
