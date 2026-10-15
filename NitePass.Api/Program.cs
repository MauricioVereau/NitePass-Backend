using Dapper;
using NitePass.Application.IService;
using NitePass.Application.Mapping;
using NitePass.Application.Service;
using NitePass.Domain.IRepository;
using NitePass.Infrastructure.Persistence;
using NitePass.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Dapper: permite mapear columnas snake_case (created_at -> CreatedAt)
DefaultTypeMap.MatchNamesWithUnderscores = true;

// ---------- Framework ----------
builder.Services.AddControllers();
builder.Services.AddOpenApi();

// ---------- CORS (Angular) ----------
var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? [];

builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularApp", policy =>
        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod());
});

// ---------- AutoMapper ----------
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

// ---------- Dapper ----------
builder.Services.AddSingleton<DapperContext>();

// ---------- Injección de Depencias Repository y Service ----------
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventService, EventService>();


builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();

var app = builder.Build();

// ---------- Pipeline ----------
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AngularApp");

app.UseAuthorization();

app.MapControllers();

app.Run();