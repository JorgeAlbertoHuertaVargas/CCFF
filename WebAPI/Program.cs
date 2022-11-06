using CCFF.Datos;
using CCFF.Datos.Functions;
using CCFF.Datos.Interfaces;
using CCFFF.Logica.Interfaces;
using CCFFF.Logica.Servicios;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AplicationDbContext>(opciones => {
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaconexion"));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IAlumnoLogica, AlumnoLogica>();

//Para Json de gran longitud
builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
