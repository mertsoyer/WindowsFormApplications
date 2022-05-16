using Microsoft.EntityFrameworkCore;
using Net_Core_Fundamentals.Data.Entities;

namespace Net_Core_Fundamentals.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<SaleHistory> SaleHistories { get; set; } = default!;
        public DbSet<ProductDetail> ProductDetails { get; set; } = default!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!; // Employee klası içerisinde yazdığımız FullTimeEmploye ve ParttimeEmoloyee i DB ye aktırıyoruz. Aktardığımız zaman otomatik Employees tablosu içerisinde FullTime ve PartTime olarak oluşacak ayrı tablolar oluşturmayacak. "Table per Hierarchy" 
        //Eğer bunu ayrı tablolar olarak oluşturmak istiyorsak modelbuilder üzerinden ToTable ile bu tabloları vermemiz gerekir.
        public DbSet<FullTimeEmployee> FullTimeEmployees{ get; set; } = default!;
        public DbSet<PartTimeEmployee>PartTimeEmployees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SP14MERTS;Database=Fundamentals;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Table Per Type -> Employee Classının içinde yazılan classların ayrı bir tablo olarak ayrıştırılma işlemi
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");

            #endregion


            //---------------------------------------------------RELATIONS-----------------------------------------------------

            #region Bire çok ilişki
            //Product uzerinden ilişki kurulabilir bir product un birden cok salehistorisi olur bir saleshistorinin bir product ı olur ve product ıd foreing keydir.
            modelBuilder.Entity<Product>().HasMany(x => x.SaleHistories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);

            //salehistory uzerinden yukardakı iliskinin tersten yapılması
            //modelBuilder.Entity<SaleHistory>().HasOne(x => x.Product).WithMany(x => x.SaleHistories).HasForeignKey(x => x.ProductId);

            #endregion

            #region Bire bir İlişki
            //product ile product detail in arasında bire bir bir ilişki var ve foreign key productdetail sayfasındaki productId
            modelBuilder.Entity<Product>().HasOne(x => x.ProductDetail).WithOne(x => x.Product).HasForeignKey<ProductDetail>(x => x.ProductId);
            #endregion

            #region Çoka çok - Many to Many
            // Çoka çok ilişkiyi kurmak için oluşturulan ara tablo olan productcategories tablosu üzerinden ilgili ilişkiler ve foreign key ler oluşturuldu
            modelBuilder.Entity<Product>().HasMany(x => x.ProductCategories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<Category>().HasMany(x => x.ProductCategories).WithOne(x => x.Category).HasForeignKey(x => x.ProductId);


            //Primary Key : Product Id ve Category Id de mükerrer / tekrarlı kayıt olmaması adına bu alanları PrimaryKey yaptık.
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId });
            #endregion

            modelBuilder.Entity<Category>().ToTable(/*name:*/"Category",/*schema:*/"db");

            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name").HasMaxLength(100); // Product içindeki Name için tek satırda birden çok validasyon koyabiliriz veya tek tek ayrı ayrı da yazabiliriz.


            //Primary Key
            modelBuilder.Entity<Customer>().HasKey(x => x.Number); // Number Primary Key oldu

            // modelBuilder.Entity<Customer>().HasKey(x => new {x.Number,x.Name}); // Number ve aynı anda Name Primary Key oldu


            #region Default Değer Verme
            modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql(" 'ürün bilgisi girilmemiş' "); // boş olan name bilgisine bu yazılacak
            modelBuilder.Entity<Product>().Property(x => x.CreatedDate).HasDefaultValueSql("getDate()"); // created date girilmemişse o anının tarihini yazacak
            #endregion

            #region IsUnique // aynı isimde Tekrarlı Kayıt engelleme 

            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);

            #endregion


        }
    }
}
