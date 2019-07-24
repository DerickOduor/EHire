using EHire.Core.Domain.Entities;
//using EHire.Core.Domain.EntityMaps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EHire.Core.Domain.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        DbSet<Role> Roles;
        DbSet<Region> Regions;
        DbSet<ReasonType> ReasonTypes;
        DbSet<Reason>Reasons;
        DbSet<UserTypes> UserTypes;
        DbSet<Customer>Customers;
        DbSet<EWallet> EWallets;
        DbSet<Admin> Admins;
        DbSet<FuelType> FuelTypes;
        DbSet<PasswordDictionary> PasswordDictionaries;
        DbSet<MaintenanceType> MaintenanceTypes;
        DbSet<Institution> Institutions;
        DbSet<InstitutionUser> InstitutionUsers;
        DbSet<GearTransmission> GearTransmissions;
        DbSet<VehicleType> VehicleTypes;
        DbSet<VehicleBrand> VehicleBrands;
        DbSet<VehicleModel> VehicleModels;
        DbSet<Vehicle> Vehicles;
        DbSet<Mail> Mails;
        DbSet<Audit> Audits;
        DbSet<Payment> Payments;
        DbSet<Passwords> Passwords;
        DbSet<Login> Logins;
        DbSet<HireRequest> HireRequests;
        DbSet<HiredVehicle> HiredVehicles;
        DbSet<HiredVehicleSignOff> HiredVehicleSignOffs;
        DbSet<Town> Towns;
        DbSet<PaymentOptions> PaymentOptions;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>();

            modelBuilder.Entity<Institution>()
            .HasOne(i => i.Town)
            .WithMany(c => c.Institutions)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HireRequest>()
            .HasOne(i => i.Town)
            .WithMany(c => c.HireRequest)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HireRequest>()
            .HasOne(i => i.Vehicle)
            .WithMany(c => c.HireRequests)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HiredVehicle>()
            .HasOne(i => i.HireRequest)
            .WithMany(c => c.HiredVehicles)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Institution>()
            //.HasOptional<Standard>(s => s.Standard)
            //.WithMany()
            //.WillCascadeOnDelete(false);
            //modelBuilder.Entity<Region>();

            //new RoleMap(modelBuilder.Entity<Role>());
            //new RegionMap(modelBuilder.Entity<Region>());
            //new ReasonTypeMap(modelBuilder.Entity<ReasonType>());
            //new ReasonMap(modelBuilder.Entity<Reason>());
            //new UserTypeMap(modelBuilder.Entity<UserTypes>());
            ////new CustomerMap(modelBuilder.Entity<Customer>());
            ////new EWalletMap(modelBuilder.Entity<EWallet>());
            ////new AdminMap(modelBuilder.Entity<Admin>());
            //new FuelTypeMap(modelBuilder.Entity<FuelType>());
            //new PasswordDictionaryMap(modelBuilder.Entity<PasswordDictionary>());
            //new MaintenanceTypeMap(modelBuilder.Entity<MaintenanceType>());
            //new MaintenanceTypeMap(modelBuilder.Entity<MaintenanceType>());
            ////new InstitutionMap(modelBuilder.Entity<Institution>());
            ////new InstitutionUserMap(modelBuilder.Entity<InstitutionUser>());
            //new GearTransmissionMap(modelBuilder.Entity<GearTransmission>());
            //new AdminMap(modelBuilder.Entity<Admin>());
            //new VehicleTypeMap(modelBuilder.Entity<VehicleType>());
            //new VehicleBrandMap(modelBuilder.Entity<VehicleBrand>());
            //new VehicleModelMap(modelBuilder.Entity<VehicleModel>());
            //new VehicleMap(modelBuilder.Entity<Vehicle>());
            //new MailMap(modelBuilder.Entity<Mail>());
            //new AuditMap(modelBuilder.Entity<Audit>());
            //new PaymentMap(modelBuilder.Entity<Payment>());
            //new PasswordsMap(modelBuilder.Entity<Passwords>());
            //new LoginMap(modelBuilder.Entity<Login>());
            //new EWalletMap(modelBuilder.Entity<EWallet>());
            //new HireRequestMap(modelBuilder.Entity<HireRequest>());
            //new HiredVehicleMap(modelBuilder.Entity<HiredVehicle>());
            //new HiredVehicleSignOffMap(modelBuilder.Entity<HiredVehicleSignOff>());
            //
            //new TownMap(modelBuilder.Entity<Town>());
            //new AdminMap(modelBuilder.Entity<Admin>());
            //new VehicleTypeMap(modelBuilder.Entity<VehicleType>());
            //new VehicleModelMap(modelBuilder.Entity<VehicleModel>());
            //new VehicleBrandMap(modelBuilder.Entity<VehicleBrand>());
            //new MaintenanceTypeMap(modelBuilder.Entity<MaintenanceType>());
            //new FuelTypeMap(modelBuilder.Entity<FuelType>());
            //new PaymentOptionsMap(modelBuilder.Entity<PaymentOptions>());
            //new MaintenanceTypeMap(modelBuilder.Entity<MaintenanceType>());
            //new PasswordDictionaryMap(modelBuilder.Entity<PasswordDictionary>());
            //new ReasonTypeMap(modelBuilder.Entity<ReasonType>());
            //new UserTypeMap(modelBuilder.Entity<UserTypes>());
            //new ReasonMap(modelBuilder.Entity<Reason>());
            //new PasswordsMap(modelBuilder.Entity<Passwords>());
            //new InstitutionMap(modelBuilder.Entity<Institution>());
            //new InstitutionUserMap(modelBuilder.Entity<InstitutionUser>());
            //new HireRequestMap(modelBuilder.Entity<HireRequest>());
            //new HiredVehicleSignOffMap(modelBuilder.Entity<HiredVehicleSignOff>());
            //new HiredVehicleMap(modelBuilder.Entity<HiredVehicle>());
            //new GearTransmissionMap(modelBuilder.Entity<GearTransmission>());
            //new MailMap(modelBuilder.Entity<Mail>());
            //new AuditMap(modelBuilder.Entity<Audit>());
            //new CustomerMap(modelBuilder.Entity<Customer>());
            //new EWalletMap(modelBuilder.Entity<EWallet>());
            //new VehicleMaitenanceMap(modelBuilder.Entity<VehicleMaitenance>());
            //new VehicleMap(modelBuilder.Entity<Vehicle>());
            //new LoginMap(modelBuilder.Entity<Login>());
            //new PaymentMap(modelBuilder.Entity<Payment>());
        }
    }
}