using Microsoft.AspNetCore.Mvc;
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

        public IActionResult BookList()
        {
            return View();
        }

        // FirstName LastName ve Id harıcındeki degerler view e null dönmesin diye DTO yontemi ile sadece ılgılı alanları gonderıyoruz.
        public IActionResult Create()
        {
            #region Authors DTO İle Veri Gönderme
            //var liste=applicationDbContext.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new AuthorDto()
            //{
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    Id = x.Id,
            //}).ToList(); 
            #endregion


            #region Authors DTO Kullanmadan Veri Gönderme
            var yazarListe = applicationDbContext.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Id = x.Id,
            }).ToList();
            #endregion
           
            
            
            #region BookType DTO ile Veri Gönderme

            var kitapListe = applicationDbContext.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x => new BookTypeDto()
            {
                Id = x.Id,
                Name = x.BookName
            }).ToList();

            #endregion
            return View((new Book(),yazarListe,kitapListe)); // Kitap, yazarlistesi ve kitaplistesini view e tuple aracılığı ile gönderdik
        }
    }
}
