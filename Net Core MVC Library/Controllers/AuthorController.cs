using Microsoft.AspNetCore.Mvc;
using Net_Core_MVC_Library.Context;
using Net_Core_MVC_Library.Models;

namespace Net_Core_MVC_Library.Controllers
{
    public class AuthorController : Controller
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        //ApplicationDbContext applicationDbContext;


        //public AuthorController(ApplicationDbContext _applicationDbContext)
        //{
        //    applicationDbContext = _applicationDbContext;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuthorList()
        {
            //var yazarlar= applicationDbContext.Authors.ToList();

            // verileri databasen silmeyip data status u deleted harıcı olan verileri gosterıyoruz.
            var yazarlar = applicationDbContext.Authors.Where(a => a.Status != Enums.DataStatus.Deleted).ToList(); 
            return View(yazarlar);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {

            applicationDbContext.Authors.Add(author); ;
            applicationDbContext.SaveChanges();
            return RedirectToAction("AuthorList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
           var author= applicationDbContext.Authors.Find(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Update(Author author)
        {
            author.Status = Enums.DataStatus.Updated;
            author.ModifiedDate = DateTime.Now;
            applicationDbContext.Authors.Update(author);
            applicationDbContext.SaveChanges();
            return RedirectToAction("AuthorList");
        }


        //Soft Delete 
        public IActionResult Delete(int id)
        {
            /*var silinecek*/ Author author = applicationDbContext.Authors.Find(id);
            author.Status=Enums.DataStatus.Deleted;
            author.ModifiedDate= DateTime.Now;
            applicationDbContext.Authors.Update(author);
            applicationDbContext.SaveChanges();

            return RedirectToAction("AuthorList");
        }
    }
}
