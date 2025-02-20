﻿// <auto-generated />
using CrudBackEnd.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CrudBackEnd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CrudBackEnd.Models.DetalleFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("integer");

                    b.Property<int>("FacturaId")
                        .HasColumnType("integer");

                    b.Property<int>("PrecioUnitario")
                        .HasColumnType("integer");

                    b.Property<int>("Producto")
                        .HasColumnType("integer");

                    b.Property<int>("Subtotal")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("DetalleFacturas");
                });

            modelBuilder.Entity("CrudBackEnd.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });
#pragma warning restore 612, 618
        }
    }
}
