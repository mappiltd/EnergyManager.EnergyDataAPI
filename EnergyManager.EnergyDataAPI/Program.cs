using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Requests.EnergyData;
using EnergyManager.EnergyDataAPI.DTOs.Requests.TagData;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.DTOs.Responses.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.Repositories.Repos;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using EnergyManager.EnergyDataAPI.Validators.DeviceInformation;
using EnergyManager.EnergyDataAPI.Validators.EnergyData;
using EnergyManager.EnergyDataAPI.Validators.TagData;
using EnergyManager.EnergyDataAPI.Validators.UnitsOfMeasurement;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//Options

//Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"))
        .EnableTokenAcquisitionToCallDownstreamApi()
            .AddMicrosoftGraph(builder.Configuration.GetSection("MicrosoftGraph"))
            .AddInMemoryTokenCaches();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{       
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    //var xmlFilename = "SwaggerDoc.xml";
    //c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));   
});


//Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Repos
builder.Services.AddScoped<IDeviceInformationRepo, DeviceInformationRepo>();
builder.Services.AddScoped<IEnergyDataRepo, EnergyDataRepo>();
builder.Services.AddScoped<ITagDataRepo, TagDataRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Validator Services
builder.Services.AddScoped<IValidator<DeviceInformationRequest>, DeviceInformationRequestValidator>();
builder.Services.AddScoped<IValidator<EnergyDataRequest>, EnergyDataRequestValidator>();
builder.Services.AddScoped<IValidator<TagDataRequest>, TagDataRequestValidator>();
builder.Services.AddScoped<IValidator<UnitsOfMeasurementRequest>, UnitsOfMeasurementRequestValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
