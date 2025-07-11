using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Persistence.ProjectDbContext;
using TaskProjectManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSql(builder.Configuration);
builder.Services.RepositoryManage();
builder.Services.RepositoryRegister();
builder.Services.RepositoryBaseInclude();
builder.Services.ServiceBase();
builder.Services.ServiceManage();

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
