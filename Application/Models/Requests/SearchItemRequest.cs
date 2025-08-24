using Domain.Enums;

namespace Application.Models.Requests;

public class SearchItemRequest
{
    public string? Name { get; set; }
    public CategoryType? Category { get; set; }
}