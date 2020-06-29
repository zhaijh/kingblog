using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace King.Blog.EntityFrameworkCore.DbMigrations
{
    /// <summary>
    ///KingBlogMigrationsDbContextFactory 类主要是用来使用Code-First命令的(Add-Migration 和 Update-Database ...)
    /// </summary>
    public class KingBlogMigrationsDbContextFactory : IDesignTimeDbContextFactory<KingBlogMigrationsDbContext>
    {
        public KingBlogMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<KingBlogMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new KingBlogMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
