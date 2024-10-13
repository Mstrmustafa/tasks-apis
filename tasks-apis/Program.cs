using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using tasks_apis.Interfaces;
using tasks_apis.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Register your TaskRepo with the interface
builder.Services.AddScoped<TaskInterfaces, TaskRepo>();

// Register AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Register FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<TaskDTOValidator>();
builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

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

// app.UseHttpsRedirection(); // Commented out as per your previous instructions

app.UseAuthorization();

app.MapControllers();

app.Run();
