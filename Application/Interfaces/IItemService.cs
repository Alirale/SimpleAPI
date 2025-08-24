using Application.Models;
using Application.Models.Requests;

namespace Application.Interfaces;

public interface IInventoryService
{
    Task<List<ItemDto?>> SearchAsync(SearchItemRequest searchModel);
    Task<ItemDto?> GetByIdAsync(int id);
    Task<int> CreateAsync(CreateItemRequest request);
    Task<bool> UpdateAsync(UpdateItemRequest request);
    Task<bool> DeleteAsync(int id);
}