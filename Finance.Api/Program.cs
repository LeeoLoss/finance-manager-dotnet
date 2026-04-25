using Finance.Api.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 1.- Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// 2.- Add Identity services
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<AppDbContext>();

// 3.- Add controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// 4.- Add Swagger/OpenAPI support
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Finance API", Version = "v1" });
    c.CustomSchemaIds(type => type.FullName); // Use full names to avoid conflicts
});

var app = builder.Build();

// 5.- Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Finance API V1");
            c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
        }
    );
}
app.UseHttpsRedirection();

// 6.- Use authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

// 7.- Map controllers
app.MapControllers();   

// 8.- Run the application
app.Run();