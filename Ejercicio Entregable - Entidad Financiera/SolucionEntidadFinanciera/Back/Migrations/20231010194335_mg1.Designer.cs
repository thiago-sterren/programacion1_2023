﻿// <auto-generated />
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231010194335_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cantidadCuentas")
                        .HasColumnType("int");

                    b.Property<int>("cantidadTarjetas")
                        .HasColumnType("int");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Back.CuentaBancaria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("idClienteTitularid")
                        .HasColumnType("int");

                    b.Property<string>("numeroCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("saldo")
                        .HasColumnType("float");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idClienteTitularid");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Back.TarjetaCredito", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<double>("MontoDeuda")
                        .HasColumnType("float");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("idClienteTitularid")
                        .HasColumnType("int");

                    b.Property<double>("limiteCredito")
                        .HasColumnType("float");

                    b.Property<string>("numeroTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("saldoDisponible")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("idClienteTitularid");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("Back.CuentaBancaria", b =>
                {
                    b.HasOne("Back.Cliente", "idClienteTitular")
                        .WithMany()
                        .HasForeignKey("idClienteTitularid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idClienteTitular");
                });

            modelBuilder.Entity("Back.TarjetaCredito", b =>
                {
                    b.HasOne("Back.Cliente", "idClienteTitular")
                        .WithMany()
                        .HasForeignKey("idClienteTitularid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("idClienteTitular");
                });
#pragma warning restore 612, 618
        }
    }
}
