using Microsoft.EntityFrameworkCore;
using Net_Core_MVC_BookStore.Models;

namespace Net_Core_MVC_BookStore.Context
{
    public class ApplicationDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SP14MERTS;Database=BookStore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region FLUENT API 
            //ID alanı BaseEntity den tüm classlara miras verdiğimiz için gidip data annotation yontemi ile  [NotMapped] olarak yanı database de OrderDetail altında ID olmasın ı ilgili entity altında yapamıyoruz. Eğer oyle olursa tum miras aldıgı entityleri etkileyecegi icin buradan kendımız istediğimiz  tablo adı ıle Ignor dıyerek ıslem yapıyoruz. Bu sekılde Fluent API ıslemı yapmıs olduk.

            // orderdetail tablosundaki ıd alanı database e aktarılmasın
            modelBuilder.Entity<OrderDetail>().Ignore("Id");


            // FLUENT API ile HasKey diyerek  OrderDetail içindeki OrderId ve ProductId nin primary key oldugunu ifade ettik.
            //bu alanların primary key olmasını sağladık.
            modelBuilder.Entity<OrderDetail>().HasKey("OrderId", "ProductId");
            #endregion

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
