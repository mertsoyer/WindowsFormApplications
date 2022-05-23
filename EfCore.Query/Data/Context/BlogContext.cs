using EfCore.Query.Data.Configurations;
using EfCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Query.Data.Context
{
    public class BlogContext:DbContext
    {

        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=SP14MERTS;Database=Blog_Context;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new BlogConfiguration()); // Blog configuration class i içerisinde oluşturduğumuz Fluent API işlemlerini buraya entegre etmiş olduk
            //base.OnModelCreating(modelBuilder);

            //CommentConfiguration
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }
    }
}
