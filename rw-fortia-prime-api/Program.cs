using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using rw_fortia_prime_api.Entities;
using rw_fortia_prime_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    //options.SwaggerDoc("v1", new OpenApiInfo
    //{
    //    Title = "RW Fortia Prime API",
    //    Version = "v0.0.1",
    //    Description = "API RW Fortia Prime"
    //});

    //options.AddSecurityDefinition("ApiKey", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    //{
    //    Description = "API Key requerida en el header: x-api-key",
    //    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
    //    Name = "x-api-key",
    //    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
    //});

    //options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    //{
    //    {
    //        new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    //        {
    //            Reference = new Microsoft.OpenApi.Models.OpenApiReference
    //            {
    //                Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
    //                Id = "ApiKey"
    //            }
    //        },
    //        new string[] {}
    //    }
    //});
});

// DB
builder.Services.AddDbContext<FortiaDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FortiaConnection")
    )
);

// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Services
builder.Services.AddScoped<CatalogosService>();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "RW Fortia Prime API v0.0.1");
        c.RoutePrefix = ""; // 👈 CLAVE: Swagger en /
    });
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();