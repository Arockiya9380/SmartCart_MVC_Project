using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SmartCart_MVC_Project.Models.ViewModels;

public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }
    }
