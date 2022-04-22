using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorAwsome.Shared.Models
{
    public  class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string? Name { get; set; } 
        [Required]
        public int Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int Sold { get; set; } 
    }
}
