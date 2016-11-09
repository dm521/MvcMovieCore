using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Model
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options):base(options)
        {

        }

        public DbSet<Article> Articles {get; set;}

        public DbSet<Author> Authors {get;set;}
    }
}