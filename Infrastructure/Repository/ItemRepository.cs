using Application.Interfaces;
using Application.Models.Requests;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;
using Dapper;

namespace Infrastructure.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly ILogger<IUsersDataAccess> _logger;
        private readonly string? _connectionString;

        public ItemRepository(IConfiguration config, ILogger<IUsersDataAccess> logger)
        {
            _connectionString = config["connection"];
            _logger = logger;
        }

        public async Task<Item?> GetByIdAsync(int id)
        {
            try
            {
                await using var conn = new SqlConnection(_connectionString);

                if (id > 0)
                {
                    return await conn.QueryFirstOrDefaultAsync<Item>(
                        "dbo.Item_GetById",
                        new { Id = (int?)id },
                        commandType: CommandType.StoredProcedure);
                }

                var rows = await conn.QueryAsync<Item>(
                    "dbo.Item_GetById",
                    new { Id = (int?)null },
                    commandType: CommandType.StoredProcedure);
                return rows.FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetByIdAsync failed for Id {Id}", id);
                throw;
            }
        }

        public async Task<List<ItemDto?>> SearchAsync(SearchItemRequest searchModel)
        {
            try
            {
                await using var conn = new SqlConnection(_connectionString);
                var name = string.IsNullOrWhiteSpace(searchModel.Name) ? null : searchModel.Name.Trim();

                var rows = await conn.QueryAsync<ItemDto>(
                    "dbo.Item_Search",
                    new { Name = name, Category = searchModel?.Category.ToString(), searchModel?.FromDate, searchModel?.ToDate },
                    commandType: CommandType.StoredProcedure);

                return rows.ToList()!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SearchAsync failed");
                throw;
            }
        }

        public async Task<int> CreateAsync(Item item)
        {
            try
            {
                await using var conn = new SqlConnection(_connectionString);

                var newId = await conn.ExecuteScalarAsync<int>(
                    "dbo.Item_Insert",
                    new
                    {
                        item.Name,
                        Category = item.Category.ToString(),
                        item.Description,
                        item.UnitPrice,
                        item.Quantity
                    },
                    commandType: CommandType.StoredProcedure);

                return newId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CreateAsync failed");
                throw;
            }
        }

        public async Task<bool> UpdateAsync(Item item)
        {
            try
            {
                await using var conn = new SqlConnection(_connectionString);

                var succeeded = await conn.ExecuteScalarAsync<bool>(
                    "dbo.Item_Update",
                    new
                    {
                        item.Id,
                        item.Name,
                        Category = item.Category.ToString(),
                        item.Description,
                        item.UnitPrice,
                        item.Quantity
                    },
                    commandType: CommandType.StoredProcedure);

                return succeeded;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateAsync failed for Id {Id}", item.Id);
                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                await using var conn = new SqlConnection(_connectionString);

                var succeeded = await conn.ExecuteScalarAsync<bool>(
                    "dbo.Item_Delete",
                    new { Id = id },
                    commandType: CommandType.StoredProcedure);

                return succeeded;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteAsync failed for Id {Id}", id);
                throw;
            }
        }
    }
}
