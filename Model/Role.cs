using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cwiczenia10.Model;
[Table("Roles")]
public class Role
{
    [Key]
    [Column("PK_rol")]
    public int IdRole { get; set; }
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }

    public IEnumerable<Account> Accounts { get; set; }
}