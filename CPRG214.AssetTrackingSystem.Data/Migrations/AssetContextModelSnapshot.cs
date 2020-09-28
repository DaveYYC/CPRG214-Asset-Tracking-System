﻿// <auto-generated />
using CPRG214.AssetTrackingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRG214.AssetTrackingSystem.Data.Migrations
{
    [DbContext(typeof(AssetContext))]
    partial class AssetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRG214.AssetTrackingSystem.Domain.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetTypeId = 1,
                            Description = "Dell Inspiron Desktop Computer",
                            Manufacturer = "Dell",
                            Model = "Inspiron",
                            SerialNumber = "1001",
                            TagNumber = "1"
                        },
                        new
                        {
                            Id = 2,
                            AssetTypeId = 1,
                            Description = "HP Pavillion Desktop Computer",
                            Manufacturer = "HP",
                            Model = "Pavillion",
                            SerialNumber = "1002",
                            TagNumber = "2"
                        },
                        new
                        {
                            Id = 3,
                            AssetTypeId = 1,
                            Description = "Acer Aspire Desktop Computer",
                            Manufacturer = "Acer",
                            Model = "Aspire",
                            SerialNumber = "1003",
                            TagNumber = "3"
                        },
                        new
                        {
                            Id = 4,
                            AssetTypeId = 2,
                            Description = "Acer Monitor",
                            Manufacturer = "Acer",
                            Model = "SB220Q",
                            SerialNumber = "1004",
                            TagNumber = "4"
                        },
                        new
                        {
                            Id = 5,
                            AssetTypeId = 2,
                            Description = "LG Monitor",
                            Manufacturer = "LG",
                            Model = "27mp57vq",
                            SerialNumber = "1005",
                            TagNumber = "5"
                        },
                        new
                        {
                            Id = 6,
                            AssetTypeId = 2,
                            Description = "HP Monitor",
                            Manufacturer = "HP",
                            Model = "19-2113w",
                            SerialNumber = "1006",
                            TagNumber = "6"
                        },
                        new
                        {
                            Id = 7,
                            AssetTypeId = 3,
                            Description = "Avaya Phone",
                            Manufacturer = "Avaya",
                            Model = "1408",
                            SerialNumber = "1007",
                            TagNumber = "7"
                        },
                        new
                        {
                            Id = 8,
                            AssetTypeId = 3,
                            Description = "Polycom Phone",
                            Manufacturer = "Polycom",
                            Model = "vx411",
                            SerialNumber = "1008",
                            TagNumber = "8"
                        },
                        new
                        {
                            Id = 9,
                            AssetTypeId = 3,
                            Description = "Cisco Phone",
                            Manufacturer = "Cisco",
                            Model = "78741",
                            SerialNumber = "1009",
                            TagNumber = "9"
                        });
                });

            modelBuilder.Entity("CPRG214.AssetTrackingSystem.Domain.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desktop Computer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phone"
                        });
                });

            modelBuilder.Entity("CPRG214.AssetTrackingSystem.Domain.Asset", b =>
                {
                    b.HasOne("CPRG214.AssetTrackingSystem.Domain.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
