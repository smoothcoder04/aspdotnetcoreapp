namespace LanguageFeatures.Models
{
    public class Product
    {
        //assigning a value to a read only property
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }

        public string Category { get; set; } = "Watersports";
        public bool InStock { get; }


        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M,
                Category = "Water Carft"
            };

            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.5M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}