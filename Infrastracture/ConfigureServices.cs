using Application.Interfaces;
using Application.IRepository;
using Application.IServices;
using Application.IUnitOfWorks;
using Application.Services;
using AutoMapper;
using Infrastracture.Repositories;
using Infrastructure.Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Infrastructure
{

    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //database setup

            services.AddScoped<IRequestService, RequestService>();
   




            string? con = configuration.GetConnectionString("DefaultSQLConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con));


            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            //dependency injection contanaire
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
