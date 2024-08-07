﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinalGourmetGrill.Data;

#nullable disable

namespace ProyectoFinalGourmetGrill.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240808193644_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProyectoFinalGourmetGrill.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Shared.Models.CategoriaProductos", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("CategoriaProductos");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Hamburguesas"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Papas"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Acompañantes"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Bebidas"
                        });
                });

            modelBuilder.Entity("Shared.Models.Estados", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"));

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoId");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            EstadoId = 1,
                            NombreEstado = "Pendiente"
                        },
                        new
                        {
                            EstadoId = 2,
                            NombreEstado = "Preparando"
                        },
                        new
                        {
                            EstadoId = 3,
                            NombreEstado = "YA ESTÁ LISTA"
                        },
                        new
                        {
                            EstadoId = 4,
                            NombreEstado = "Cancelado"
                        });
                });

            modelBuilder.Entity("Shared.Models.MetodoPagos", b =>
                {
                    b.Property<int>("MetodoPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetodoPagoId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MetodoPagoId");

                    b.ToTable("MetodoPagos");

                    b.HasData(
                        new
                        {
                            MetodoPagoId = 1,
                            Nombre = "Efectivo"
                        },
                        new
                        {
                            MetodoPagoId = 2,
                            Nombre = "Tarjeta"
                        });
                });

            modelBuilder.Entity("Shared.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdenId"));

                    b.Property<string>("ClienteId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<float>("ITBIS")
                        .HasColumnType("real");

                    b.Property<int>("MetodoPagoId")
                        .HasColumnType("int");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrdenId");

                    b.HasIndex("MetodoPagoId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("Shared.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<float>("ITBIS")
                        .HasColumnType("real");

                    b.Property<string>("ImagenUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Papa, Doble Carne de 95g, Doble Queso Pepper Jack, Mermelada de Arandanos, Pesto y Aderezo de Perejil",
                            Disponible = true,
                            ITBIS = 85.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/UltimateCrackBurger.jpg",
                            Nombre = "La Intensa",
                            Precio = 475f
                        },
                        new
                        {
                            ProductoId = 2,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Papa, Doble Carne de 95g, Doble Queso Americano, Mermelada de Bacon y Crema de Hongos Trufada",
                            Disponible = true,
                            ITBIS = 90f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/PizzaBurger.jpg",
                            Nombre = "Funghi Girl",
                            Precio = 500f
                        },
                        new
                        {
                            ProductoId = 3,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Papa, Doble Carne de 95g, Doble Queso Americano, Bacon, Pulled Pork con Salsa BBQ y Coleslaw",
                            Disponible = true,
                            ITBIS = 72f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/Formula.jpg",
                            Nombre = "La Formula",
                            Precio = 450f
                        },
                        new
                        {
                            ProductoId = 4,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Brioche, Doble Carne de 95g, Doble Queso Americano, Bacon y Aderezo Spread",
                            Disponible = true,
                            ITBIS = 58.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/ClassicBacon.jpg",
                            Nombre = "Clasic Bacon",
                            Precio = 325f
                        },
                        new
                        {
                            ProductoId = 5,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Papa, Doble Carne de 95g, Doble Queso Americano, Cebolla Smashed y Alioli de Ajo",
                            Disponible = true,
                            ITBIS = 76.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/Oklahoma.jpg",
                            Nombre = "Oklahoma",
                            Precio = 425f
                        },
                        new
                        {
                            ProductoId = 6,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan Brioche de Molde, Pechuga Empanizada, Doble Queso Americano, Bacon, Miel y Spicy Mayo",
                            Disponible = true,
                            ITBIS = 72f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/KitchenBurguer.jpg",
                            Nombre = "Kitchen Little",
                            Precio = 400f
                        },
                        new
                        {
                            ProductoId = 7,
                            Cantidad = 50,
                            CategoriaId = 1,
                            Descripcion = "Pan de Papa, Doble Carne de 95g, Doble Queso Americano, Mermelada de Bacon, Aros de Cebolla Empanizadas y BBQ",
                            Disponible = true,
                            ITBIS = 90f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/CheeseBurguer.jpg",
                            Nombre = "Baby Q",
                            Precio = 500f
                        },
                        new
                        {
                            ProductoId = 8,
                            Cantidad = 50,
                            CategoriaId = 2,
                            Descripcion = "Papas Fritas, Fondue de Queso Cheddar, Puerro y Bacon Bites",
                            Disponible = true,
                            ITBIS = 63f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/BaconFries.jpg",
                            Nombre = "Bacon Cheese Fries",
                            Precio = 350f
                        },
                        new
                        {
                            ProductoId = 9,
                            Cantidad = 50,
                            CategoriaId = 2,
                            Descripcion = "Papas Fritas, Chilli, Fondue de Queso Cheddar y Alioli de Ajo",
                            Disponible = true,
                            ITBIS = 67.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/ChiliFries.jpg",
                            Nombre = "Chilli Fries",
                            Precio = 375f
                        },
                        new
                        {
                            ProductoId = 10,
                            Cantidad = 50,
                            CategoriaId = 2,
                            Descripcion = "Papas Fritas, Birria, Alioli de Ajo y Doble Queso Pepper Jack",
                            Disponible = true,
                            ITBIS = 90f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/BirriaFries.jpg",
                            Nombre = "Birria Fries",
                            Precio = 500f
                        },
                        new
                        {
                            ProductoId = 11,
                            Cantidad = 50,
                            CategoriaId = 3,
                            Descripcion = "Papas Fritas",
                            Disponible = true,
                            ITBIS = 9f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/Fries.jpg",
                            Nombre = "Papas Fritas",
                            Precio = 50f
                        },
                        new
                        {
                            ProductoId = 12,
                            Cantidad = 50,
                            CategoriaId = 3,
                            Descripcion = "Papas Enteras con Su piel cortadas Por La Mitad y Sazonadas con Ajo, Sal y Pimienta",
                            Disponible = true,
                            ITBIS = 25.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/PotatoWedges.jpg",
                            Nombre = "Papas Wedges",
                            Precio = 125f
                        },
                        new
                        {
                            ProductoId = 13,
                            Cantidad = 50,
                            CategoriaId = 3,
                            Descripcion = "5 Cebollas Fritas",
                            Disponible = true,
                            ITBIS = 13.5f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/FriedOnion.jpg",
                            Nombre = "Aros de Cebolla",
                            Precio = 75f
                        },
                        new
                        {
                            ProductoId = 14,
                            Cantidad = 50,
                            CategoriaId = 4,
                            Descripcion = "Botella de Agua Fria",
                            Disponible = true,
                            ITBIS = 3.6f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/BottleWaterjpg.jpg",
                            Nombre = "Agua",
                            Precio = 20f
                        },
                        new
                        {
                            ProductoId = 15,
                            Cantidad = 50,
                            CategoriaId = 4,
                            Descripcion = "Coca Cola 500ml de Cristal",
                            Disponible = true,
                            ITBIS = 9f,
                            ImagenUrl = "https://stgourmetgrilldv001.blob.core.windows.net/gourmetweb/Cocacola.jpg",
                            Nombre = "Coca Cola 500ml ",
                            Precio = 50f
                        });
                });

            modelBuilder.Entity("Shared.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VentaId"));

                    b.Property<string>("ClienteId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Devuelta")
                        .HasColumnType("real");

                    b.Property<bool>("Eliminada")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<float>("ITBS")
                        .HasColumnType("real");

                    b.Property<int>("MetodoPagoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrdenId")
                        .HasColumnType("int");

                    b.Property<float>("Recibido")
                        .HasColumnType("real");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Shared.Models.VentasDetalle", b =>
                {
                    b.Property<int>("DetalleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("DetalleID");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProyectoFinalGourmetGrill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProyectoFinalGourmetGrill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoFinalGourmetGrill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProyectoFinalGourmetGrill.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared.Models.Ordenes", b =>
                {
                    b.HasOne("Shared.Models.MetodoPagos", "MetodoPago")
                        .WithMany()
                        .HasForeignKey("MetodoPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MetodoPago");
                });

            modelBuilder.Entity("Shared.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("Shared.Models.Ordenes", "Orden")
                        .WithMany("OrdenesDetalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Shared.Models.Productos", b =>
                {
                    b.HasOne("Shared.Models.CategoriaProductos", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Shared.Models.VentasDetalle", b =>
                {
                    b.HasOne("Shared.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Ventas", null)
                        .WithMany("VentasDetalle")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Shared.Models.Ordenes", b =>
                {
                    b.Navigation("OrdenesDetalle");
                });

            modelBuilder.Entity("Shared.Models.Ventas", b =>
                {
                    b.Navigation("VentasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
