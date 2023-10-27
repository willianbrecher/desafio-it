using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;

namespace DesafioIt.EntityFramework
{
	public class EntityFrameworkDesafioItContextFactory : IDesignTimeDbContextFactory<DesafioItContext>
    {
        public DesafioItContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = GetConfigurationDirectoryRoot();

            DbContextOptionsBuilder<DesafioItContext> builder = new();
            string connectionString = configuration["ConnectionStrings:SQLDatabase"];
            builder.UseNpgsql(connectionString, x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, "application"));
            return new DesafioItContext(builder.Options);
        }

        public static IConfigurationRoot GetConfigurationDirectoryRoot()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return configuration;
        }
    }
}

