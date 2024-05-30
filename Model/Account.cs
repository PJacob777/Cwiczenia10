using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Accounts")]
public class Account
{
    [Key]
    [Column("PK_acount")]
    public int IdAccount { get; set; }
    
    [Column("FK_roles")]
    [ForeignKey("Roles")]
    public int IdRole  { get; set; }
    [MaxLength(50)]
    [Column("first_name")]
    public string FirstName { get; set; }
    [MaxLength(50)]
    [Column("last_name")] 
    public string LastName { get; set; }
    [MaxLength(80)]
    [Column("email")]
    public string Email { get; set; }
    [MaxLength(9)]
    [Column("phone")]
    public string? Phone { get; set; }

    public Role role { get; set; }

    public IEnumerable<ShoppingCard> ShoppingCards;
}