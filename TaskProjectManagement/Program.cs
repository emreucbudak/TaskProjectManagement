using Microsoft.EntityFrameworkCore;
using TaskProjectManagement.Persistence.ProjectDbContext;
using TaskProjectManagement.Services;
using Serilog;
using TaskProjectManagement.ErrorManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
var logFilePath = Path.Combine(desktopPath, "managementLog.txt");
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()                
    .WriteTo.Console()                   
    .WriteTo.File(
        path: logFilePath,
        rollingInterval: RollingInterval.Day,  
        retainedFileCountLimit: 365               
    )
    .CreateLogger();

builder.Host.UseSerilog();
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
var logger = app.Services.GetRequiredService<ILogger<Program>>();
app.AppErr(logger);

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
