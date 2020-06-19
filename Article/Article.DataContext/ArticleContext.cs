using Article.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Article.DataContext
{
    public class ArticleContext : DbContext
    {
        public DbSet<Entities.Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ArticleContext"].ConnectionString);
            //optionsBuilder.UseSqlServer("Server=DESKTOP-LKU4G8U;Database=Articles;uid=sa;pwd=75433uo*");
        }
    }
}