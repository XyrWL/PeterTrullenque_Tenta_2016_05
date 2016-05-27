namespace StoreProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductText { get; set; }
        public int ProductNumber { get; set; }
        public double Price { get; set; }
        public int ProductsInStock { get; set; }

        public virtual Store Store { get; set; }
    }
}