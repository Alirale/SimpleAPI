using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Domain.Entities;

namespace Application.Services
{
    public class InventoryService(IItemRepository inventoryRepository) : IInventoryService
    {
        public async Task<List<ItemDto?>> SearchAsync(SearchItemRequest searchModel)
        {
            var items = await inventoryRepository.SearchAsync(searchModel);
            return items;
        }

        public async Task<ItemDto?> GetByIdAsync(int id)
        {
            var item = await inventoryRepository.GetByIdAsync(id);
            return item is null ? null : MapToDto(item);
        }

        public async Task<int> CreateAsync(CreateItemRequest request)
        {
            var item = new Item
            {
                Name = request.Name,
                Category = request.Category,
                Description = request.Description,
                Quantity = request.Quantity,
                UnitPrice = request.UnitPrice
            };
            return await inventoryRepository.CreateAsync(item);
        }

        public async Task<bool> UpdateAsync(UpdateItemRequest request)
        {
            var existing = await inventoryRepository.GetByIdAsync(request.Id);
            if (existing is null) return false;

            existing.Name = request.Name;
            existing.Category = request.Category;
            existing.Description = request.Description;
            existing.Quantity = request.Quantity;
            existing.UnitPrice = request.UnitPrice;

            return await inventoryRepository.UpdateAsync(existing);
        }

        public Task<bool> DeleteAsync(int id) => inventoryRepository.DeleteAsync(id);


        private static ItemDto MapToDto(Item item) => new()
        {
            Id = item.Id,
            Name = item.Name,
            Category = item.Category,
            Description = item.Description,
            Quantity = item.Quantity,
            UnitPrice = item.UnitPrice,
            CreatedAt = item.CreatedAt
        };
    }
}
