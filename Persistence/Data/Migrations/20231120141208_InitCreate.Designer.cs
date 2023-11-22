﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(GardensContext))]
    [Migration("20231120141208_InitCreate")]
    partial class InitCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("IdRegionFk")
                        .HasColumnType("int")
                        .HasColumnName("idRegionFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdRegionFk" }, "idRegionFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ApellidoContacto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("apellidoContacto");

                    b.Property<string>("Fax")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("fax");

                    b.Property<int>("IdDireccionFk")
                        .HasColumnType("int")
                        .HasColumnName("idDireccionFk");

                    b.Property<int>("IdEmpleadoRepresentanteVentasFk")
                        .HasColumnType("int")
                        .HasColumnName("idEmpleadoRepresentanteVentasFk");

                    b.Property<decimal>("LimiteCredito")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("limiteCredito");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.Property<string>("NombreContacto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombreContacto");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDireccionFk" }, "idDireccionFk");

                    b.HasIndex(new[] { "IdEmpleadoRepresentanteVentasFk" }, "idEmpleadoRepresentanteVentasFk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detallepedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("IdPedidoFk")
                        .HasColumnType("int")
                        .HasColumnName("idPedidoFk");

                    b.Property<string>("IdProductoFk")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("idProductoFk");

                    b.Property<int?>("NumeroLinea")
                        .HasColumnType("int")
                        .HasColumnName("numeroLinea");

                    b.Property<decimal?>("PrecioUnidad")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precioUnidad");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPedidoFk" }, "idPedidoFk");

                    b.HasIndex(new[] { "IdProductoFk" }, "idProductoFk");

                    b.ToTable("detallepedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("bis")
                        .IsFixedLength();

                    b.Property<string>("CardinalPrimario")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinalPrimario")
                        .IsFixedLength();

                    b.Property<string>("CardinalSecundario")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinalSecundario")
                        .IsFixedLength();

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("codigoPostal");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int")
                        .HasColumnName("idCiudadFk");

                    b.Property<string>("IdOficinaFk")
                        .HasColumnType("longtext");

                    b.Property<string>("LetraPrincipal")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letraPrincipal")
                        .IsFixedLength();

                    b.Property<string>("LetraSecundaria")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letraSecundaria")
                        .IsFixedLength();

                    b.Property<string>("LetraTerciaria")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letraTerciaria")
                        .IsFixedLength();

                    b.Property<short?>("NumeroPrincipal")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroPrincipal");

                    b.Property<short?>("NumeroSecundario")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroSecundario");

                    b.Property<short?>("NumeroTerciario")
                        .HasColumnType("smallint")
                        .HasColumnName("numeroTerciario");

                    b.Property<string>("TipoVia")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipoVia");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCiudadFk" }, "idCiudadFk");

                    b.ToTable("direccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Apellido")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<int>("IdDireccionFk")
                        .HasColumnType("int")
                        .HasColumnName("idDireccionFk");

                    b.Property<int>("IdJefeFk")
                        .HasColumnType("int");

                    b.Property<int?>("IdJefeFkNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("IdOficinaFk")
                        .HasColumnType("longtext");

                    b.Property<string>("IdOficinaFkNavigationId")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdPuestoFk")
                        .HasColumnType("int")
                        .HasColumnName("idPuestoFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex("IdJefeFkNavigationId");

                    b.HasIndex("IdOficinaFkNavigationId");

                    b.HasIndex(new[] { "IdDireccionFk" }, "idDireccionFk")
                        .HasDatabaseName("idDireccionFk1");

                    b.HasIndex(new[] { "IdPuestoFk" }, "idPuestoFk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Formapago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("formapago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Gamaproducto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<string>("DescripcionHtml")
                        .HasColumnType("text")
                        .HasColumnName("descripcionHtml");

                    b.Property<string>("DescripcionTexto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcionTexto");

                    b.Property<string>("Imagen")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("imagen");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("gamaproducto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("id");

                    b.Property<int>("IdDireccionFk")
                        .HasColumnType("int")
                        .HasColumnName("idDireccionFk");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex("IdDireccionFk")
                        .IsUnique();

                    b.HasIndex(new[] { "IdDireccionFk" }, "idDireccionFk")
                        .HasDatabaseName("idDireccionFk2");

                    b.ToTable("oficina", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("id");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date")
                        .HasColumnName("fechaPago");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int")
                        .HasColumnName("idFormaPagoFk");

                    b.Property<decimal>("Total")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("total");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFk");

                    b.HasIndex(new[] { "IdFormaPagoFk" }, "idFormaPagoFk");

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Comentarios")
                        .HasColumnType("text")
                        .HasColumnName("comentarios");

                    b.Property<DateOnly?>("FechaEntrega")
                        .HasColumnType("date")
                        .HasColumnName("fechaEntrega");

                    b.Property<DateOnly>("FechaEsperada")
                        .HasColumnType("date")
                        .HasColumnName("fechaEsperada");

                    b.Property<DateOnly>("FechaPedido")
                        .HasColumnType("date")
                        .HasColumnName("fechaPedido");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int")
                        .HasColumnName("idEstadoFk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFk")
                        .HasDatabaseName("idClienteFk1");

                    b.HasIndex(new[] { "IdEstadoFk" }, "idEstadoFk");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("CantidadMax")
                        .HasColumnType("int")
                        .HasColumnName("cantidadMax");

                    b.Property<int?>("CantidadMin")
                        .HasColumnType("int")
                        .HasColumnName("cantidadMin");

                    b.Property<string>("Dimensiones")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("dimensiones");

                    b.Property<string>("IdGamaProductoFk")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("idGamaProductoFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("PrecioVenta")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)")
                        .HasColumnName("precioVenta");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdGamaProductoFk" }, "idGamaProductoFk");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Productoproveedor", b =>
                {
                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int")
                        .HasColumnName("idProveedorFk");

                    b.Property<string>("IdProductoFk")
                        .HasColumnType("varchar(15)")
                        .HasColumnName("idProductoFk");

                    b.Property<decimal?>("PrecioProveedor")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precio_proveedor");

                    b.HasKey("IdProveedorFk", "IdProductoFk")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdProductoFk" }, "idProductoFk")
                        .HasDatabaseName("idProductoFk1");

                    b.ToTable("productoproveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("IdCiudadFk")
                        .HasColumnType("int")
                        .HasColumnName("idCiudadFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCiudadFk" }, "idCiudadFk")
                        .HasDatabaseName("idCiudadFk1");

                    b.ToTable("proveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Puesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("puesto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int")
                        .HasColumnName("idPaisFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPaisFk" }, "idPaisFk");

                    b.ToTable("region", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("date");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("userrol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Region", "IdRegionFkNavigation")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdRegionFk")
                        .HasConstraintName("ciudad_ibfk_1");

                    b.Navigation("IdRegionFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Direccion", "IdDireccionFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdDireccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("cliente_ibfk_2");

                    b.HasOne("Domain.Entities.Empleado", "IdEmpleadoRepresentanteVentasFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdEmpleadoRepresentanteVentasFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("cliente_ibfk_1");

                    b.Navigation("IdDireccionFkNavigation");

                    b.Navigation("IdEmpleadoRepresentanteVentasFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Detallepedido", b =>
                {
                    b.HasOne("Domain.Entities.Pedido", "IdPedidoFkNavigation")
                        .WithMany("Detallepedidos")
                        .HasForeignKey("IdPedidoFk")
                        .HasConstraintName("detallepedido_ibfk_1");

                    b.HasOne("Domain.Entities.Producto", "IdProductoFkNavigation")
                        .WithMany("Detallepedidos")
                        .HasForeignKey("IdProductoFk")
                        .HasConstraintName("detallepedido_ibfk_2");

                    b.Navigation("IdPedidoFkNavigation");

                    b.Navigation("IdProductoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Direcciones")
                        .HasForeignKey("IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("direccion_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Direccion", "IdDireccionFkNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("IdDireccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("empleado_ibfk_1");

                    b.HasOne("Domain.Entities.Empleado", "IdJefeFkNavigation")
                        .WithMany()
                        .HasForeignKey("IdJefeFkNavigationId");

                    b.HasOne("Domain.Entities.Oficina", "IdOficinaFkNavigation")
                        .WithMany()
                        .HasForeignKey("IdOficinaFkNavigationId");

                    b.HasOne("Domain.Entities.Puesto", "IdPuestoFkNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("IdPuestoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("empleado_ibfk_2");

                    b.Navigation("IdDireccionFkNavigation");

                    b.Navigation("IdJefeFkNavigation");

                    b.Navigation("IdOficinaFkNavigation");

                    b.Navigation("IdPuestoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Oficina", b =>
                {
                    b.HasOne("Domain.Entities.Direccion", "IdDireccionFkNavigation")
                        .WithOne("IdOficinaFkNavigation")
                        .HasForeignKey("Domain.Entities.Oficina", "IdDireccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("oficina_ibfk_1");

                    b.Navigation("IdDireccionFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pago_ibfk_1");

                    b.HasOne("Domain.Entities.Formapago", "IdFormaPagoFkNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pago_ibfk_2");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdFormaPagoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pedido_ibfk_1");

                    b.HasOne("Domain.Entities.Estado", "IdEstadoFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pedido_ibfk_2");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdEstadoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.Gamaproducto", "IdGamaProductoFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdGamaProductoFk")
                        .HasConstraintName("producto_ibfk_1");

                    b.Navigation("IdGamaProductoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Productoproveedor", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "IdProductoFkNavigation")
                        .WithMany("Productoproveedores")
                        .HasForeignKey("IdProductoFk")
                        .IsRequired()
                        .HasConstraintName("productoproveedor_ibfk_2");

                    b.HasOne("Domain.Entities.Proveedor", "IdProveedorFkNavigation")
                        .WithMany("Productoproveedores")
                        .HasForeignKey("IdProveedorFk")
                        .IsRequired()
                        .HasConstraintName("productoproveedor_ibfk_1");

                    b.Navigation("IdProductoFkNavigation");

                    b.Navigation("IdProveedorFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Proveedores")
                        .HasForeignKey("IdCiudadFk")
                        .HasConstraintName("proveedor_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisFkNavigation")
                        .WithMany("Regiones")
                        .HasForeignKey("IdPaisFk")
                        .IsRequired()
                        .HasConstraintName("region_ibfk_1");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rols")
                        .WithMany("UserRols")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Users")
                        .WithMany("UserRols")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rols");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("IdOficinaFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Formapago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Domain.Entities.Gamaproducto", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Regiones");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Detallepedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Detallepedidos");

                    b.Navigation("Productoproveedores");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("Productoproveedores");
                });

            modelBuilder.Entity("Domain.Entities.Puesto", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UserRols");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("UserRols");
                });
#pragma warning restore 612, 618
        }
    }
}
