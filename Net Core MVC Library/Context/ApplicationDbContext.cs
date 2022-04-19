using Microsoft.EntityFrameworkCore;
using Net_Core_MVC_Library.Models;

namespace Net_Core_MVC_Library.Context
{
    public class ApplicationDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SP14MERTS;Database=Library;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API OPERASYON TIPLERI

            modelBuilder.Entity<Operations>().Ignore(x => x.Id); //Database de bu kolonu yaratma
            modelBuilder.Entity<Operations>().HasKey(x => new{ x.StudentId, x.BookId}); //Primary key 

            //modelBuilder.Entity<Operations>().ToTable("Operasyonlar"); //Tablo adını değiştirme

            #region HasColumnName Kolon Adını Değiştiröe
            //HasColumnName
            //Author tablosundaki FirstName kolon adını değiştirme
            //modelBuilder.Entity<Author>().Property(x => x.FirstName).HasColumnName("İsim"); 
            #endregion

            #region FLUENT API 
            //ID alanı BaseEntity den tüm classlara miras verdiğimiz için gidip data annotation yontemi ile  [NotMapped] olarak yanı database de OrderDetail altında ID olmasın ı ilgili entity altında yapamıyoruz. Eğer oyle olursa tum miras aldıgı entityleri etkileyecegi icin buradan kendımız istediğimiz  tablo adı ıle Ignor dıyerek ıslem yapıyoruz. Bu sekılde Fluent API ıslemı yapmıs olduk.

            // orderdetail tablosundaki ıd alanı database e aktarılmasın
            modelBuilder.Entity<Operations>().Ignore("Id");


            // FLUENT API ile HasKey diyerek  OrderDetail içindeki OrderId ve ProductId nin primary key oldugunu ifade ettik.
            //bu alanların primary key olmasını sağladık.
            modelBuilder.Entity<Operations>().HasKey("StudentId", "BookId");
            #endregion

            #region IsRequired İlgili Alanı Zorunlu Yapma

            //Student

            //Zorunlu alan yapma -> IsRequired
            modelBuilder.Entity<Student>().Property(x => x.FirstName).IsRequired();
            #endregion

            #region HasColumnType - Kolon Tipini Değiştirme
            //HasColumnType kolon tipini değiştirme  -> kolon tipi varchar30 olarak degıstırdık 
            modelBuilder.Entity<Student>().Property(x => x.FirstName).HasColumnType("varchar(30)");
            #endregion

            #region Bir alan için tek seferde iki kıstas verme 
            modelBuilder.Entity<Student>().Property(x => x.FirstName).IsRequired().HasColumnName("Öğrenciler");

            //Bire bir tablo ilişkisini kurma
            modelBuilder.Entity<Student>().HasOne<StudentDetail>(s => s.StudentDetail).WithOne(x => x.Student).HasForeignKey<StudentDetail>(sd => sd.StudentId);
            #endregion

            //Book
            //kitap ile yazar arasındaki bire çok ilişki
            modelBuilder.Entity<Book>().HasOne(b=>b.Author).WithMany(a=>a.Books).HasForeignKey(b=>b.AuthorId);
            modelBuilder.Entity<Book>().HasOne(b=>b.BookType).WithMany(a=>a.Books).HasForeignKey(b=>b.BookTypeId);

            //Operation çoka çok ilişki student ve book arasında

            modelBuilder.Entity<Operations>().HasOne(o => o.Book).WithMany(b => b.Operations).HasForeignKey(o => o.BookId);
            modelBuilder.Entity<Operations>().HasOne(o => o.Student).WithMany(b => b.Operations).HasForeignKey(o => o.StudentId);

        }

        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<BookType> BookTypes { get; set; } = default!;
        public DbSet<Operations> Operations{ get; set; } = default!;
        public DbSet<Author> Authors{ get; set; } = default!;


    }
}
