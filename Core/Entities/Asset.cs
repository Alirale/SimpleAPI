using Domain.Enums;

namespace Domain.Entities;

public class Asset
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }
    public string? SerialNumber { get; set; }
    public DateTime EntryDate { get; set; } = DateTime.UtcNow;
    public DateTime? ExitDate { get; set; }
    public AssetStatus Status { get; set; } = AssetStatus.Available;
}