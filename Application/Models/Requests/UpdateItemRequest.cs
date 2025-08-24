using Domain.Enums;

namespace Application.Models.Requests;

public class UpdateItemRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryType Category { get; set; }
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}