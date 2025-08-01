using CMSRestAPI.Data;
using CMSRestAPI.Interfaces;
using CMSRestAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CmsiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cmsidbcon"));
});

builder.Services.AddDbContext<SmsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("smsdbcon"));
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// Register the email sender service
builder.Services.AddTransient<IEmailSender, EmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

