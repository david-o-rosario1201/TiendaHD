﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaHD.DAL;

#nullable disable

namespace TiendaHD.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20250312130927_Compras")]
    partial class Compras
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("TiendaHD.Models.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPantalones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPerfumes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadSweater")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PagoChofer")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PagoComidaChofer")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PagoGasolina")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioPantalones")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioPerfumes")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioSweater")
                        .HasColumnType("TEXT");

                    b.HasKey("CompraId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("TiendaHD.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salario")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("TiendaHD.Models.Financiamientos", b =>
                {
                    b.Property<int>("FinanciamientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CuotaMensual")
                        .HasColumnType("TEXT");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FinanciamientoId");

                    b.ToTable("Financiamientos");
                });

            modelBuilder.Entity("TiendaHD.Models.GastosADM", b =>
                {
                    b.Property<int>("GastosADMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GastosADMName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("ValorGastoADM")
                        .HasColumnType("REAL");

                    b.HasKey("GastosADMId");

                    b.ToTable("GastosADM");
                });

            modelBuilder.Entity("TiendaHD.Models.GastosMenores", b =>
                {
                    b.Property<int>("GastosMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GastosMName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("ValorGastosM")
                        .HasColumnType("REAL");

                    b.HasKey("GastosMId");

                    b.ToTable("GastosMenores");
                });

            modelBuilder.Entity("TiendaHD.Models.Ventas", b =>
                {
                    b.Property<int>("VentasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Articulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("VentasId");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
