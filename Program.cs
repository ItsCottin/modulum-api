using Microsoft.AspNetCore.Authentication.JwtBearer;
using modulum_api.Data;
using modulum_api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.Extensions.Options;
using modulum_api.Filters;
using modulum_api.Model;
using modulum_api.Configuracao;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Configuration.SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true)
    .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<modulum_api.Data.DbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentityApiEndpoints<IdentityUser>(options =>
{
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@. "; // Permitir @ e ponto
}) // Achei - esse cara é o responsável por carregar endpoints do Framework Identity não listados no Controllers
    .AddRoles<IdentityRole>()
    .AddSignInManager<CustomSignInManager>()
    .AddEntityFrameworkStores<modulum_api.Data.DbContext>();

builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IAccountService, AccountService>();

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

//builder.Services.AddCors(option => option.AddPolicy("wasm",
//    policy => policy.WithOrigins(builder.Configuration["BackendUrl"] ?? "",
//    builder.Configuration["FrontendUrl"] ?? "")
//    .AllowAnyMethod()
//    .AllowAnyHeader()
//    .AllowCredentials()
//    ));

// Provisório - Permite acionamento da API de qualquer origem
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Permitir qualquer origem
              .AllowAnyMethod()  // Permitir qualquer método (GET, POST, etc.)
              .AllowAnyHeader(); // Permitir qualquer cabeçalho
    });
});


var app = builder.Build();

app.MapIdentityApi<IdentityUser>();

//app.UseCors("wasm");

// Provisório - Permite acionamento da API de qualquer origem
app.UseCors("AllowAll");


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
