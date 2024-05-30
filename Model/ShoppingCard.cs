using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Shopping_Carts")]
public class ShoppingCard
{   [Key]
    [ForeignKey("Products")]
    [Column("FK_product")]
    public int IdProduct { get; set; }
    [Key]
    [ForeignKey("Accounts")]
    [Column("FK_account")]
    public int IdAccount { get; set; }
    [Column("Amount")]
    public int Amount { get; set; }

    public Account Account { get; set; }
    public Product Product { get; set; }
}