using Microsoft.EntityFrameworkCore;
using Net_Core_MVC_Library.Context;
using Net_Core_MVC_Library.Models;
using Net_Core_MVC_Library.RepositoryPattern.Interfaces;
using System.Linq.Expressions;

namespace Net_Core_MVC_Library.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {


        ApplicationDbContext _context;
        DbSet<T> table;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            table = context.Set<T>();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
        public void Add(T entity)
        {
            table.Add(entity);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
          return table.Any(expression);

        }

        public int Count()
        {
          return table.Count();
        }

        public void Delete(int id)
        {
            T entity=GetById(id);
            entity.Status=Enums.DataStatus.Deleted;
            entity.ModifiedDate=DateTime.Now;
            table.Update(entity);
            Save();
        }

        public List<T> GetActives()
        {
            return table.Where(x=>x.Status!=Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
           return table.ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> expression)
        {
          return table.Where(expression).ToList();
        }

        public T GetById(int id)
        {
           return table.Find(id);
        }

        public void HardDelete(int id)
        {
            T entity = GetById(id);
            table.Remove(entity);
            Save();
                
        }

        public List<T> SelectActivesByLimit(int count)
        {
            return table.Where(x=>x.Status!=Enums.DataStatus.Deleted).Take(count).ToList(); 
        }

        public void Update(T entity)
        {
            entity.Status=Enums.DataStatus.Updated;
            entity.ModifiedDate = DateTime.Now;
            table.Update(entity);
            Save();
        }
    }
}
