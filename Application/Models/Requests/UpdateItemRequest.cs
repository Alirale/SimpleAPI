namespace Application.Models.Requests;

public class UpdateItemRequest
{
    public string Name { get; set; }
    public int? CategoryId { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}