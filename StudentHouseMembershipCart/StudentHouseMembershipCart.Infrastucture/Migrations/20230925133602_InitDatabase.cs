using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Infrastucture.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeedBackName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedBackDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedBackImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedBackRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    staffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_FeedBack_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "FeedBack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weekNumberBooking = table.Column<int>(type: "int", nullable: false),
                    numberOfPerWeekDoPackage = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRe_Newed = table.Column<bool>(type: "bit", nullable: false),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionProcess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportWork_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartment_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageService",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageService_Package_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Contract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPay = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Apartment_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ContractName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Package_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendReport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDoPackage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendReport_BookingDetail_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendReport_FeedBack_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "FeedBack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AttendReport_ReportWork_ReportWorkId",
                        column: x => x.ReportWorkId,
                        principalTable: "ReportWork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetailStaff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetailStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetailStaff_BookingDetail_BookingDetailId",
                        column: x => x.BookingDetailId,
                        principalTable: "BookingDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingDetailStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "FeedBack",
                columns: new[] { "Id", "AttendReportId", "CreateBy", "Created", "FeedBackDescription", "FeedBackImage", "FeedBackName", "FeedBackRating", "IsDelete", "LastModified", "LastModifiedBy", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0073ae3e-6374-4c66-9a7d-f2e1d411d3b2"), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9529), "", "", "hihi", "", false, null, null, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5e6e3ac9-d41c-46f1-a4a4-e91ecec521fd"), new Guid("00000000-0000-0000-0000-000000000000"), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9549), "", "", "hahah", "", false, null, null, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "RoleName" },
                values: new object[,]
                {
                    { new Guid("87791989-38cc-4a41-9526-2052bc34258e"), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9740), "Description", false, null, null, "Student" },
                    { new Guid("b5196cae-9e27-434e-bfd3-2c9db9205eef"), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9747), "Description", false, null, null, "Admin" },
                    { new Guid("b778f89a-a306-42a4-84fd-1be8f795dc1a"), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9735), "Description", false, null, null, "Staff" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "Birthday", "CreateBy", "Created", "Email", "FeedbackId", "IsDelete", "LastModified", "LastModifiedBy", "Password", "Phone", "RoleId", "StudentName" },
                values: new object[] { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "hcm", new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9948), null, new DateTime(2023, 9, 25, 20, 36, 2, 12, DateTimeKind.Local).AddTicks(9945), "Manager@gmail.com", new Guid("0073ae3e-6374-4c66-9a7d-f2e1d411d3b2"), false, null, null, "MANAGER", "03030303", new Guid("87791989-38cc-4a41-9526-2052bc34258e"), "Manager" });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_RoleId",
                table: "Admin",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_RegionId",
                table: "Apartment",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_StudentId",
                table: "Apartment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendReport_BookingDetailId",
                table: "AttendReport",
                column: "BookingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendReport_FeedbackId",
                table: "AttendReport",
                column: "FeedbackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendReport_ReportWorkId",
                table: "AttendReport",
                column: "ReportWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ApartmentId",
                table: "Booking",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_BookingId",
                table: "BookingDetail",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_PackageId",
                table: "BookingDetail",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetailStaff_BookingDetailId",
                table: "BookingDetailStaff",
                column: "BookingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetailStaff_StaffId",
                table: "BookingDetailStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_AdminId",
                table: "Package",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageService_PackageId",
                table: "PackageService",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageService_ServiceId",
                table: "PackageService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_BookingId",
                table: "PaymentMethod",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportWork_StaffId",
                table: "ReportWork",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CategoryId",
                table: "Service",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleId",
                table: "Staff",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FeedbackId",
                table: "Student",
                column: "FeedbackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_RoleId",
                table: "Student",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendReport");

            migrationBuilder.DropTable(
                name: "BookingDetailStaff");

            migrationBuilder.DropTable(
                name: "PackageService");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "ReportWork");

            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
