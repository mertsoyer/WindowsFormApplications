using Microsoft.AspNetCore.Mvc;
using Net_Core_MVC_Library.Context;
using Net_Core_MVC_Library.Models;

namespace Net_Core_MVC_Library.Controllers
{
    public class BookTypeController : Controller
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookTypeList()
        {
            var bookTypes = applicationDbContext.BookTypes.ToList();
            return View(bookTypes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            applicationDbContext.BookTypes.Add(bookType);
            applicationDbContext.SaveChanges();

            return RedirectToAction("BookTypeList");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            var kitapGuncelle = applicationDbContext.BookTypes.Find(id);
            return View(kitapGuncelle);
        }

        [HttpPost]
        public IActionResult Update(BookType bookType)
        {
            applicationDbContext.Update(bookType);
            applicationDbContext.SaveChanges();
            return RedirectToAction("BookTypeList");
        }


        public IActionResult Delete(int id)
        {
            var silinecek=applicationDbContext.BookTypes.Find(id);
            applicationDbContext.Remove(silinecek);
            applicationDbContext.SaveChanges();

            return RedirectToAction("BookTypeList");
        }
    }
}
