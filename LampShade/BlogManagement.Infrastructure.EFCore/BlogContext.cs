using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using BlogManagement.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagement.Infrastructure.EFCore
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
