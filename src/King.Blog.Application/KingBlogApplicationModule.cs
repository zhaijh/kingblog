using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace King.Blog.Application
{
    [DependsOn(       
        typeof(AbpIdentityApplicationModule)
        )]
    public class KingBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    options.AddMaps<KingBlogApplicationModule>();
            //});
        }
    }
}
