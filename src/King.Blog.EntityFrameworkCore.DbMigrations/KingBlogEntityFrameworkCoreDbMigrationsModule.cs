

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace King.Blog.EntityFrameworkCore.DbMigrations
{
    [DependsOn(
        typeof(KingBlogFrameworkCoreModule)
        )]
    public class KingBlogEntityFrameworkCoreDbMigrationsModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<KingBlogMigrationsDbContext>();
            //context.Services.AddAbpDbContext<MeowvBlogMigrationsDbContext>();
        }
    }
}
