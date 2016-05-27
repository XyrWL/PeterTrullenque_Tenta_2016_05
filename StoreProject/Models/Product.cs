using System.ComponentModel.DataAnnotations;
using StoreProject.Validation;

namespace StoreProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string ProductText { get; set; }

        [Required, ProductNumberFormat]
        public string ProductNumber { get; set; }

        [Required, Range(0,100000)]
        public double Price { get; set; }

        [Required, Range(0,1000)]
        public int ProductsInStock { get; set; }

        public virtual Store Store { get; set; }
    }
}