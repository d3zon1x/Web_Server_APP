using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Web_Server.Core;
using Web_Server.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = builder.Configuration.GetConnectionString("ConnectionSqlite");

builder.Services.AddDBContext(connection);

builder.Services.AddControllers();

builder.Services.AddRepository();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddValidator();

builder.Services.AddAutoMapper();

builder.Services.AddCustomService();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

var dir = Path.Combine(Directory.GetCurrentDirectory(), "images");
if (!Directory.Exists(dir))
{
    Directory.CreateDirectory(dir);
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(dir),
    RequestPath = "/images"
});

app.UseAuthorization();

app.MapControllers();

app.Run();
