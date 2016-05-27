using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreProject.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}