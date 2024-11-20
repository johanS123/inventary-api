namespace MinimalApiEfCore.Models;

public class Exit
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public DateTime ExitDate { get; set; }
    public int Quantity { get; set; }
}
