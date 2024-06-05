using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace z9.Models;

public class ShoppingCart
{
    [Key]
    public int AccountId { get; set; }

    public Product Product { get; set; } = null!;
    public int ProductId { get; set; }
    public int Amount { get; set; }
}