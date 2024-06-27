using APIAmbiental.Data.Contexts;
using APIAmbiental.Data.Repository;
using APIAmbiental.Models;
using APIAmbiental.Services;
using APIAmbiental.ViewModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Configura��o do DB
var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");
builder.Services.AddDbContext<DatabaseContext>(
    opt => opt.UseOracle(connectionString).EnableSensitiveDataLogging(true)
    );
#endregion

#region AutoMapper
// Configura��o do AutoMapper
var mapperConfig = new AutoMapper.MapperConfiguration(c => {
    // Permite que cole��es nulas sejam mapeadas
    c.AllowNullCollections = true;
    // Permite que valores de destino nulos sejam mapeados
    c.AllowNullDestinationValues = true;

    c.CreateMap<ColetaModel, ColetaViewModel>();
    c.CreateMap<ColetaViewModel, ColetaModel>();
});

// Cria o mapper com base na configura��o definida
IMapper mapper = mapperConfig.CreateMapper();

// Registra o IMapper como um servi�o singleton no container de DI do ASP.NET Core
builder.Services.AddSingleton(mapper);

#endregion



#region Depend�ncias 
builder.Services.AddScoped<IColetaRepository, ColetaRepository>();
builder.Services.AddScoped<IColetaService, ColetaService>();
#endregion

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
