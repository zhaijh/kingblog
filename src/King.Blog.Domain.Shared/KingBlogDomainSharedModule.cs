
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace King.Blog.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class KingBlogDomainSharedModule : AbpModule
    {
    }
}
