using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Products_Categories")]
public class ProductCategory
{   [Key]
    [Column("FK_product")]
    [ForeignKey("Products")]
    public int IdProduct { get; set; }
    [Key]
    [Column("FK_Category")]
    [ForeignKey("Categories")]
    public int IdCategory { get; set; }

    public Product Product { get; set; }
    public Category Category { get; set; }
    
}