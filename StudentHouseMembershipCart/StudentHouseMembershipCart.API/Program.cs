
using MediatR;
using StudentHouseMembershipCart.API.Middleware;
using StudentHouseMembershipCart.API.Service;
using StudentHouseMembershipCart.Application;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Identity;
using StudentHouseMembershipCart.Infrastucture;
using StudentHouseMembershipCart.Service.VnPay.Config;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Register configuration 
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                      });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
        .AddJsonOptions(options => {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
builder.Services.Configure<VnpayConfig>(
    builder.Configuration.GetSection(VnpayConfig.ConfigName));
// Add Database Service

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment()) {
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
