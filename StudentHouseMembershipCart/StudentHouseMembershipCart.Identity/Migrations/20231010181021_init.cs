using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekNumberBooking = table.Column<int>(type: "int", nullable: false),
                    NumberOfPerWeekDoPackage = table.Column<int>(type: "int", nullable: false),
                    DayDoServiceInWeek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Admin_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    staffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        name: "FK_Staff_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        name: "FK_Student_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReportWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionProcess = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Apartment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PackageService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDetailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsRe_Newed = table.Column<bool>(type: "bit", nullable: false),
                    RenewStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    remainingTaskDuration = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AttendReport",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDoPackage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BookingDetailStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    table.ForeignKey(
                        name: "FK_FeedBack_AttendReport_AttendReportId",
                        column: x => x.AttendReportId,
                        principalTable: "AttendReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FeedBack_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ROLE1", "30261265-fd48-4a34-93fb-ee4992e54350", "Student", "Student" },
                    { "ROLE2", "08959f45-24ce-4b9d-9f4d-c2d092317dfa", "Staff", "Staff" },
                    { "ROLE3", "8c3bea0d-18e3-493d-8955-a04a76846260", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ACCOUNT1", 0, "e49905cd-b25d-4d85-b9a9-cdc174cfbfc8", "vi@gmail.com", true, "Nguyen Vi", false, null, "VI@GMAIL.COM", "VI@GMAIL.COM", "AQAAAAEAACcQAAAAEPaqHDh0urMVQg6590s7RpfZYu++DaAS9Mc8izupZqmSL31U1WhGKDghVP7H2dJuQg==", null, false, "e3c663b8-538d-4fa7-8035-4549a94c2ae0", false, "vi@gmail.com" },
                    { "ACCOUNT10", 0, "79df4fe7-a7b4-4d93-97e6-5ba3934b049a", "student2@gmail.com", true, "student2", false, null, "STUDENT2@GMAIL.COM", "STUDENT2", "AQAAAAEAACcQAAAAEFoVU8KF7v9FkJ0kadNKC8G+nUsjQ5uy3QP3iJne0DNgPyYN+r8KmVp82roKba1cbw==", null, false, "f914ca87-2a44-4e76-a1b4-cf6153a97810", false, "student2" },
                    { "ACCOUNT11", 0, "249b1e23-e93f-4b65-bc00-c0688fbc7349", "student3@gmail.com", true, "student3", false, null, "STUDENT3@GMAIL.COM", "STUDENT3", "AQAAAAEAACcQAAAAEDpbBqRIeJRUcX3idPtRE991nZ5yb51VGPE7i8u5rIKiVSqZvkQvMEdVqngzXJSuSw==", null, false, "0b539deb-ebd1-4943-b74c-196f3a3fb4e3", false, "student3" },
                    { "ACCOUNT2", 0, "0bd467fc-7e84-4865-8309-680810485d77", "nhan@gmail.com", true, "Nguyen Nhan", false, null, "NHAN@GMAIL.COM", "NHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFEtCW1clwL6KTRwpRsr8N0UtFLBxDZjU8Ou8ekSraFAoh4YxHUIRJd2MVljflUVEw==", null, false, "1b94dbeb-2497-46aa-b81a-401ee5c38bdf", false, "nhan@gmail.com" },
                    { "ACCOUNT3", 0, "753892d8-c5f6-490b-9fdc-8463ec1c1a68", "dai@gmail.com", true, "Nguyen Dai", false, null, "DAI@GMAIL.COM", "DAI@GMAIL.COM", "AQAAAAEAACcQAAAAEGecjJJv8VVjn4YXizk5tQq7LmNU5Dx/Fu8ADWzPRBN2YInpV049BDRGqdewQrbiWA==", null, false, "34c04452-4ba1-403e-ae16-3fa684244eab", false, "dai@gmail.com" },
                    { "ACCOUNT4", 0, "223fc66f-dba8-456a-aa54-4f72c0a9275f", "admin@gmail.com", true, "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFMKAvnxhvOUWFDpqfUxc5Nb/RpwTKdF9rBPi8WMVuw54pzbz5ROC/z2ZqmduEJOlQ==", null, false, "938abd4a-ee51-49ed-b768-ad10d56c256f", false, "admin" },
                    { "ACCOUNT5", 0, "983943ad-b96d-4718-bd89-131f000c1c88", "staff1@gmail.com", true, "staff", false, null, "STAFF1@GMAIL.COM", "STAFF", "AQAAAAEAACcQAAAAEJ+RD+qrWyKO38hzrIzYA1a+j1jVDwzQntq9SPxWZMwv8f869Tj+D7le0Ou9bsFw8Q==", null, false, "57afda94-3da8-4450-b538-ac379cfe6ba3", false, "staff" },
                    { "ACCOUNT6", 0, "a93590d5-2f79-404f-be1a-340cdd12acdb", "staff2@gmail.com", true, "staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2", "AQAAAAEAACcQAAAAEHvUYkC7NzjvD13z+PPC2fZbT4Ep3vgjSTEyQMcqOhtj6N4t86vCM8H7GvTP2DcNag==", null, false, "fdd937cf-2228-4454-9d57-5ac92bfe5da4", false, "staff2" },
                    { "ACCOUNT7", 0, "b8e8c52c-d27a-4379-a0f6-323bff429726", "staff3@gmail.com", true, "staff3", false, null, "STAFF3@GMAIL.COM", "STAFF3", "AQAAAAEAACcQAAAAEEf+/I5WPyix+tlRy1/ICD8O9cNF6idW666eHI6n20qvTVucMBa4FvWuKXXV+2BVWg==", null, false, "50ca208d-4c9f-4b03-975f-4b4d0a2a8749", false, "staff3" },
                    { "ACCOUNT9", 0, "ef78e36d-11b8-426b-a8c8-54b692b46d32", "student1@gmail.com", true, "student1", false, null, "STUDENT1@GMAIL.COM", "STUDENT1", "AQAAAAEAACcQAAAAEG7IiKT0BMC7ASP7Cp1KwBqdgSYxggcsBrOGjyXiQPnmE12o5ptIkdkB6jKeOhY7HQ==", null, false, "ca3ee888-eed4-4e95-87b5-ec3592bad206", false, "student1" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("21291667-7546-4825-9bad-840d648900a3"), "dọn vệ sinh nhà cửa", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5470), false, null, null },
                    { new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), "Shipping", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5466), false, null, null },
                    { new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"), "hỗ trợ tài chính", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5468), false, null, null },
                    { new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), "Rửa xe", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5458), false, null, null },
                    { new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"), "Nấu ăn cho em", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5464), false, null, null },
                    { new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), "Giặt đồ", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5473), false, null, null },
                    { new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), "Bảo trì và sửa chữa", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5472), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreateBy", "Created", "DayDoServiceInWeek", "Image", "IsDelete", "LastModified", "LastModifiedBy", "NumberOfPerWeekDoPackage", "PackageName", "TotalPrice", "WeekNumberBooking" },
                values: new object[,]
                {
                    { new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5788), "4", null, false, null, null, 1, "Rửa xe premium package", 0.0, 1 },
                    { new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5786), "5", null, false, null, null, 1, "Hỗ trợ tài chính vippro package", 0.0, 1 },
                    { new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5782), "5", null, false, null, null, 1, "Nấu ăn package", 0.0, 1 },
                    { new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5801), "37", null, false, null, null, 2, "Vận chuyên giao vận package", 0.0, 6 },
                    { new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5791), "2", null, false, null, null, 1, "Giặt đồ package", 0.0, 1 },
                    { new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5797), "25", null, false, null, null, 2, "Dọn vệ sinh nhà cửa package", 0.0, 6 },
                    { new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5774), "26", null, false, null, null, 2, "Maintenance & Repairs normal Package", 0.0, 6 }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RegionName" },
                values: new object[,]
                {
                    { new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6053), false, null, null, "Quận 1" },
                    { new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6065), false, null, null, "Quận 5" },
                    { new Guid("2429516b-5620-4838-912f-f4826f5d28bd"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6061), false, null, null, "Quận 7" },
                    { new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6054), false, null, null, "Quận 2" },
                    { new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6044), false, null, null, "Quan Binh Thanh" },
                    { new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6042), false, null, null, "Dong Nai" },
                    { new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6056), false, null, null, "Quận 3" },
                    { new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6048), false, null, null, "Quận 12" },
                    { new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6046), false, null, null, "Quận 11" },
                    { new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6051), false, null, null, "Hóc Môn" },
                    { new Guid("8725e1c4-e76b-4563-916b-a668516237e2"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6063), false, null, null, "Quận 4" },
                    { new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6060), false, null, null, "Quận 9" },
                    { new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6036), false, null, null, "Quận 8" },
                    { new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6067), false, null, null, "Quận 6" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "AdminName", "ApplicationUserId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"), "Admin", "ACCOUNT4", null, new DateTime(2023, 10, 11, 1, 10, 20, 663, DateTimeKind.Local).AddTicks(775), false, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ROLE1", "ACCOUNT1" },
                    { "ROLE1", "ACCOUNT10" },
                    { "ROLE1", "ACCOUNT11" },
                    { "ROLE2", "ACCOUNT2" },
                    { "ROLE3", "ACCOUNT3" },
                    { "ROLE2", "ACCOUNT5" },
                    { "ROLE2", "ACCOUNT6" },
                    { "ROLE2", "ACCOUNT7" },
                    { "ROLE1", "ACCOUNT9" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "CategoryId", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Price", "ServiceDescription", "ServiceName" },
                values: new object[,]
                {
                    { new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"), new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6401), "abc", false, null, null, 0.0, "Nước được đóng trong các bình chất lượng cao, đảm bảo vệ sinh và an toàn.", "Giao nước uống" },
                    { new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"), new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6398), "abc", false, null, null, 0.0, "đóng gói, vận chuyển và xếp đặt đồ đạc của sinh viên một cách cẩn thận.", "Chuyển nhà" },
                    { new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"), new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6392), "abc", false, null, null, 0.0, "Cung cấp giải pháp tài chính linh hoạt cho sinh viên, cho phép họ vay tiền để chi trả học phí, sách vở, chi phí sinh hoạt hàng ngày và các nhu cầu khác liên quan đến việc học tập. Quy trình đơn giản và linh hoạt, cung cấp các lựa chọn vay phù hợp với điều kiện tài chính của sinh viên, giúp họ tiếp cận giáo dục một cách thuận lợi.", "Hỗ trợ vay tiền học" },
                    { new Guid("30743744-754b-4a87-b828-6186ccc7ece6"), new Guid("21291667-7546-4825-9bad-840d648900a3"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6408), "abc", false, null, null, 0.0, "quét nhà, lau nhà, rửa chén, xếp quần áo, đổ rác", "Dọn dẹp nhà cửa" },
                    { new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"), new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6410), "abc", false, null, null, 0.0, "kiểm tra, xác định và khắc phục vấn đề, Thay van, tra keo", "Sửa ống nước" },
                    { new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"), new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6413), "abc", false, null, null, 0.0, "kiểm tra, xác định và khắc phục vấn đề", "Sửa wifi" },
                    { new Guid("7635d149-2a74-4562-b779-c81056594bfb"), new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6380), "abc", false, null, null, 0.0, "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.", "Giặt áo vest" },
                    { new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6377), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe Hơi, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả", "Dịch vụ rửa xe hơi" },
                    { new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6395), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe đạp, bơm bánh xe", "Rửa xe đạp" },
                    { new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"), new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6383), "abc", false, null, null, 0.0, "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.", "Giặt quần áo hằng ngày" },
                    { new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6371), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe máy, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả, xúc bình xăng", "Dịch vụ rửa xe máy" },
                    { new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"), new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6405), "abc", false, null, null, 0.0, "đi chợ, mua thực phẩm, chế biến, tính tiền", "Nấu cơm" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "staffName" },
                values: new object[,]
                {
                    { new Guid("a8ded7dd-683f-4231-8c47-560375560eea"), "Long An", "ACCOUNT7", new DateTime(2000, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6640), false, null, null, "Staff 3" },
                    { new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"), "An Giang", "ACCOUNT6", new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6634), false, null, null, "Staff 2" },
                    { new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"), "Dong Nai", "ACCOUNT5", new DateTime(1999, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6543), false, null, null, "Staff 1" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "Phone" },
                values: new object[,]
                {
                    { new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"), "Hà Nội", "ACCOUNT11", new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6811), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6809), false, null, null, "0987451632" },
                    { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "Hồ Chí Minh", "ACCOUNT10", new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6808), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6807), false, null, null, "0312357823" },
                    { new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"), "Đà Nẵng", "ACCOUNT9", new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6796), false, null, null, "0961868641" }
                });

            migrationBuilder.InsertData(
                table: "Apartment",
                columns: new[] { "Id", "Address", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RegionId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "145, phuong 5, quan Hoan Kiem, Ha Noi", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4484), false, null, null, new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"), new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939") },
                    { new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "286,phuong 24, quan Hai Ba Trung, Ha Noi", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4453), false, null, null, new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"), new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") },
                    { new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "176, phuong 26, quan Binh Thanh, TP.HCM", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4481), false, null, null, new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"), new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") }
                });

            migrationBuilder.InsertData(
                table: "PackageService",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PackageId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5914), false, null, null, new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), new Guid("30743744-754b-4a87-b828-6186ccc7ece6") },
                    { new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5922), false, null, null, new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), new Guid("29140864-8e89-41b6-8fd7-a440800e6e00") },
                    { new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5910), false, null, null, new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843") },
                    { new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5925), false, null, null, new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"), new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8") },
                    { new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5919), false, null, null, new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"), new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270") }
                });

            migrationBuilder.InsertData(
                table: "ReportWork",
                columns: new[] { "Id", "CreateBy", "Created", "DescriptionProcess", "Image", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6184), "Lau tủ, Lau bếp, Rửa chén. Hoàn Thành", "abc", false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("6323937a-3b10-4277-8d7b-e61368bd8cf9"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6240), "Cho vay thành công, hẹn ngày trả tiền!", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("6f187fcd-c544-46c4-bdb1-38cd254ffcae"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6192), "Giặt đồ sạch sẽ", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("991b3ff2-962f-439a-aec6-051d522a8904"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6180), "Giao hàng đến 123/8 Long Thạnh Mỹ, Quận 9. Thành Công!!!", "abc", false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("b1bcf1d6-5b2e-43dd-8645-6738d6787924"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6242), "Thay nhớt, pha bột rửa xe, bơm bánh, kiểm tra hệ thống xe, lau khô", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6186), "Sửa ống nước, thay van. Thành công", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("e104a356-2baf-4bf9-a3d8-b1463352c3e7"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(6237), "Nấu 3 món: canh, cá, rau luộc", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "ApartmentId", "Contract", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StartDate", "TotalPay" },
                values: new object[,]
                {
                    { new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"), new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "Hợp đồng giặt đồ", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4944), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4946), 1222.5 },
                    { new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"), new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "Hợp đồng vận chuyển đồ", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4956), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4958), 2233.3000000000002 },
                    { new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"), new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "Hợp đồng dọn vệ sinh nhà cửa", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4948), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4950), 2233.3000000000002 },
                    { new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"), new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "Hợp đồng Rửa xe", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4937), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4941), 1234.5 },
                    { new Guid("a39735c8-440d-440f-9a5f-932164975749"), new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "Hợp đồng dịch vụ hỗ trợ tài chính", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4952), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4954), 2233.3000000000002 },
                    { new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"), new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "Hợp đồng nấu ăn cho em", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4960), false, null, null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4961), 2233.3000000000002 }
                });

            migrationBuilder.InsertData(
                table: "BookingDetail",
                columns: new[] { "Id", "BookingDetailName", "BookingId", "ContractDescription", "ContractName", "CreateBy", "Created", "IsDelete", "IsRe_Newed", "LastModified", "LastModifiedBy", "PackageId", "Price", "RenewStartDate", "remainingTaskDuration" },
                values: new object[,]
                {
                    { new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), "Giặt đồ", new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"), "giá cả, thời gian và địa điểm, bảo hành", "Hợp đồng giặt đồ", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5158), false, true, null, null, new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), 3333.3000000000002, null, 2 },
                    { new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"), "Dịch vụ Chuyển Nhà", new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"), "giá cả, điều kiện thanh toán, và quy trình vận chuyển và đúng kế hoạch", "Hợp đồng dịch vụ chuyển nhà siêu tốc", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5175), false, true, null, null, new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"), 3232.3000000000002, null, 3 },
                    { new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), "Dọn vệ sinh nhà cửa", new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"), "giá cả, lịch trình làm việc, các điều kiện thanh toán", "Hợp đồng dọn vệ sinh nhà cửa", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5164), false, true, null, null, new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), 3232.3000000000002, null, 3 },
                    { new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"), "Nấu ăn cho iemmm", new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"), "giá cả, điều kiện thanh toán, và nghĩa vụ của cả hai bên", "Hợp đồng dịch vụ nấu ăn mỗi ngày cho bé", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5172), false, true, null, null, new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), 3232.3000000000002, null, 3 },
                    { new Guid("be08997c-61a5-4859-98a2-459c93dca574"), "Rửa xe", new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"), "rửa xe, làm sạch bình xăng, đánh bóng", "Hợp đồng Rửa xe", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5152), false, true, null, null, new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), 2222.1999999999998, null, 1 },
                    { new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"), "Hỗ trợ tài chính", new Guid("a39735c8-440d-440f-9a5f-932164975749"), "giá cả, điều kiện thanh toán, và nghĩa vụ của cả hai bên", "Hợp đồng dịch vụ hỗ trợ tài chính", null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5168), false, true, null, null, new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), 3232.3000000000002, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "AttendReport",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "DateDoPackage", "IsDelete", "LastModified", "LastModifiedBy", "ReportWorkId" },
                values: new object[,]
                {
                    { new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"), new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4634), false, null, null, new Guid("e104a356-2baf-4bf9-a3d8-b1463352c3e7") },
                    { new Guid("275b2720-420d-4b33-835a-4651d92f1390"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4630), false, null, null, new Guid("b1bcf1d6-5b2e-43dd-8645-6738d6787924") },
                    { new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"), new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4637), false, null, null, new Guid("991b3ff2-962f-439a-aec6-051d522a8904") },
                    { new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"), new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4640), false, null, null, new Guid("6323937a-3b10-4277-8d7b-e61368bd8cf9") },
                    { new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(4625), false, null, null, new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883") }
                });

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("86178fcb-a77c-422f-900e-f216c5df75bd"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5338), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("9de26ee8-04d1-418b-bf17-604e0934ecfc"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5344), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("a3855137-188c-4d73-9f7b-176b720d5335"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5342), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") }
                });

            migrationBuilder.InsertData(
                table: "FeedBack",
                columns: new[] { "Id", "AttendReportId", "CreateBy", "Created", "FeedBackDescription", "FeedBackImage", "FeedBackName", "FeedBackRating", "IsDelete", "LastModified", "LastModifiedBy", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"), new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5600), "Cơm cô 3 và chị 7 nấu rất là ngon và trắng, nói chung tuyệt cú mèo", "/url/asdas/sadas", "Feedback nấu ăn cho em", "5 sao", false, null, null, new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") },
                    { new Guid("2372f547-375e-4f88-a726-37643180c585"), new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5588), "dọn dẹp cực kì có tâm, lao nhà quá sạch, đi muốn té tét đầu", "/url/asdas/sadas", "Feedback dọn dẹp nhà cửa của căn hộ 0504 vinhomes", "5 sao", false, null, null, new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") },
                    { new Guid("53838b2b-a19f-422a-8f62-6363476c21da"), new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5604), "vận chuyển đúng thời gian và quy định của kí túc xá, Quá đã pepsi ơi!!!", "/url/asdas/sadas", "Feedback chuyển nhà cho sinh viên nghèo vượt khó", "4 sao", false, null, null, new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939") },
                    { new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"), new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5613), "Quả thật là vị cứu tinh đúng nghĩa, 10 điểm không có nhưng", "/url/asdas/sadas", "Feedback hỗ trợ tài chánh cho sinh viên nghiện.", "5 sao", false, null, null, new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") },
                    { new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"), new Guid("275b2720-420d-4b33-835a-4651d92f1390"), null, new DateTime(2023, 10, 11, 1, 10, 20, 734, DateTimeKind.Local).AddTicks(5594), "Rửa xe sạch bon bon, soi thấy cục mụn, nhưng bơm bánh xe hơi căng", "/url/asdas/sadas", "Feedback rửa xe máy winner X của a Vĩ", "4,5 sao", false, null, null, new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ApplicationUserId",
                table: "Admin",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_RegionId",
                table: "Apartment",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_StudentId",
                table: "Apartment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AttendReport_BookingDetailId",
                table: "AttendReport",
                column: "BookingDetailId");

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
                name: "IX_FeedBack_AttendReportId",
                table: "FeedBack",
                column: "AttendReportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_StudentId",
                table: "FeedBack",
                column: "StudentId");

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
                name: "IX_Staff_ApplicationUserId",
                table: "Staff",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ApplicationUserId",
                table: "Student",
                column: "ApplicationUserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookingDetailStaff");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "PackageService");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AttendReport");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "ReportWork");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
