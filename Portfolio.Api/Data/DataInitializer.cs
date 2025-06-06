using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Api.Data
{
    public static class DataInitializer
    {
        public static void Initialize(PortfolioDbContext context)
        {
            context.Database.Migrate();

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        Name = "BankAppen",
                        TechStack = "C#, ASP.NET Core, SQL Server",
                        Date = DateTime.Parse("2025-05-01"),
                        Description = "A banking application with secure transactions.",
                        OtherInfo = "GitHub: https://github.com/Nasi-Malek/WebApp.Bank.git | Live Site: https://bankappnasimalek-g7hwe9c8ftbad9f8.swedencentral-01.azurewebsites.net"
                    },
                    new Project
                    {
                        Name = "BeachHotel",
                        TechStack = "ASP.NET Core, C#, Entity Framework Core, SQL Servert",
                        Date = DateTime.Parse("2024-12-15"),
                        Description = "It is a hotel booking management system that supports room reservations, guest services, and payment tracking..",
                        OtherInfo = "Live Demo: https://github.com/Nasi-Malek/BeachHotel_App.git"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}