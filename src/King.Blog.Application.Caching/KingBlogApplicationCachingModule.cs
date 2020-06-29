using King.Blog.Domain;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace King.Blog.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(KingBlogDomainModule)
        )]
    public class KingBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
