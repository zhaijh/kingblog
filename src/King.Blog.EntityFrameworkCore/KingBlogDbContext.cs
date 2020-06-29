using King.Blog.Domain.Blog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.Blog.EntityFrameworkCore
{
    [ConnectionStringName("SqlServer")]
    public class KingBlogDbContext:AbpDbContext<KingBlogDbContext>
    {
        public KingBlogDbContext(DbContextOptions<KingBlogDbContext> options) : base(options) 
        { 
        }      
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }  
        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<FriendLink> FriendLinks { get; set; }
    }
}
