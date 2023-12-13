using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Contracts.Identity;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Application.Models.Identity;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using StudentHouseMembershipCart.Identity.DbContext;
using StudentHouseMembershipCart.Identity.Repositories;
using StudentHouseMembershipCart.Identity.Services;
using System.Text;

namespace StudentHouseMembershipCart.Identity
{
    public static class IdenityServicesRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.AddDbContext<StudentHouseMembershipCartDatabaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("StudentHouseMembershipCart"));
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<StudentHouseMembershipCartDatabaseContext>());
            services.AddScoped<IApplicationDbContext, StudentHouseMembershipCartDatabaseContext>();


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<StudentHouseMembershipCartDatabaseContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o =>
            {
                o.SaveToken = true;
                o.RequireHttpsMetadata = false;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                };
            });

            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
                {
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    BearerFormat = "JwtSettings",
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Name = "Authorization",
                    Description = "Insert JWT Token"
                });
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    //.AddAuthenticationSchemes(
                    //    CookieAuthenticationDefaults.AuthenticationScheme‌​,
                    //    GoogleDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();

                options.AddPolicy("Admin", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Admin")
                .Build());
                options.AddPolicy("Staff", policy => policy
                        .Combine(options.DefaultPolicy)
                        .RequireRole("Staff")
                        .Build());
                options.AddPolicy("User", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("User")
                   .Build());
                options.AddPolicy("AdminOrStaff", policy => policy
            .Combine(options.DefaultPolicy)
            .RequireRole("Admin", "Staff")
            .Build());

            });


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}