﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Required]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }

        //[DisplayName("Product Description")]
        //public string? Description {get; set;}
        
        //[DisplayName("Book Price")]
        //public double? Price { get; set; }
    }
}
