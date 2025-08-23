using Application.Models.Requests;
using Warehouse.Application.Models;
using Warehouse.Application.Models.Responses;

namespace Application.Interfaces;

public interface IItemService
{
    Task<PagedResult<ItemDto>> SearchAsync(string? keyword, int pageNumber, int pageSize);
    Task<ItemDto?> GetByIdAsync(int id);
    Task<int> CreateAsync(CreateItemRequest request);
    Task<bool> UpdateAsync(int id, UpdateItemRequest request);
    Task<bool> DeleteAsync(int id);
}