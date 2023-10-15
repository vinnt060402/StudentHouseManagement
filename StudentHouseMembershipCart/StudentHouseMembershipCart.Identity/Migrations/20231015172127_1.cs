using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _1 : Migration
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CategoryStaff",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStaff", x => new { x.CategoryId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_CategoryStaff_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CategoryStaff_Staff_StaffId",
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
                    StatusContract = table.Column<int>(type: "int", nullable: true),
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
                    TotalPriceOfQuantity = table.Column<double>(type: "float", nullable: false),
                    IsRe_Newed = table.Column<bool>(type: "bit", nullable: false),
                    RenewStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemainingTaskDuration = table.Column<int>(type: "int", nullable: false),
                    QuantityOfPackageOrdered = table.Column<int>(type: "int", nullable: false),
                    BookingDetailStatus = table.Column<int>(type: "int", nullable: true),
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
                    ReportWorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttendenceStatus = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "ReportWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkingDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescriptionProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_ReportWork_AttendReport_AttendReportId",
                        column: x => x.AttendReportId,
                        principalTable: "AttendReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ReportWork_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ROLE1", "32de03e2-d9df-4d5d-82bb-f587d187bab7", "Student", "Student" },
                    { "ROLE2", "0fa301a8-dec2-4a01-b878-885d7312b190", "Staff", "Staff" },
                    { "ROLE3", "06a65517-d0ce-4f55-a6a6-7755ccc851f7", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ACCOUNT1", 0, "396c294e-0b5f-4e9e-9d24-995a010a1a11", "vi@gmail.com", true, "Nguyen Vi", false, null, "VI@GMAIL.COM", "VI@GMAIL.COM", "AQAAAAEAACcQAAAAEJXV0ZaaBlli12BcDkpR7USkSAcQ+Q2J4kJ1coWQ1e6zJsfN8PhIuUyhRir94i3IkA==", null, false, "f90e3aa8-41ed-4488-b612-57b51da6e5c2", false, "vi@gmail.com" },
                    { "ACCOUNT10", 0, "b62e8b6e-ffa5-48ea-a72f-254c2d2a67ab", "student2@gmail.com", true, "student2", false, null, "STUDENT2@GMAIL.COM", "STUDENT2", "AQAAAAEAACcQAAAAEAOTjI5Jqy0Oqz10HZm5MLqhUmt4HawSMa6xvp3C9mrj1MuoPmyz82C+WXFeYdP5Rg==", null, false, "7254eabc-6de9-44a8-84c4-413beff8bfad", false, "student2" },
                    { "ACCOUNT11", 0, "a22cf1d4-4aee-4f13-bfac-4309239f123d", "student3@gmail.com", true, "student3", false, null, "STUDENT3@GMAIL.COM", "STUDENT3", "AQAAAAEAACcQAAAAENSwPrqcx1b3S0vXP3CoaLoR9pTJRjjqSRlEVeKfM1wB17Y3tkybAc51flV7vqP1fg==", null, false, "c6207fd7-6bbe-4688-b72d-6d4e7120abc8", false, "student3" },
                    { "ACCOUNT2", 0, "8b45e1f2-dc98-4030-bd3d-52ea8a40ed5a", "nhan@gmail.com", true, "Nguyen Nhan", false, null, "NHAN@GMAIL.COM", "NHAN@GMAIL.COM", "AQAAAAEAACcQAAAAELXWWezOKLtHnKpHAWm1E8TNLgtj6kaNr3UVbl1+chZ94aF4tcopbBMa7+2uF2cWGg==", null, false, "b3342784-e35a-452e-a75c-3cd0da2790f0", false, "nhan@gmail.com" },
                    { "ACCOUNT3", 0, "ee58aee0-5da3-4a52-9842-97ff709f9a30", "dai@gmail.com", true, "Nguyen Dai", false, null, "DAI@GMAIL.COM", "DAI@GMAIL.COM", "AQAAAAEAACcQAAAAEINHHKLjQH6vB/vAE+/i7aIReQhJ76jISvqb8TJ8ZyMLp6ZbBXNmcMZkllhxLoNq+A==", null, false, "204d5c99-2f3a-4720-836c-2f392e8f9e4e", false, "dai@gmail.com" },
                    { "ACCOUNT4", 0, "530424e7-d7b1-4681-b904-13cd5e6b5260", "admin@gmail.com", true, "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEaeExy7Z9/N2cIdDPi04wmi4ghnP56wNHyRlJQJs6ph5s0YoHe2k4kT5uI0qA66/Q==", null, false, "27772c2e-de1c-4639-90c7-f737d7fc39db", false, "admin" },
                    { "ACCOUNT5", 0, "fb63cb60-5b85-4a28-ba9f-b9d3649b21a2", "staff1@gmail.com", true, "staff", false, null, "STAFF1@GMAIL.COM", "STAFF", "AQAAAAEAACcQAAAAEJ0qf885hCbApqKkp97MOym7Jaf37Ad6w1Y6zWwrCQuwhgqlLpA3T9K4eaKF1846xA==", null, false, "f16bdbf6-9cc8-4403-9ddd-b5f138097c50", false, "staff" },
                    { "ACCOUNT6", 0, "438960a1-fa62-4c44-9a2d-d412c34ed0bb", "staff2@gmail.com", true, "staff2", false, null, "STAFF2@GMAIL.COM", "STAFF2", "AQAAAAEAACcQAAAAEO8fQnwD0vD3D7cxhmpp3zVQeVtCpeyzZs7MWymGkl+iRHc3a+K8EjHafHWDxehRfA==", null, false, "8ea41cae-a460-4973-a29c-ff38cc77a06d", false, "staff2" },
                    { "ACCOUNT7", 0, "78179bc7-e255-4cbd-b0d3-d84a29c40d8f", "staff3@gmail.com", true, "staff3", false, null, "STAFF3@GMAIL.COM", "STAFF3", "AQAAAAEAACcQAAAAECAx+ANEhMwCoHzhfO+QDvztexE0YoHgcEtHKfpWM28Q8PQDlcg0rYLrGLHWiBosVw==", null, false, "7dc92a80-dc66-402b-a8a1-1fb016a6b0e1", false, "staff3" },
                    { "ACCOUNT9", 0, "3c69f0a0-86b9-406c-af89-d6929fe91adc", "student1@gmail.com", true, "student1", false, null, "STUDENT1@GMAIL.COM", "STUDENT1", "AQAAAAEAACcQAAAAEG4bKMFY1i+LTiXhzHLcTcX0tMoXwv77Otuw+2KITlFI6cFcxLelpRdXQAhe8S/7ew==", null, false, "4d614a22-736c-4c39-889d-02442dd89015", false, "student1" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("21291667-7546-4825-9bad-840d648900a3"), "dọn vệ sinh nhà cửa", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4398), null, false, null, null },
                    { new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), "Shipping", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4393), null, false, null, null },
                    { new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"), "hỗ trợ tài chính", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4396), null, false, null, null },
                    { new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), "Rửa xe", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4385), null, false, null, null },
                    { new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"), "Nấu ăn cho em", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4388), null, false, null, null },
                    { new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), "Giặt đồ", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4402), null, false, null, null },
                    { new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), "Bảo trì và sửa chữa", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4400), null, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreateBy", "Created", "DayDoServiceInWeek", "Image", "IsDelete", "LastModified", "LastModifiedBy", "NumberOfPerWeekDoPackage", "PackageName", "TotalPrice", "WeekNumberBooking" },
                values: new object[,]
                {
                    { new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4776), "4", null, false, null, null, 1, "Rửa xe premium package", 0.0, 1 },
                    { new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4685), "5", null, false, null, null, 1, "Hỗ trợ tài chính vippro package", 0.0, 1 },
                    { new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4681), "5", null, false, null, null, 1, "Nấu ăn package", 0.0, 1 },
                    { new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4786), "37", null, false, null, null, 2, "Vận chuyên giao vận package", 0.0, 6 },
                    { new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4779), "2", null, false, null, null, 1, "Giặt đồ package", 0.0, 1 },
                    { new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4781), "25", null, false, null, null, 2, "Dọn vệ sinh nhà cửa package", 0.0, 6 },
                    { new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4674), "26", null, false, null, null, 2, "Maintenance & Repairs normal Package", 0.0, 6 }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RegionName" },
                values: new object[,]
                {
                    { new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5064), false, null, null, "Quận 1" },
                    { new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5078), false, null, null, "Quận 5" },
                    { new Guid("2429516b-5620-4838-912f-f4826f5d28bd"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5074), false, null, null, "Quận 7" },
                    { new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5066), false, null, null, "Quận 2" },
                    { new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5057), false, null, null, "Quan Binh Thanh" },
                    { new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5052), false, null, null, "Dong Nai" },
                    { new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5068), false, null, null, "Quận 3" },
                    { new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5061), false, null, null, "Quận 12" },
                    { new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5059), false, null, null, "Quận 11" },
                    { new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5063), false, null, null, "Hóc Môn" },
                    { new Guid("8725e1c4-e76b-4563-916b-a668516237e2"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5076), false, null, null, "Quận 4" },
                    { new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5070), false, null, null, "Quận 9" },
                    { new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5048), false, null, null, "Quận 8" },
                    { new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5080), false, null, null, "Quận 6" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "AdminName", "ApplicationUserId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[] { new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"), "Admin", "ACCOUNT4", null, new DateTime(2023, 10, 16, 0, 21, 26, 986, DateTimeKind.Local).AddTicks(7191), false, null, null });

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
                    { new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"), new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5413), "abc", false, null, null, 0.0, "Nước được đóng trong các bình chất lượng cao, đảm bảo vệ sinh và an toàn.", "Giao nước uống" },
                    { new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"), new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5409), "abc", false, null, null, 0.0, "đóng gói, vận chuyển và xếp đặt đồ đạc của sinh viên một cách cẩn thận.", "Chuyển nhà" },
                    { new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"), new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5402), "abc", false, null, null, 0.0, "Cung cấp giải pháp tài chính linh hoạt cho sinh viên, cho phép họ vay tiền để chi trả học phí, sách vở, chi phí sinh hoạt hàng ngày và các nhu cầu khác liên quan đến việc học tập. Quy trình đơn giản và linh hoạt, cung cấp các lựa chọn vay phù hợp với điều kiện tài chính của sinh viên, giúp họ tiếp cận giáo dục một cách thuận lợi.", "Hỗ trợ vay tiền học" },
                    { new Guid("30743744-754b-4a87-b828-6186ccc7ece6"), new Guid("21291667-7546-4825-9bad-840d648900a3"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5425), "abc", false, null, null, 0.0, "quét nhà, lau nhà, rửa chén, xếp quần áo, đổ rác", "Dọn dẹp nhà cửa" },
                    { new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"), new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5429), "abc", false, null, null, 0.0, "kiểm tra, xác định và khắc phục vấn đề, Thay van, tra keo", "Sửa ống nước" },
                    { new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"), new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5432), "abc", false, null, null, 0.0, "kiểm tra, xác định và khắc phục vấn đề", "Sửa wifi" },
                    { new Guid("7635d149-2a74-4562-b779-c81056594bfb"), new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5396), "abc", false, null, null, 0.0, "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.", "Giặt áo vest" },
                    { new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5393), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe Hơi, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả", "Dịch vụ rửa xe hơi" },
                    { new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5405), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe đạp, bơm bánh xe", "Rửa xe đạp" },
                    { new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"), new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5399), "abc", false, null, null, 0.0, "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.", "Giặt quần áo hằng ngày" },
                    { new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"), new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5385), "abc", false, null, null, 0.0, "Làm mới và làm sạch xe máy, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả, xúc bình xăng", "Dịch vụ rửa xe máy" },
                    { new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"), new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5415), "abc", false, null, null, 0.0, "đi chợ, mua thực phẩm, chế biến, tính tiền", "Nấu cơm" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "staffName" },
                values: new object[,]
                {
                    { new Guid("a8ded7dd-683f-4231-8c47-560375560eea"), "Long An", "ACCOUNT7", new DateTime(2000, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5644), false, null, null, "Staff 3" },
                    { new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"), "An Giang", "ACCOUNT6", new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5636), false, null, null, "Staff 2" },
                    { new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"), "Dong Nai", "ACCOUNT5", new DateTime(1999, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5562), false, null, null, "Staff 1" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "Phone" },
                values: new object[,]
                {
                    { new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"), "Hà Nội", "ACCOUNT11", new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5824), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5823), false, null, null, "0987451632" },
                    { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "Hồ Chí Minh", "ACCOUNT10", new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5819), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5817), false, null, null, "0312357823" },
                    { new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"), "Đà Nẵng", "ACCOUNT9", new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5806), false, null, null, "0961868641" }
                });

            migrationBuilder.InsertData(
                table: "Apartment",
                columns: new[] { "Id", "Address", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RegionId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "145, phuong 5, quan Hoan Kiem, Ha Noi", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3540), false, null, null, new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"), new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939") },
                    { new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "286,phuong 24, quan Hai Ba Trung, Ha Noi", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3503), false, null, null, new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"), new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") },
                    { new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "176, phuong 26, quan Binh Thanh, TP.HCM", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3537), false, null, null, new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"), new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") }
                });

            migrationBuilder.InsertData(
                table: "PackageService",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PackageId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4916), false, null, null, new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), new Guid("30743744-754b-4a87-b828-6186ccc7ece6") },
                    { new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4924), false, null, null, new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), new Guid("29140864-8e89-41b6-8fd7-a440800e6e00") },
                    { new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4909), false, null, null, new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843") },
                    { new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4927), false, null, null, new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"), new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8") },
                    { new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4921), false, null, null, new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"), new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270") }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "ApartmentId", "Contract", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StartDate", "StatusContract", "TotalPay" },
                values: new object[,]
                {
                    { new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"), new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "Hợp đồng giặt đồ", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3840), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3841), null, 1222.5 },
                    { new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"), new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"), "Hợp đồng vận chuyển đồ", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3850), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3852), null, 2233.3000000000002 },
                    { new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"), new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "Hợp đồng dọn vệ sinh nhà cửa", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3844), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3845), null, 2233.3000000000002 },
                    { new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"), new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "Hợp đồng Rửa xe", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3830), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3834), null, 1234.5 },
                    { new Guid("a39735c8-440d-440f-9a5f-932164975749"), new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"), "Hợp đồng dịch vụ hỗ trợ tài chính", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3847), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3848), null, 2233.3000000000002 },
                    { new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"), new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"), "Hợp đồng nấu ăn cho em", null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3853), false, null, null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3858), null, 2233.3000000000002 }
                });

            migrationBuilder.InsertData(
                table: "BookingDetail",
                columns: new[] { "Id", "BookingDetailStatus", "BookingId", "CreateBy", "Created", "IsDelete", "IsRe_Newed", "LastModified", "LastModifiedBy", "PackageId", "QuantityOfPackageOrdered", "RemainingTaskDuration", "RenewStartDate", "TotalPriceOfQuantity" },
                values: new object[,]
                {
                    { new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3974), false, true, null, null, new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"), 0, 2, null, 3333.3000000000002 },
                    { new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"), null, new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4122), false, true, null, null, new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"), 0, 3, null, 3232.3000000000002 },
                    { new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4108), false, true, null, null, new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"), 0, 3, null, 3232.3000000000002 },
                    { new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"), null, new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4119), false, true, null, null, new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), 0, 3, null, 3232.3000000000002 },
                    { new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3969), false, true, null, null, new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"), 0, 1, null, 2222.1999999999998 },
                    { new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"), null, new Guid("a39735c8-440d-440f-9a5f-932164975749"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4116), false, true, null, null, new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"), 0, 3, null, 3232.3000000000002 }
                });

            migrationBuilder.InsertData(
                table: "AttendReport",
                columns: new[] { "Id", "AttendenceStatus", "BookingDetailId", "CreateBy", "Created", "DateDoPackage", "IsDelete", "LastModified", "LastModifiedBy", "ReportWorkId" },
                values: new object[,]
                {
                    { new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"), null, new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3705), false, null, null, new Guid("e104a356-2baf-4bf9-a3d8-b1463352c3e7") },
                    { new Guid("275b2720-420d-4b33-835a-4651d92f1390"), null, new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3698), false, null, null, new Guid("b1bcf1d6-5b2e-43dd-8645-6738d6787924") },
                    { new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"), null, new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3709), false, null, null, new Guid("991b3ff2-962f-439a-aec6-051d522a8904") },
                    { new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"), null, new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3713), false, null, null, new Guid("6323937a-3b10-4277-8d7b-e61368bd8cf9") },
                    { new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"), null, new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3691), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3693), false, null, null, new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883") }
                });

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("243069df-d4d5-43bf-97c0-3ecb4fb981d1"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4265), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("4d3dc143-5241-495c-8759-0ee7ddf5bbda"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4263), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("aa750d01-8c01-45f5-ab48-aa67266eea1e"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4258), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") }
                });

            migrationBuilder.InsertData(
                table: "FeedBack",
                columns: new[] { "Id", "AttendReportId", "CreateBy", "Created", "FeedBackDescription", "FeedBackImage", "FeedBackName", "FeedBackRating", "IsDelete", "LastModified", "LastModifiedBy", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"), new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4525), "Cơm cô 3 và chị 7 nấu rất là ngon và trắng, nói chung tuyệt cú mèo", "/url/asdas/sadas", "Feedback nấu ăn cho em", "5 sao", false, null, null, new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") },
                    { new Guid("2372f547-375e-4f88-a726-37643180c585"), new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4514), "dọn dẹp cực kì có tâm, lao nhà quá sạch, đi muốn té tét đầu", "/url/asdas/sadas", "Feedback dọn dẹp nhà cửa của căn hộ 0504 vinhomes", "5 sao", false, null, null, new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") },
                    { new Guid("53838b2b-a19f-422a-8f62-6363476c21da"), new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4531), "vận chuyển đúng thời gian và quy định của kí túc xá, Quá đã pepsi ơi!!!", "/url/asdas/sadas", "Feedback chuyển nhà cho sinh viên nghèo vượt khó", "4 sao", false, null, null, new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939") },
                    { new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"), new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4535), "Quả thật là vị cứu tinh đúng nghĩa, 10 điểm không có nhưng", "/url/asdas/sadas", "Feedback hỗ trợ tài chánh cho sinh viên nghiện.", "5 sao", false, null, null, new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485") },
                    { new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"), new Guid("275b2720-420d-4b33-835a-4651d92f1390"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4521), "Rửa xe sạch bon bon, soi thấy cục mụn, nhưng bơm bánh xe hơi căng", "/url/asdas/sadas", "Feedback rửa xe máy winner X của a Vĩ", "4,5 sao", false, null, null, new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420") }
                });

            migrationBuilder.InsertData(
                table: "ReportWork",
                columns: new[] { "Id", "AttendReportId", "CreateBy", "Created", "DescriptionProcess", "Image", "IsDelete", "LastModified", "LastModifiedBy", "StaffId", "WorkingDay" },
                values: new object[,]
                {
                    { new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"), new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5196), "Lau tủ, Lau bếp, Rửa chén. Hoàn Thành", "abc", false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("991b3ff2-962f-439a-aec6-051d522a8904"), new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5191), "Giao hàng đến 123/8 Long Thạnh Mỹ, Quận 9. Thành Công!!!", "abc", false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"), new Guid("275b2720-420d-4b33-835a-4651d92f1390"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5199), "Sửa ống nước, thay van. Thành công", "abc", false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_CategoryStaff_StaffId",
                table: "CategoryStaff",
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
                name: "IX_ReportWork_AttendReportId",
                table: "ReportWork",
                column: "AttendReportId",
                unique: true);

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
                name: "CategoryStaff");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "PackageService");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "ReportWork");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "AttendReport");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Package");

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
