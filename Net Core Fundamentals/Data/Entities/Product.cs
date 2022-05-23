namespace Net_Core_Fundamentals.Data.Entities
{
    public class Product
    {

        //public Product()
        //{
        //    CreatedDate = DateTime.Now;
        //}

        public int Id { get; set; }
        
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value==null)
                {
                    value = "isim boş olamaz";
                }

               _name = value;

            }
        }


        public decimal Price { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public List<SaleHistory> SaleHistories { get; set; }
        /// <summary>
        /// Category ve Product tablarıları arasındaki çoka çok ilişkiyi kurmak için ProductCategory adındaki ara tablo ile ilgili ilişkiyi kuruyoruz
        /// </summary>
        public List<ProductCategory>ProductCategories { get; set; } = default!;
        public ProductDetail ProductDetail { get; set; } = default!;

    }
}
