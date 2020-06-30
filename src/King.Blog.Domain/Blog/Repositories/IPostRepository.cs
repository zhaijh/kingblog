using Volo.Abp.Domain.Repositories;

namespace King.Blog.Domain.Blog.Repositories
{
    public  interface IPostRepository : IRepository<Post, int>
    {
    }
}
