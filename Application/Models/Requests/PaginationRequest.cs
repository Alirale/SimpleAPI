using System.ComponentModel.DataAnnotations;

namespace Application.Models.Requests;

public class PaginationRequest
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? Keyword { get; set; }
}