using Net_Core_MVC_Library.Models;
using System.Linq.Expressions;

namespace Net_Core_MVC_Library.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {

        //tum verileri çek
        List<T> GetAll();
        //sadece aktifleri çek
        List<T> GetActives();
        //Id gore cagirma
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        //void Delete(T entity);
        void Delete(int id);
        
        /// <summary>
        /// hard delete yapmak için
        /// </summary>
        /// <param name="id"></param>
        void HardDelete(int id);
        List<T> GetByFilter(Expression<Func<T,bool>>expression);

        int Count();
        bool Any(Expression<Func<T, bool>> expression);

        //Aktif olarak belirli bir sayıya göre çekilmesi // kaç tane istiyoruz ? count ıle gonderılıyor
        List<T> SelectActivesByLimit(int count);
    }
}
