using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Model {

class Product {
    [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        [MaxLength(30)]
        public string? Name { get; set; }

        [DisplayName("Product Description")]
        public string? Desceription {get; set;}
}
}