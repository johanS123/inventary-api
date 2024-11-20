namespace MinimalApiEfCore.Models;

public class Entry
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public DateTime EntryDate { get; set; }
    public double Quantity { get; set; }
}
