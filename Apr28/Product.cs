using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFC2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }

    }
}
