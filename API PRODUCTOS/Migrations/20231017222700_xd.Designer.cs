﻿// <auto-generated />
using API_PRODUCTOS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_PRODUCTOS.Migrations
{
    [DbContext(typeof(AplicationDBContext))]
    [Migration("20231017222700_xd")]
    partial class xd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_PRODUCTOS.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Cantidad = 12,
                            Descripcion = "xfgx",
                            Nombre = "Producto"
                        },
                        new
                        {
                            IdProducto = 2,
                            Cantidad = 22,
                            Descripcion = "utyr",
                            Nombre = "Producto"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
