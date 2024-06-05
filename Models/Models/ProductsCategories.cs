using System.ComponentModel.DataAnnotations;

namespace z9.Models;

public class ProductsCategories
{
    [Key]
    public int ProductCategory { get; set; }
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public Product Product { get; set; } = null!;
    public Category Category { get; set; } = null!;

    public ProductsCategories(int productId, int categoryId)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }
}