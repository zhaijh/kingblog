using King.Blog.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace King.Blog.HttpApi
{
    //同时添加依赖模块类
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(KingBlogApplicationModule)
        )]
    public class KingBlogHttpApiModule : AbpModule
    {
        
    }
}
