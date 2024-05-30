using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia10.Model;
[Table("Categories")]
public class Category
{
    [Key]
    [Column("PK_categoru")]
    public int IdCategory { get; set; }
    [MaxLength(100)]
    [Column("Name")]
    public string Name { get; set; }

    public IEnumerable<ProductCategory> ProductCategories { get; set; }
}