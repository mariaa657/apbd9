using System.ComponentModel.DataAnnotations;

namespace z9.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float Depth { get; set; }
    public List<ShoppingCart> ShoppingCarts { get; } = new List<ShoppingCart>();
    public List<ProductsCategories> ProductsCategories { get; set; } = new List<ProductsCategories>();

    public Product(string name, float weight, float width, float height, float depth)
    {
        Name = name;
        Weight = weight;
        Width = width;
        Height = height;
        Depth = depth;
    }
}