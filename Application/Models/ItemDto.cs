namespace Warehouse.Application.Models;

public record ItemDto(
    int Id,
    string SKU,
    string Name,
    int? CategoryId,
    string? Description,
    int Quantity,
    decimal UnitPrice,
    DateTime CreatedAt,
    DateTime? UpdatedAt
);