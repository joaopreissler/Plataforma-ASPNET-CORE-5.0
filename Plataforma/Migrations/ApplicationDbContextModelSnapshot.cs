﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plataforma.Data;

namespace Plataforma.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Plataforma.Models.Cursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Plataforma.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Banco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNAE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CPComercial")
                        .HasColumnType("int");

                    b.Property<int>("Cp")
                        .HasColumnType("int");

                    b.Property<string>("Cuenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuentaCotizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fechafirma")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Generorepresentante")
                        .HasColumnType("bit");

                    b.Property<int>("Idcurso")
                        .HasColumnType("int");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalidadComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Comercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombrereprensentante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinciaComercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Representacionlegal")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actividadprincial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ano")
                        .HasColumnType("int");

                    b.Property<string>("contatogestoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("convenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("creacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("creditodisponible")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailgestoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nifrepresentante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombregestoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("nuevacreacion")
                        .HasColumnType("bit");

                    b.Property<string>("sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("seguridad_social")
                        .HasColumnType("int");

                    b.Property<string>("telefonogestoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("venta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Plataforma.Models.EmpresaCurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CursoNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Final")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EmpresaCurso");
                });

            modelBuilder.Entity("Plataforma.Models.Trabajadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoTrabajador")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaTrabajador")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Fundae")
                        .HasColumnType("bit");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("Mestrabajador")
                        .HasColumnType("int");

                    b.Property<string>("SeguridadSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrabajadorAlta")
                        .HasColumnType("bit");

                    b.Property<string>("TrabajadorNif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrabajadorNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trabajadortipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trabajadores");
                });

            modelBuilder.Entity("Plataforma.ViewModels.EmpresasEditViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("EmpresasCurso");
                });
#pragma warning restore 612, 618
        }
    }
}
