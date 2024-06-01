using Domain.Repositories;
using Domain.Repositories.FirmaRepo;
using Domain.Repositories.SiparisRepo;
using Domain.Repositories.UrunRepo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Persistance.Context;
using Persistance.Repositories.FirmaRepository;
using Persistance.Repositories.SiparisRepository;
using Persistance.Repositories.UrunRepository;
using System;

var builder = WebApplication.CreateBuilder(args);


#region DbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
#endregion

#region Dependency Injection
builder.Services.AddScoped<IUrunCommandRepository, UrunCommandRepository>();
builder.Services.AddScoped<IUrunQueryRepository, UrunQueryRepository>();
builder.Services.AddScoped<IFirmaCommandRepository, FirmaCommandRepository>();
builder.Services.AddScoped<IFirmaQueryRepository, FirmaQueryRepository>();
builder.Services.AddScoped<ISiparisCommandRepository, SiparisCommandRepository>();
builder.Services.AddScoped<ISiparisQueryRepository, SiparisQueryRepository>();

//builder.Services.AddScoped<IUruntService, UrunService>();
//builder.Services.AddScoped<IFirmaService, FirmaService>();
//builder.Services.AddScoped<ISiparisService, SiparisService>();

//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//#endregion

//builder.Services.AddMediatR(typeof(SiparisYonetim.AssemblyReference).Assembly);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
