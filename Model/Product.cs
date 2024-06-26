using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Products")]
public class Product
{
    [Key]
    [Column("PK_product")]
    public int IdProduct { get; set; }
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }
    [Column("width", TypeName = "decimal(5,2)")]
    public decimal ProductWidth { get; set; }
    
    [Column("height", TypeName = "decimal(5,2)")]
    public decimal ProductHeight { get; set; }
    
    [Column("depth", TypeName = "decimal(5,2)")]
    public decimal ProductDepth { get; set; }

    public IEnumerable<ShoppingCard> ShoppingCards { get; set; }
    public IEnumerable<ProductCategory> ProductCategories { get; set; }
}