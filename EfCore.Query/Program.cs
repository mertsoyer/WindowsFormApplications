// See https://aka.ms/new-console-template for more information
using EfCore.Query.Data.Context;
using EfCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;

//Console.WriteLine("Hello, World!");

var context = new BlogContext();
//context.Add(new Blog
//{
//    Tittle = "Blog-1",
//    Url = "mertsoyer.com/blog1"
//});

//context.Add(new Blog
//{
//    Tittle = "Blog-2",
//    Url = "mertsoyer.com/blog2"
//});

//context.Add(new Blog
//{
//    Tittle = "Blog-3",
//    Url = "mertsoyer.com/blog3"
//});

//context.SaveChanges();


//IEnumerable && IQuaeryable


//var blogs = context.Blogs.ToList();


//foreach (var blog in blogs)
//{
//    Console.WriteLine(blog.Tittle);
//}

//var updatedBlog = context.Blogs./*AsNoTracking().*/SingleOrDefault(x => x.Id == 1);

//updatedBlog.Tittle = "Güncellendi";
//context.SaveChanges();

var blogs = context.Blogs.Include(x=>x.Comments/*.Where(x=>x.Content.Contains("Yorum1"))*/).ToList();

foreach (var blog in blogs)
{
    Console.WriteLine($"{blog.Tittle} blogun yorumları");
    foreach (var comment in blog.Comments)
    {
        Console.WriteLine($"{ comment.Content} yorumlar");
    }
}