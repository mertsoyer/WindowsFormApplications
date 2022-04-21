using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Net_Core_MVC_Library.Context;
using Net_Core_MVC_Library.DTO;
using Net_Core_MVC_Library.Models;

namespace Net_Core_MVC_Library.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext applicationDbContext=new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Burada Books entitysi ile ilişkili olan Author ve BookType tablolarını Books tablosuna Include ıle baglamış ve listelemiş olduk. Yanı bir tablodan iki farklı tabloya JOIN yaptık.
        /// </summary>
        /// <returns></returns>
        public IActionResult BookList()

        {
            #region INCLUDE ile ilişkili iki tabloyu birbirine bağlama + Select ile bağlanan tablolar arasında istenilen veriyi seçme

            //Burada Books entitysi ile ilişkili olan Author ve BookType tablolarını Books tablosuna Include ıle baglamış ve listelemiş olduk. Yanı bir tablodan iki farklı tabloya JOIN yaptık.
            var books = applicationDbContext.Books.Where(x => x.Status != Enums.DataStatus.Deleted).Include(x => x.Author).Include(z => z.BookType).Select(x => new
            {
                Name = x.Name,
                AuthorFirstName = x.Author.FirstName,
                BookTypeName = x.BookType.BookName

            }).ToList();

            #region Yukarıdaki aynı işlem için Include uygulayıp SELECT ile istenilen verilere filtre koymadan ve WHERE koşulu koymadan çekme

            var books2= applicationDbContext.Books.Include(x=>x.Author).Include(x=>x.BookType).ToList();

            #endregion


            #endregion

            #region ThenInclude ile tablolar arası geçiş
            //İlk tablonun üzerinden bir başka tabloya geçmek için ThenInclude kullanıyoruz. Burada Books tablosundan Author tablosuna geçiş yaptık
            //var books = applicationDbContext.Books.Where(x => x.Status != Enums.DataStatus.Deleted).Include(x => x.Author).ThenInclude(z => z.LastName).ToList();

            #endregion
            return View(books);
        }

        // FirstName LastName ve Id harıcındeki degerler view e null dönmesin diye DTO yontemi ile sadece ılgılı alanları gonderıyoruz.
       [HttpGet]
        public IActionResult Create()
        {
            #region Authors DTO İle Veri Gönderme
            var authors = applicationDbContext.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new AuthorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id,
            }).ToList();
            #endregion


            #region Authors DTO Kullanmadan Veri Gönderme
            //var yazarListe = applicationDbContext.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new
            //{
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    Id = x.Id,
            //}).ToList();
            #endregion



            #region BookType DTO ile Veri Gönderme

           var bookTypes = applicationDbContext.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
            {
                Id = x.Id,
                Name = x.BookName
            }).ToList();

            #endregion
            return View((new Book(), authors, bookTypes)); // Kitap, yazarlistesi ve kitaplistesini view e tuple aracılığı ile gönderdik
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            applicationDbContext.Books.Add(book);
            applicationDbContext.SaveChanges();

            return RedirectToAction("BookList");
        }
    }
}
