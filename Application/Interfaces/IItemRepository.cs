using Application.Models;
using Application.Models.Requests;
using Domain.Entities;

namespace Application.Interfaces;

public interface IItemRepository
{
    Task<List<ItemDto?>> SearchAsync(SearchItemRequest searchModel);
    Task<Item?> GetByIdAsync(int id);
    Task<int> CreateAsync(Item item);
    Task<bool> UpdateAsync(Item item);
    Task<bool> DeleteAsync(int id);
}