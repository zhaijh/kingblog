using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace King.Blog.Domain
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class KingBlogDomainModule : AbpModule
    {
    }
}
