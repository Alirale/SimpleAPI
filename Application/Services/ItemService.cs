using Application.Interfaces;
using Application.Models.Requests;
using Domain.Entities;
using Warehouse.Application.Models;
using Warehouse.Application.Models.Responses;

namespace Application.Services;

public class ItemService : IItemService
{
    private readonly IItemRepository _repo;
    public ItemService(IItemRepository repo) => _repo = repo;

    public async Task<PagedResult<ItemDto>> SearchAsync(string? keyword, int pageNumber, int pageSize)
    {
        var (items, total) = await _repo.SearchAsync(keyword, pageNumber, pageSize);
        return new PagedResult<ItemDto>
        {
            Items = items.Select(MapToDto),
            TotalCount = total,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }

    public async Task<ItemDto?> GetByIdAsync(int id)
    {
        var item = await _repo.GetByIdAsync(id);
        return item is null ? null : MapToDto(item);
    }

    public async Task<int> CreateAsync(CreateItemRequest request)
    {
        var item = new Item
        {
            SKU = request.SKU,
            Name = request.Name,
            CategoryId = request.CategoryId,
            Description = request.Description,
            Quantity = request.Quantity,
            UnitPrice = request.UnitPrice
        };
        return await _repo.CreateAsync(item);
    }

    public async Task<bool> UpdateAsync(int id, UpdateItemRequest request)
    {
        var existing = await _repo.GetByIdAsync(id);
        if (existing is null) return false;

        existing.Name = request.Name;
        existing.CategoryId = request.CategoryId;
        existing.Description = request.Description;
        existing.Quantity = request.Quantity;
        existing.UnitPrice = request.UnitPrice;
        existing.UpdatedAt = DateTime.UtcNow;

        return await _repo.UpdateAsync(existing);
    }

    public Task<bool> DeleteAsync(int id) => _repo.DeleteAsync(id);

    private static ItemDto MapToDto(Item x) =>
        new ItemDto(x.Id, x.SKU, x.Name, x.CategoryId, x.Description, x.Quantity, x.UnitPrice, x.CreatedAt, x.UpdatedAt);
}