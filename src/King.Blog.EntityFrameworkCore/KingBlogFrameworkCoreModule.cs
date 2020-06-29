using King.Blog.Domain;
using King.Blog.Domain.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace King.Blog.EntityFrameworkCore
{
    [DependsOn(
        typeof(KingBlogDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreMySQLModule),
        typeof(AbpEntityFrameworkCorePostgreSqlModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),
        typeof(AbpEntityFrameworkCoreSqliteModule)
        )]
    public class KingBlogFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<KingBlogDbContext>(options=> {
                options.AddDefaultRepositories(includeAllEntities: false);
            });
            Configure<AbpDbContextOptions>(options=> {
                switch (AppSettings.EnableDb) {
                    case "MySQL":
                        options.UseMySQL();
                        break;
                    case "SqlServer":
                        options.UseSqlServer();
                        break;
                    case "PostgreSql":
                        options.UseNpgsql();
                        break;
                    case "Sqlite":
                        options.UseSqlite();
                        break;
                    default:
                        options.UseMySQL();
                        break;
                }
            });
        }
    }
}
