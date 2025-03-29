using Microsoft.EntityFrameworkCore;
using soap_service.Data;
using soap_service.Repositories;
using soap_service.Repositories.IRepository;
using soap_service.Services;
using soap_service.Services.IServices;
using SoapCore;
using SoapCore.Extensibility;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITiendaRepository, TiendaRepository>();
builder.Services.AddScoped<ITiendaService, TiendaService>();
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<IFaultExceptionTransformer, CustomFaultExceptionTransformer>();

var app = builder.Build();

app.UseSoapEndpoint<ITiendaService>("/TiendaService.asmx", new SoapEncoderOptions());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();