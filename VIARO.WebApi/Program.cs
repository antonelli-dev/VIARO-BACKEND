using VIARO.Infrastructure.Extensions;
using VIARO.Application.Extensions;
using VIARO.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using VIARO.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddApplicationPart(VIARO.Presentation.AssemblyReference.Assembly);
builder.Services.AddSwaggerGen();
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddMappings();
builder.Services.AddServices();

builder.Services.AddCors( opt =>
{
    opt.AddPolicy("cors", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MigrateDatabase();
app.UseCors("cors");
app.UseHandleExceptions();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();