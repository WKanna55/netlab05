using LAB05_WillianK.Application.Services;
using LAB05_WillianK.Application.Services.Base;
using LAB05_WillianK.Domain.Interfaces;
using LAB05_WillianK.Infrastructure.Data;
using LAB05_WillianK.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString(
    "DefaultConnection");
// usar el dbcontext - ojo instalar npgsql.Entity...
builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseNpgsql(connectionString));


// inyectar repositorios
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// inyectar servicios
builder.Services.AddScoped<IAsistenciasService, AsistenciasService>();


builder.Services.AddScoped<IProfesoresService, ProfesoresService>();

// inyectar servicios

// instalacion swagger 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// app construida
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    // uso de swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
        c.RoutePrefix = string.Empty; // ← Esto hace que Swagger esté en "/"
    });

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// para swagger
app.MapControllers();

app.Run();