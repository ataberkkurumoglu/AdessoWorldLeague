using Business.Abstracts;
using Business.Concretes;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Abstracts;
using Repositories.Concrete;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<DbContext, EfDbContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof(EfGenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IDrawResultRepository, DrawResultRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IDrawResultService, DrawResultService>();
builder.Services.AddScoped<ITeamService, TeamService>();

builder.Services.AddControllers()
            .AddJsonOptions(o => o.JsonSerializerOptions
                .ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();

builder.Services.AddDbContext<EfDbContext>
(o => o.UseInMemoryDatabase("AdessoDB"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
