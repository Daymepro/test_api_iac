using Acme_Corp.Models.Database;
using Acme_Corp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration;

//ConfigurationManager StaticConfig = builder.Configuration;

//var connect = Configuration.GetConnectionString("DBString");


builder.Services.AddDbContext<AppDb>(Options => Options.UseSqlServer(Configuration.GetConnectionString("DBString")), ServiceLifetime.Transient);
builder.Services.AddEntityFrameworkSqlServer();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ApiKeyMiddleware>();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();

