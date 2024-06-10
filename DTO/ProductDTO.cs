namespace Cwiczenia10.DTO;

public record ProductDTO
{
    public string Name { get; set; }
    public decimal Weight { get; set; }
    public decimal Height { get; set; }
    public decimal Depth { get; set; }
    public List<int> ListOfCategories { get; set; }
}

