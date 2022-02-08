﻿using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts;

public class BaseDbContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<FindeksCreditRate> FindeksCreditRates { get; set; }
    public DbSet<Fuel> Fuel { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<RentalBranch> RentalBranches { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //if (!optionsBuilder.IsConfigured)
        //    base.OnConfiguring(
        //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("RentACarConnectionString")));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(b =>
        {
            b.ToTable("Brands").HasKey(k => k.Id);
            b.Property(p => p.Id).HasColumnName("Id");
            b.Property(p => p.Name).HasColumnName("Name");
            b.HasMany(p => p.Models);
        });

        modelBuilder.Entity<Car>(c =>
        {
            c.ToTable("Cars").HasKey(k => k.Id);
            c.Property(p => p.Id).HasColumnName("Id");
            c.Property(p => p.ColorId).HasColumnName("ColorId");
            c.Property(p => p.ModelId).HasColumnName("ModelId");
            c.Property(c => c.RentalBranchId).HasColumnName("RentalBranchId");
            c.Property(p => p.Kilometer).HasColumnName("Kilometer");
            c.Property(p => p.CarState).HasColumnName("State");
            c.Property(p => p.ModelYear).HasColumnName("ModelYear");
            c.Property(p => p.Plate).HasColumnName("Plate");
            c.HasOne(p => p.Color);
            c.HasOne(p => p.Model);
            c.HasOne(c => c.RentalBranch);
        });

        modelBuilder.Entity<Color>(c =>
        {
            c.ToTable("Colors").HasKey(k => k.Id);
            c.Property(p => p.Id).HasColumnName("Id");
            c.Property(p => p.Name).HasColumnName("Name");
            c.HasMany(p => p.Cars);
        });

        modelBuilder.Entity<CorporateCustomer>(c =>
        {
            c.ToTable("CorporateCustomers").HasKey(c => c.Id);
            c.Property(c => c.Id).HasColumnName("Id");
            c.Property(c => c.CustomerId).HasColumnName("CustomerId");
            c.Property(c => c.CompanyName).HasColumnName("CompanyName");
            c.Property(c => c.TaxNo).HasColumnName("TaxNo");
            c.HasOne(c => c.Customer);
        });

        modelBuilder.Entity<Customer>(c =>
        {
            c.ToTable("Customers").HasKey(c => c.Id);
            c.Property(c => c.Id).HasColumnName("Id");
            c.Property(c => c.Email).HasColumnName("Email");
            c.HasOne(c => c.CorporateCustomer);
            c.HasOne(c => c.FindeksCreditRate);
            c.HasOne(c => c.IndividualCustomer);
            c.HasMany(c => c.Invoices);
            c.HasMany(c => c.Rentals);
        });

        modelBuilder.Entity<FindeksCreditRate>(f =>
        {
            f.ToTable("FindeksCreditRates").HasKey(f => f.Id);
            f.Property(f => f.Id).HasColumnName("Id");
            f.Property(f => f.CustomerId).HasColumnName("CustomerId");
            f.Property(f => f.Score).HasColumnName("Score");
            f.HasOne(f => f.Customer);
        });

        modelBuilder.Entity<Fuel>(f =>
        {
            f.ToTable("Fuels").HasKey(f => f.Id);
            f.Property(f => f.Id).HasColumnName("Id");
            f.Property(f => f.Name).HasColumnName("Name");
            f.HasMany(f => f.Models);
        });

        modelBuilder.Entity<IndividualCustomer>(c =>
        {
            c.ToTable("IndividualCustomers").HasKey(i => i.Id);
            c.Property(i => i.Id).HasColumnName("Id");
            c.Property(i => i.CustomerId).HasColumnName("CustomerId");
            c.Property(i => i.FirstName).HasColumnName("FirstName");
            c.Property(i => i.LastName).HasColumnName("LastName");
            c.Property(i => i.NationalIdentity).HasColumnName("NationalIdentity");
            c.HasOne(i => i.Customer);
        });

        modelBuilder.Entity<Invoice>(i =>
        {
            i.ToTable("Invoices").HasKey(i => i.Id);
            i.Property(i => i.Id).HasColumnName("Id");
            i.Property(i => i.CustomerId).HasColumnName("CustomerId");
            i.Property(i => i.No).HasColumnName("No");
            i.Property(i => i.CreatedDate).HasColumnName("CreatedDate");
            i.Property(i => i.RentalStartDate).HasColumnName("RentalStartDate");
            i.Property(i => i.RentalEndDate).HasColumnName("RentalEndDate");
            i.Property(i => i.TotalRentalDate).HasColumnName("TotalRentalDate");
            i.Property(i => i.RentalPrice).HasColumnName("RentalPrice");
            i.HasOne(i => i.Customer);
        });

        modelBuilder.Entity<Model>(m =>
        {
            m.ToTable("Models").HasKey(k => k.Id);
            m.Property(p => p.Id).HasColumnName("Id");
            m.Property(p => p.BrandId).HasColumnName("BrandId");
            m.Property(p => p.FuelId).HasColumnName("FuelId");
            m.Property(p => p.TransmissionId).HasColumnName("TransmissionId");
            m.Property(p => p.Name).HasColumnName("Name");
            m.Property(p => p.DailyPrice).HasColumnName("DailyPrice");
            m.Property(p => p.ImageUrl).HasColumnName("ImageUrl");
            m.HasOne(p => p.Brand);
            m.HasMany(p => p.Cars);
            m.HasOne(p => p.Fuel);
            m.HasOne(p => p.Transmission);
        });

        modelBuilder.Entity<Rental>(r =>
        {
            r.ToTable("Rentals").HasKey(k => k.Id);
            r.Property(r => r.Id).HasColumnName("Id");
            r.Property(r => r.CustomerId).HasColumnName("CustomerId");
            r.Property(r => r.CarId).HasColumnName("CarId");
            r.Property(r => r.RentStartRentalBranchId).HasColumnName("RentStartRentalBranchId");
            r.Property(r => r.RentEndRentalBranchId).HasColumnName("RentEndRentalBranchId");
            r.Property(r => r.RentStartDate).HasColumnName("RentStartDate");
            r.Property(r => r.RentEndDate).HasColumnName("RentEndDate");
            r.Property(r => r.ReturnDate).HasColumnName("ReturnDate");
            r.Property(r => r.RentStartKilometer).HasColumnName("RentStartKilometer");
            r.Property(r => r.RentEndKilometer).HasColumnName("RentEndKilometer");
            r.HasOne(r => r.Car);
            r.HasOne(r => r.Customer);
            r.HasOne(r => r.RentStartRentalBranch);
            r.HasOne(r => r.RentEndRentalBranch);
        });

        modelBuilder.Entity<RentalBranch>(r =>
        {
            r.ToTable("RentalBranches").HasKey(r => r.Id);
            r.Property(r => r.Id).HasColumnName("Id");
            r.Property(r => r.City).HasColumnName("City");
            r.HasMany(r => r.Cars);
        });

        modelBuilder.Entity<Transmission>(t =>
        {
            t.ToTable("Transmissions").HasKey(k => k.Id);
            t.Property(p => p.Id).HasColumnName("Id");
            t.Property(p => p.Name).HasColumnName("Name");
            t.HasMany(p => p.Models);
        });

        Brand[] brandSeeds = { new(1, "BMW"), new(2, "Mercedes") };
        modelBuilder.Entity<Brand>().HasData(brandSeeds);

        Car[] carSeeds =
        {
            new(1, 1, 1, 1, CarState.Available, 1000, 2018, "07ABC07", 500),
            new(2, 2, 2, 2, CarState.Rented, 1000, 2018, "15ABC15", 1100)
        };
        modelBuilder.Entity<Car>().HasData(carSeeds);

        Color[] colorSeeds = { new(1, "Red"), new(2, "Blue") };
        modelBuilder.Entity<Color>().HasData(colorSeeds);

        CorporateCustomer[] corporateCustomers = { new(1, 2, "Ahmet Çetinkaya", "54154512") };
        modelBuilder.Entity<CorporateCustomer>().HasData(corporateCustomers);

        Customer[] customers = { new(1, "ahmetcetinkaya7@outlook.com"), new(2, "ahmet@cetinkaya.com") };
        modelBuilder.Entity<Customer>().HasData(customers);

        FindeksCreditRate[] findeksCreditRates = { new(1, 1, 1000), new(2, 2, 1900) };
        modelBuilder.Entity<FindeksCreditRate>().HasData(findeksCreditRates);

        Fuel[] fuelSeeds = { new(1, "Diesel"), new(2, "Electric") };
        modelBuilder.Entity<Fuel>().HasData(fuelSeeds);

        IndividualCustomer[] individualCustomers = { new(1, 1, "Ahmet", "Çetinkaya", "123123123123") };
        modelBuilder.Entity<IndividualCustomer>().HasData(individualCustomers);

        Model[] modelSeeds = { new(1, 1, 1, 2, "418i", 1000, ""), new(2, 2, 2, 1, "CLA 180D", 600, "") };
        modelBuilder.Entity<Model>().HasData(modelSeeds);

        Rental[] rentalSeeds =
        {
            new(1, 1, 2, 1, 2, DateTime.Today, DateTime.Today.AddDays(2), null, 1000, 1200),
            new(2, 2, 1, 2, 1, DateTime.Today, DateTime.Today.AddDays(2), null, 1000, 1200)
        };
        modelBuilder.Entity<Rental>().HasData(rentalSeeds);

        RentalBranch[] rentalBranchSeeds = { new(1, City.Ankara), new(2, City.Antalya) };
        modelBuilder.Entity<RentalBranch>().HasData(rentalBranchSeeds);

        Invoice[] invoiceSeeds =
        {
            new(1, 1, "123123", DateTime.Today, DateTime.Today, DateTime.Today.AddDays(2), 2, 1000),
            new(2, 1, "123123", DateTime.Today, DateTime.Today, DateTime.Today.AddDays(2), 2, 2000)
        };
        modelBuilder.Entity<Invoice>().HasData(invoiceSeeds);

        Transmission[] transmissionsSeeds = { new(1, "Manuel"), new(2, "Automatic") };
        modelBuilder.Entity<Transmission>().HasData(transmissionsSeeds);
    }
}