﻿// <auto-generated />
using System;
using GBO.MyAiport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBO.MyAiport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200224091420_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GBO.MyAiport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeIata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Prioritaire")
                        .HasColumnType("bit");

                    b.Property<string>("Ssur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VolID")
                        .HasColumnType("int");

                    b.HasKey("BagageID");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("GBO.MyAiport.EF.Vol", b =>
                {
                    b.Property<int>("VolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Des")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dhc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Pax")
                        .HasColumnType("smallint");

                    b.Property<string>("Pkg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolID");

                    b.ToTable("Vols");
                });
#pragma warning restore 612, 618
        }
    }
}
