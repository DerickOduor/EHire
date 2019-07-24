using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EHire.Core.Migrations
{
    public partial class migrate_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Approved = table.Column<bool>(nullable: false),
                    Locked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelType_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GearTransmission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Transmission = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearTransmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GearTransmission_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HiringActivity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Activity = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiringActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HiringActivity_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Maintenance = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceType_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PasswordDictionary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedBy = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordDictionary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasswordDictionary_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    BillNo = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOptions_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReasonType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReasonType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReasonType_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    AdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTypes_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleType_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reason",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ReasonTypeId = table.Column<int>(nullable: false),
                    ReasonDescription = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reason", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reason_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reason_ReasonType_ReasonTypeId",
                        column: x => x.ReasonTypeId,
                        principalTable: "ReasonType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Town_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Town_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    ActionTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UsertypeId = table.Column<int>(nullable: false),
                    UserTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audit_UserTypes_UserTypesId",
                        column: x => x.UserTypesId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EWallet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    UserTypeId = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    UserTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EWallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EWallet_UserTypes_UserTypesId",
                        column: x => x.UserTypesId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    From = table.Column<int>(nullable: false),
                    UsertypeFrom = table.Column<int>(nullable: false),
                    To = table.Column<int>(nullable: false),
                    UsertypeTo = table.Column<int>(nullable: false),
                    DateTimeSent = table.Column<DateTime>(nullable: false),
                    IsSent = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    UserTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mail_UserTypes_UserTypesId",
                        column: x => x.UserTypesId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passwords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsertypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    UserTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passwords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passwords_UserTypes_UserTypesId",
                        column: x => x.UserTypesId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrand",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    VehicleTypeId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBrand_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleBrand_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    IsLoggedIn = table.Column<bool>(nullable: false),
                    PasswordReset = table.Column<bool>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    ReasonId = table.Column<int>(nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    LogoutTime = table.Column<DateTime>(nullable: false),
                    SecurityCode = table.Column<string>(nullable: true),
                    SecurityCodeExpiry = table.Column<DateTime>(nullable: false),
                    UserTypesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Login_Reason_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "Reason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Login_UserTypes_UserTypesId",
                        column: x => x.UserTypesId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    PostalAddress = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    TownId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institution_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Institution_Town_TownId",
                        column: x => x.TownId,
                        principalTable: "Town",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    VehicleBrandId = table.Column<int>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModel_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleBrand_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    InstitutionId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OtherName = table.Column<string>(nullable: true),
                    DatAdded = table.Column<DateTime>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionUser_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    FuelCapacity = table.Column<double>(nullable: false),
                    FuelConsumption = table.Column<double>(nullable: false),
                    FuelTypeId = table.Column<int>(nullable: false),
                    InstitutionId = table.Column<int>(nullable: false),
                    GearTansmissionTypeId = table.Column<int>(nullable: false),
                    SeatingCapacity = table.Column<int>(nullable: false),
                    VehicleModelId = table.Column<int>(nullable: false),
                    AdminId = table.Column<int>(nullable: true),
                    VehicleBrandId = table.Column<int>(nullable: true),
                    VehicleTypeId = table.Column<int>(nullable: true),
                    GearTransmissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_FuelType_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_GearTransmission_GearTransmissionId",
                        column: x => x.GearTransmissionId,
                        principalTable: "GearTransmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_Institution_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBrand_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModel_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMaitenance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaintenanceTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VehicleId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateCompleted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMaitenance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMaitenance_MaintenanceType_MaintenanceTypeId",
                        column: x => x.MaintenanceTypeId,
                        principalTable: "MaintenanceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleMaitenance_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HiredVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VehicleId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    HireRequestId = table.Column<int>(nullable: false),
                    DateHired = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiredVehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HiredVehicle_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HiredVehicle_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HireRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    From = table.Column<DateTime>(nullable: false),
                    To = table.Column<DateTime>(nullable: false),
                    ExtendHirePeriodTo = table.Column<DateTime>(nullable: false),
                    HireActivityId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    TownId = table.Column<int>(nullable: false),
                    Approved = table.Column<bool>(nullable: false),
                    HiringActivityId = table.Column<int>(nullable: true),
                    HiredVehicleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HireRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HireRequest_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HireRequest_HiredVehicle_HiredVehicleId",
                        column: x => x.HiredVehicleId,
                        principalTable: "HiredVehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HireRequest_HiringActivity_HiringActivityId",
                        column: x => x.HiringActivityId,
                        principalTable: "HiringActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HireRequest_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HireRequest_Town_TownId",
                        column: x => x.TownId,
                        principalTable: "Town",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HireRequest_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HiredVehicleSignOff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HireRequestId = table.Column<int>(nullable: false),
                    CustomerSignOff = table.Column<bool>(nullable: false),
                    InstitutionSignOff = table.Column<bool>(nullable: false),
                    VehicleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiredVehicleSignOff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HiredVehicleSignOff_HireRequest_HireRequestId",
                        column: x => x.HireRequestId,
                        principalTable: "HireRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HiredVehicleSignOff_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HireRequestId = table.Column<int>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                    AmountPaid = table.Column<decimal>(nullable: false),
                    DatePaid = table.Column<DateTime>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_HireRequest_HireRequestId",
                        column: x => x.HireRequestId,
                        principalTable: "HireRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit_UserTypesId",
                table: "Audit",
                column: "UserTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_EWallet_UserTypesId",
                table: "EWallet",
                column: "UserTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelType_AdminId",
                table: "FuelType",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_GearTransmission_AdminId",
                table: "GearTransmission",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_HiredVehicle_CustomerId",
                table: "HiredVehicle",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HiredVehicle_HireRequestId",
                table: "HiredVehicle",
                column: "HireRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_HiredVehicle_VehicleId",
                table: "HiredVehicle",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HiredVehicleSignOff_HireRequestId",
                table: "HiredVehicleSignOff",
                column: "HireRequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HiredVehicleSignOff_VehicleId",
                table: "HiredVehicleSignOff",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_CustomerId",
                table: "HireRequest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_HiredVehicleId",
                table: "HireRequest",
                column: "HiredVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_HiringActivityId",
                table: "HireRequest",
                column: "HiringActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_RegionId",
                table: "HireRequest",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_TownId",
                table: "HireRequest",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_HireRequest_VehicleId",
                table: "HireRequest",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HiringActivity_AdminId",
                table: "HiringActivity",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_RegionId",
                table: "Institution",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_TownId",
                table: "Institution",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionUser_InstitutionId",
                table: "InstitutionUser",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Login_ReasonId",
                table: "Login",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Login_UserTypesId",
                table: "Login",
                column: "UserTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Mail_UserTypesId",
                table: "Mail",
                column: "UserTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceType_AdminId",
                table: "MaintenanceType",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordDictionary_AdminId",
                table: "PasswordDictionary",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Passwords_UserTypesId",
                table: "Passwords",
                column: "UserTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_HireRequestId",
                table: "Payment",
                column: "HireRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOptions_AdminId",
                table: "PaymentOptions",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Reason_AdminId",
                table: "Reason",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Reason_ReasonTypeId",
                table: "Reason",
                column: "ReasonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReasonType_AdminId",
                table: "ReasonType",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_AdminId",
                table: "Region",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_AdminId",
                table: "Role",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Town_AdminId",
                table: "Town",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Town_RegionId",
                table: "Town",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_AdminId",
                table: "UserTypes",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_AdminId",
                table: "Vehicle",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_FuelTypeId",
                table: "Vehicle",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_GearTransmissionId",
                table: "Vehicle",
                column: "GearTransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_InstitutionId",
                table: "Vehicle",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBrandId",
                table: "Vehicle",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleModelId",
                table: "Vehicle",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrand_AdminId",
                table: "VehicleBrand",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBrand_VehicleTypeId",
                table: "VehicleBrand",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaitenance_MaintenanceTypeId",
                table: "VehicleMaitenance",
                column: "MaintenanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaitenance_VehicleId",
                table: "VehicleMaitenance",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_AdminId",
                table: "VehicleModel",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleBrandId",
                table: "VehicleModel",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_AdminId",
                table: "VehicleType",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_HiredVehicle_HireRequest_HireRequestId",
                table: "HiredVehicle",
                column: "HireRequestId",
                principalTable: "HireRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuelType_Admin_AdminId",
                table: "FuelType");

            migrationBuilder.DropForeignKey(
                name: "FK_GearTransmission_Admin_AdminId",
                table: "GearTransmission");

            migrationBuilder.DropForeignKey(
                name: "FK_HiringActivity_Admin_AdminId",
                table: "HiringActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_Region_Admin_AdminId",
                table: "Region");

            migrationBuilder.DropForeignKey(
                name: "FK_Town_Admin_AdminId",
                table: "Town");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Admin_AdminId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBrand_Admin_AdminId",
                table: "VehicleBrand");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModel_Admin_AdminId",
                table: "VehicleModel");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_Admin_AdminId",
                table: "VehicleType");

            migrationBuilder.DropForeignKey(
                name: "FK_HiredVehicle_Customer_CustomerId",
                table: "HiredVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_HireRequest_Customer_CustomerId",
                table: "HireRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_HiredVehicle_HireRequest_HireRequestId",
                table: "HiredVehicle");

            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "EWallet");

            migrationBuilder.DropTable(
                name: "HiredVehicleSignOff");

            migrationBuilder.DropTable(
                name: "InstitutionUser");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.DropTable(
                name: "PasswordDictionary");

            migrationBuilder.DropTable(
                name: "Passwords");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "VehicleMaitenance");

            migrationBuilder.DropTable(
                name: "Reason");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "MaintenanceType");

            migrationBuilder.DropTable(
                name: "ReasonType");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "HireRequest");

            migrationBuilder.DropTable(
                name: "HiredVehicle");

            migrationBuilder.DropTable(
                name: "HiringActivity");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "FuelType");

            migrationBuilder.DropTable(
                name: "GearTransmission");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "VehicleModel");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "VehicleBrand");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
