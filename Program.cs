using modulum_api.Data;
using modulum_api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.Extensions.Options;
using modulum_api.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Configuration.SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true)
    .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<IdentityDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddIdentityApiEndpoints<IdentityUser>().
    AddRoles<IdentityRole>().
    AddEntityFrameworkStores<IdentityDbContext>();

builder.Services.AddScoped<IRoleService, RoleService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.AddSecurityDefinition("oauth2", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    option.SwaggerDoc
    ("v1",
        new OpenApiInfo
        {
            Title = "Documentação Swagger API Modulum",
            Version = "v1",
            Description = "Essa e a documentação swagger da API Modulum utilizando swagger UI com interface do ReDoc",
            Contact = new OpenApiContact
            {
                Name = "Rodrigo Cotting Fontes",
                Email = "cottingfontes@hotmail.com"
            }
        }
    );
    option.OperationFilter<SecurityRequirementsOperationFilter>();
    option.OperationFilter<AddRequiredHeaderParameter>();
});

builder.Services.AddCors(option => option.AddPolicy("wasm",
    policy => policy.WithOrigins(builder.Configuration["BackendUrl"] ?? "",
    builder.Configuration["FrontendUrl"] ?? "")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    ));


var app = builder.Build();

app.MapIdentityApi<IdentityUser>();

app.UseCors("wasm");
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "API Modulum");
});
//}
app.UseReDoc(options =>
{
    options.DocumentTitle = "Swagger API Modulum Documentacao";
    options.SpecUrl = "/swagger/v1/swagger.json";
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
