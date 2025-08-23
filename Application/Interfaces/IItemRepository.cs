using Domain.Entities;

namespace Application.Interfaces;

public interface IItemRepository
{
    Task<(IEnumerable<Item> Items, int TotalCount)> SearchAsync(string? keyword, int pageNumber, int pageSize);
    Task<Item?> GetByIdAsync(int id);
    Task<int> CreateAsync(Item item);
    Task<bool> UpdateAsync(Item item);
    Task<bool> DeleteAsync(int id);
}