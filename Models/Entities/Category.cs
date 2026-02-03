using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCart_MVC_Project.Models.Entities
{
    public class Category
    {
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; set; }

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string CategoryName { get; set; } = string.Empty;

    [Column(TypeName = "text")] // ✅ FIX
    public string? Description { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
