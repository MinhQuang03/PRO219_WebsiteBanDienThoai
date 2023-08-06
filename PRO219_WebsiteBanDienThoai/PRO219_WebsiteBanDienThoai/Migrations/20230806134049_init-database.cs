﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRO219_WebsiteBanDienThoai.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Battery",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.IdAccount);
                });

            migrationBuilder.CreateTable(
                name: "ChargingportType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChargingportType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChipCPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipCPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChipGPUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipGPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReducedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TimeForm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CvvCode = table.Column<int>(type: "int", nullable: true),
                    QrCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductionCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirement = table.Column<int>(type: "int", nullable: true),
                    DateRank = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Policies = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sim",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Accounts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdProductionCompany = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_ProductionCompany_IdProductionCompany",
                        column: x => x.IdProductionCompany,
                        principalTable: "ProductionCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Usurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdPayment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Bill_IdBill",
                        column: x => x.IdBill,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Payments_IdPayment",
                        column: x => x.IdPayment,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneDetailds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiscount = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRam = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOperatingSystem = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBattery = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSim = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChipCPU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChipGPU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChargingport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCamera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolution = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneDetailds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Battery_IdBattery",
                        column: x => x.IdBattery,
                        principalTable: "Battery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChargingportType_IdChargingport",
                        column: x => x.IdChargingport,
                        principalTable: "ChargingportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChipCPUs_IdChipGPU",
                        column: x => x.IdChipGPU,
                        principalTable: "ChipCPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_ChipGPUs_IdChipGPU",
                        column: x => x.IdChipGPU,
                        principalTable: "ChipGPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Colors_IdColor",
                        column: x => x.IdColor,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Discount_IdDiscount",
                        column: x => x.IdDiscount,
                        principalTable: "Discount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Material_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_OperatingSystem_IdOperatingSystem",
                        column: x => x.IdOperatingSystem,
                        principalTable: "OperatingSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Phones_IdPhone",
                        column: x => x.IdPhone,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Ram_IdRam",
                        column: x => x.IdRam,
                        principalTable: "Ram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Rom_IdRom",
                        column: x => x.IdRom,
                        principalTable: "Rom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneDetailds_Sim_IdSim",
                        column: x => x.IdSim,
                        principalTable: "Sim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warranty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhone = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warranty_Phones_IdPhone",
                        column: x => x.IdPhone,
                        principalTable: "Phones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDiscount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bill_IdBill",
                        column: x => x.IdBill,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Discount_IdDiscount",
                        column: x => x.IdDiscount,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartsDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartsDetails_Carts_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Carts",
                        principalColumn: "IdAccount",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartsDetails_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imei",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameImei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imei", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imei_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ListImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdColor = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListImage_PhoneDetailds_IdPhoneDetaild",
                        column: x => x.IdPhoneDetaild,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPhoneDetaild = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneDetaildsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Accounts_AccountsId",
                        column: x => x.AccountsId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_PhoneDetailds_PhoneDetaildsId",
                        column: x => x.PhoneDetaildsId,
                        principalTable: "PhoneDetailds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarrantyCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBillDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarrantyCards_BillDetails_IdBillDetail",
                        column: x => x.IdBillDetail,
                        principalTable: "BillDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_IdAccount",
                table: "Address",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_IdAccount",
                table: "Bill",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdBill",
                table: "BillDetails",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdDiscount",
                table: "BillDetails",
                column: "IdDiscount");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdPhoneDetaild",
                table: "BillDetails",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDetails_IdAccount",
                table: "CartsDetails",
                column: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDetails_IdPhoneDetaild",
                table: "CartsDetails",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_Imei_IdPhoneDetaild",
                table: "Imei",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_ListImage_IdPhoneDetaild",
                table: "ListImage",
                column: "IdPhoneDetaild");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdBattery",
                table: "PhoneDetailds",
                column: "IdBattery");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdChargingport",
                table: "PhoneDetailds",
                column: "IdChargingport");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdChipGPU",
                table: "PhoneDetailds",
                column: "IdChipGPU");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdColor",
                table: "PhoneDetailds",
                column: "IdColor");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdDiscount",
                table: "PhoneDetailds",
                column: "IdDiscount");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdMaterial",
                table: "PhoneDetailds",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdOperatingSystem",
                table: "PhoneDetailds",
                column: "IdOperatingSystem");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdPhone",
                table: "PhoneDetailds",
                column: "IdPhone");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdRam",
                table: "PhoneDetailds",
                column: "IdRam");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdRom",
                table: "PhoneDetailds",
                column: "IdRom");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneDetailds_IdSim",
                table: "PhoneDetailds",
                column: "IdSim");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_IdProductionCompany",
                table: "Phones",
                column: "IdProductionCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AccountsId",
                table: "Reviews",
                column: "AccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PhoneDetaildsId",
                table: "Reviews",
                column: "PhoneDetaildsId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_IdRole",
                table: "Staff",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdBill",
                table: "Transactions",
                column: "IdBill");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdPayment",
                table: "Transactions",
                column: "IdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_Warranty_IdPhone",
                table: "Warranty",
                column: "IdPhone");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyCards_IdBillDetail",
                table: "WarrantyCards",
                column: "IdBillDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "CartsDetails");

            migrationBuilder.DropTable(
                name: "Imei");

            migrationBuilder.DropTable(
                name: "ListImage");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Warranty");

            migrationBuilder.DropTable(
                name: "WarrantyCards");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "PhoneDetailds");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Battery");

            migrationBuilder.DropTable(
                name: "ChargingportType");

            migrationBuilder.DropTable(
                name: "ChipCPUs");

            migrationBuilder.DropTable(
                name: "ChipGPUs");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "OperatingSystem");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "Rom");

            migrationBuilder.DropTable(
                name: "Sim");

            migrationBuilder.DropTable(
                name: "ProductionCompany");
        }
    }
}
