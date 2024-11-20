namespace MinimalApiEfCore.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime ExpirationDate { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int StatusProductId { get; set; }
    public StatusProduct StatusProduct { get; set; } = null!;
    public ICollection<Entry> Entries { get; set; } = new List<Entry>();
    public ICollection<Exit> Exits { get; set; } = new List<Exit>();
}
