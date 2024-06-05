using System.ComponentModel.DataAnnotations;

namespace z9.Models;

public class Role
{
    [Key]
    public int RoleId { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    public List<Account> Roles { get; } = new List<Account>();
}