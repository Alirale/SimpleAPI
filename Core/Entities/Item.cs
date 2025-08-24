using Domain.Enums;

namespace Domain.Entities;

public class Item
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Name { get; set; }
    public CategoryType Category { get; set; }
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}