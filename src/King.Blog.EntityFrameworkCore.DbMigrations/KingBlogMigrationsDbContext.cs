using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace King.Blog.EntityFrameworkCore.DbMigrations
{
    public class KingBlogMigrationsDbContext : AbpDbContext<KingBlogMigrationsDbContext>
    {
        public KingBlogMigrationsDbContext(DbContextOptions<KingBlogMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}
