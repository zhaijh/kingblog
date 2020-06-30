using King.Blog.Domain.Blog;
using King.Blog.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// FriendLinkRepository
    /// </summary>
    public class FriendLinkRepository : EfCoreRepository<KingBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<KingBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}