using EfCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Query.Data.Configurations
{
    /// <summary>
    /// DbContext te tek tek tüm entityler için Fluent API işlemleri yapmaktansa tek tek entityler için classlar oluşturup gerekli configuration işlemlerini yapıyoruz. 
    /// </summary>
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            //Tittle
            builder.Property(x => x.Tittle).IsRequired();
            builder.Property(x => x.Tittle).HasMaxLength(300);


            //URL
            builder.Property(x => x.Url).HasMaxLength(300);


        }
    }
}
