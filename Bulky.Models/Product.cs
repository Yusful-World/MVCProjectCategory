using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Book Title")]
        public string? Title { get; set; }

        [DisplayName("Book Description")]
        public string? Description { get; set; }
        
        [Required]
        public string ISBN { get; set; }
        
        [Required]
        public string Author { get; set; }

        [DisplayName("Book Price")]
        [Range(1, 1000)]
        public double? BookPrice { get; set; }

        [DisplayName("Price for 1-50")]
        [Range(1, 1000)]
        public double? Price { get; set; }

        [DisplayName("Price for 50+")]
        [Range(1, 1000)]
        public double? Price50 { get; set; }

        [DisplayName("Price for 100+")]
        [Range(1, 1000)]
        public double? Price100 { get; set; }
    }
}
