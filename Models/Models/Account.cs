using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace z9.Models;

public class Account
{
    [Key]
    public int AccountId { get; set; }

    public Role Role { get; set; } = null!;
    public int RoleId { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    [StringLength(80)]
    public string Email { get; set; }
    [StringLength(9)]
    public string Phone { get; set; }
}