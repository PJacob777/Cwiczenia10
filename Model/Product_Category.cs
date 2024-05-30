using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Products_Categories")]
public class ProductCategory
{   
    [Column("FK_product")]
    [ForeignKey("Products")]
    public int IdProduct { get; set; }
    
    [Column("FK_Category")]
    [ForeignKey("Categories")]
    public int IdCategory { get; set; }
}