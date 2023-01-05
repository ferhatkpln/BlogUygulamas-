using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Data.Concrete.EntityFramework.Mappings;
using UdemyBlog.Entities.Concrete;

namespace UdemyBlog.Data.Concrete.EntityFramework.Contexts
{
    public class UdemyBlogContext:DbContext
    {
        public DbSet<Article>? Articles{ get; set; }
        public DbSet<Category>? Categories{ get; set; }
        public DbSet<Comment>? Comments{ get; set; }
        public DbSet<Role>? Roles{ get; set; }
        public DbSet<User>? Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server = FERHATKAPLAN\SQLEXPRESS; database = UdemyBlog;Connect Timeout=30;MultipleActiveResultSets=True ;integrated security = true");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
