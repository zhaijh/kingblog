using King.Blog.Domain.Blog;
using King.Blog.Domain.Blog.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.Blog.EntityFrameworkCore.Repositories.Blog
{
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<KingBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<KingBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}