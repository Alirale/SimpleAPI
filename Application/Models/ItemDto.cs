using Domain.Enums;

public class ItemDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CategoryType Category { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime CreatedAt { get; set; }
}