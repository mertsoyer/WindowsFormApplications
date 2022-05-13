using Microsoft.AspNetCore.Mvc;
using Net_Core_MVC_Library.Context;
using Net_Core_MVC_Library.Models;
using Net_Core_MVC_Library.RepositoryPattern.Interfaces;

namespace Net_Core_MVC_Library.Controllers
{
    public class BookTypeController : Controller
    {
        ApplicationDbContext applicationDbContext = new ApplicationDbContext();

        private readonly IRepository<BookType> _bookTypeRepository;

        public BookTypeController(IRepository<BookType> bookTypeRepository)
        {
            this._bookTypeRepository = bookTypeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookTypeList()
        {

            var bookTypes = _bookTypeRepository.GetAll();
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
            _bookTypeRepository.Add(bookType);
            //applicationDbContext.BookTypes.Add(bookType);
            //applicationDbContext.SaveChanges();

            return RedirectToAction("BookTypeList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bookType = _bookTypeRepository.GetById(id);
            return View(bookType);
        }


        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _bookTypeRepository.Update(bookType);
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

            _bookTypeRepository.Delete(id);
            //var silinecek = applicationDbContext.BookTypes.Find(id);
            //applicationDbContext.Remove(silinecek);
            //applicationDbContext.SaveChanges();

            return RedirectToAction("BookTypeList");
        }
    }
}
