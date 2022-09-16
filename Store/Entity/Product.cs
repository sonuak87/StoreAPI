namespace Store.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; }= string.Empty;
        public int BrandId { get; set; } = 0;
        public string BrandName { get; set; } = string.Empty;
        public  int Category { get; set; } = 0;
        public int StockQty { get; set; } = 100;

    }
}
