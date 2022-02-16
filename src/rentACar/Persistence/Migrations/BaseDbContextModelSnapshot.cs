﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("DailyPrice");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DailyPrice = 200m,
                            Name = "Baby Seat"
                        },
                        new
                        {
                            Id = 2,
                            DailyPrice = 300m,
                            Name = "Scooter"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mercedes"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarState")
                        .HasColumnType("int")
                        .HasColumnName("State");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("ColorId");

                    b.Property<int>("Kilometer")
                        .HasColumnType("int")
                        .HasColumnName("Kilometer");

                    b.Property<short>("MinFindeksCreditRate")
                        .HasColumnType("smallint");

                    b.Property<int>("ModelId")
                        .HasColumnType("int")
                        .HasColumnName("ModelId");

                    b.Property<short>("ModelYear")
                        .HasColumnType("smallint")
                        .HasColumnName("ModelYear");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Plate");

                    b.Property<int>("RentalBranchId")
                        .HasColumnType("int")
                        .HasColumnName("RentalBranchId");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.HasIndex("RentalBranchId");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarState = 1,
                            ColorId = 1,
                            Kilometer = 1000,
                            MinFindeksCreditRate = (short)500,
                            ModelId = 1,
                            ModelYear = (short)2018,
                            Plate = "07ABC07",
                            RentalBranchId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarState = 2,
                            ColorId = 2,
                            Kilometer = 1000,
                            MinFindeksCreditRate = (short)1100,
                            ModelId = 2,
                            ModelYear = (short)2018,
                            Plate = "15ABC15",
                            RentalBranchId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.CarDamage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<string>("DamageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFixed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsFixed");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarDamages", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blue"
                        });
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("TaxNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TaxNo");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CorporateCustomers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Ahmet Çetinkaya",
                            CustomerId = 2,
                            TaxNo = "54154512"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FindeksCreditRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<short>("Score")
                        .HasColumnType("smallint")
                        .HasColumnName("Score");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("FindeksCreditRates", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Score = (short)1000
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Score = (short)1900
                        });
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Fuels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electric"
                        });
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalIdentity");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("IndividualCustomers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            FirstName = "Ahmet",
                            LastName = "Çetinkaya",
                            NationalIdentity = "123123123123"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 2, 16, 11, 37, 51, 868, DateTimeKind.Local).AddTicks(7818))
                        .HasColumnName("CreatedDate");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("No");

                    b.Property<DateTime>("RentalEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentalEndDate");

                    b.Property<decimal>("RentalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("RentalPrice");

                    b.Property<DateTime>("RentalStartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentalStartDate");

                    b.Property<short>("TotalRentalDate")
                        .HasColumnType("smallint")
                        .HasColumnName("TotalRentalDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CustomerId = 1,
                            No = "123123",
                            RentalEndDate = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            RentalPrice = 1000m,
                            RentalStartDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalRentalDate = (short)2
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CustomerId = 1,
                            No = "123123",
                            RentalEndDate = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            RentalPrice = 2000m,
                            RentalStartDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalRentalDate = (short)2
                        });
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("BrandId");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("DailyPrice");

                    b.Property<int>("FuelId")
                        .HasColumnType("int")
                        .HasColumnName("FuelId");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int")
                        .HasColumnName("TransmissionId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Models", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            DailyPrice = 1000m,
                            FuelId = 1,
                            ImageUrl = "",
                            Name = "418i",
                            TransmissionId = 2
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            DailyPrice = 600m,
                            FuelId = 2,
                            ImageUrl = "",
                            Name = "CLA 180D",
                            TransmissionId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime>("RentEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentEndDate");

                    b.Property<int?>("RentEndKilometer")
                        .HasColumnType("int")
                        .HasColumnName("RentEndKilometer");

                    b.Property<int?>("RentEndRentalBranchId")
                        .HasColumnType("int")
                        .HasColumnName("RentEndRentalBranchId");

                    b.Property<DateTime>("RentStartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentStartDate");

                    b.Property<int>("RentStartKilometer")
                        .HasColumnType("int")
                        .HasColumnName("RentStartKilometer");

                    b.Property<int>("RentStartRentalBranchId")
                        .HasColumnType("int")
                        .HasColumnName("RentStartRentalBranchId");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReturnDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentEndRentalBranchId");

                    b.HasIndex("RentStartRentalBranchId");

                    b.ToTable("Rentals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 2,
                            CustomerId = 1,
                            RentEndDate = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            RentEndKilometer = 1200,
                            RentEndRentalBranchId = 2,
                            RentStartDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            RentStartKilometer = 1000,
                            RentStartRentalBranchId = 1
                        },
                        new
                        {
                            Id = 2,
                            CarId = 1,
                            CustomerId = 2,
                            RentEndDate = new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            RentEndKilometer = 1200,
                            RentEndRentalBranchId = 1,
                            RentStartDate = new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            RentStartKilometer = 1000,
                            RentStartRentalBranchId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.RentalBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("City")
                        .HasColumnType("int")
                        .HasColumnName("City");

                    b.HasKey("Id");

                    b.ToTable("RentalBranches", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = 1
                        },
                        new
                        {
                            Id = 2,
                            City = 7
                        });
                });

            modelBuilder.Entity("Domain.Entities.RentalsAdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdditionalServiceId")
                        .HasColumnType("int")
                        .HasColumnName("AdditionalServiceId");

                    b.Property<int>("RentalId")
                        .HasColumnType("int")
                        .HasColumnName("RentalId");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalServiceId");

                    b.HasIndex("RentalId");

                    b.ToTable("RentalsAdditionalServices", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Transmissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manuel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Automatic"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Security.Entities.OperationClaim", "OperationClaim")
                        .WithMany()
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.HasOne("Domain.Entities.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RentalBranch", "RentalBranch")
                        .WithMany("Cars")
                        .HasForeignKey("RentalBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Model");

                    b.Navigation("RentalBranch");
                });

            modelBuilder.Entity("Domain.Entities.CarDamage", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany("CarDamages")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("CorporateCustomer")
                        .HasForeignKey("Domain.Entities.CorporateCustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.FindeksCreditRate", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("FindeksCreditRate")
                        .HasForeignKey("Domain.Entities.FindeksCreditRate", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("IndividualCustomer")
                        .HasForeignKey("Domain.Entities.IndividualCustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.HasOne("Domain.Entities.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Fuel", "Fuel")
                        .WithMany("Models")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Transmission", "Transmission")
                        .WithMany("Models")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Fuel");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RentalBranch", "RentEndRentalBranch")
                        .WithMany()
                        .HasForeignKey("RentEndRentalBranchId");

                    b.HasOne("Domain.Entities.RentalBranch", "RentStartRentalBranch")
                        .WithMany()
                        .HasForeignKey("RentStartRentalBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("RentEndRentalBranch");

                    b.Navigation("RentStartRentalBranch");
                });

            modelBuilder.Entity("Domain.Entities.RentalsAdditionalService", b =>
                {
                    b.HasOne("Domain.Entities.AdditionalService", "AdditionalService")
                        .WithMany()
                        .HasForeignKey("AdditionalServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rental", "Rental")
                        .WithMany("RentalsAdditionalServices")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdditionalService");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Navigation("CarDamages");
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("CorporateCustomer");

                    b.Navigation("FindeksCreditRate");

                    b.Navigation("IndividualCustomer");

                    b.Navigation("Invoices");

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Navigation("RentalsAdditionalServices");
                });

            modelBuilder.Entity("Domain.Entities.RentalBranch", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
