using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_Fundamentals.Data.Entities
{
    /// <summary>
    /// Data Annotations yöntemi ile DB ' de Categories olarak açılan tablo adını Category olarak değiştirdik. Önüne gelen dbo. adlandırmasını da "c" olarak değiştirdik.
    /// </summary>
    
    //[Table(name:"Category",Schema="c")]  
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
