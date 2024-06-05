using System.ComponentModel.DataAnnotations;

namespace z9.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    public List<ProductsCategories> Categories { get; } = new List<ProductsCategories>();

    public Category(int categoryId, string name)
    {
        CategoryId = categoryId;
        Name = name;
    }
}