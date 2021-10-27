﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OcrRndProject.DAL;

namespace OcrRndProject.DAL.Migrations
{
    [DbContext(typeof(OCrRndProjectDbContext))]
    [Migration("20211027103548_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OcrRndProject.DAL.Model.Entity.NidAddressInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NidAddressInfo");
                });

            modelBuilder.Entity("OcrRndProject.DAL.Model.Entity.NidInformations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NidAddressInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NidAddressInfoId");

                    b.ToTable("NidInformations");
                });

            modelBuilder.Entity("OcrRndProject.DAL.Model.Entity.NidInformations", b =>
                {
                    b.HasOne("OcrRndProject.DAL.Model.Entity.NidAddressInfo", null)
                        .WithMany("NidInformations")
                        .HasForeignKey("NidAddressInfoId");
                });

            modelBuilder.Entity("OcrRndProject.DAL.Model.Entity.NidAddressInfo", b =>
                {
                    b.Navigation("NidInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
