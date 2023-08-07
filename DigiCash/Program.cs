﻿using DigiCash.Models;
using DigiCash.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDb"));
builder.Services.AddSingleton<MongoDbServices>();

builder.Services.Configure<ConfigSettings>(builder.Configuration.GetSection("AppConfig"));

builder.Services.AddSingleton<AmountServices>();
builder.Services.AddSingleton<BalanceServices>();
builder.Services.AddSingleton<WalletServices>();
builder.Services.AddSingleton<PostgreSqlServices>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

