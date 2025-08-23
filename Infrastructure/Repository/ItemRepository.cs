using System.Data;
using Application.Interfaces;
using Dapper;
using Domain.Entities;

namespace Infrastructure.Repository;

public class ItemRepository : IItemRepository
{
    private readonly ISqlConnectionFactory _factory;
    public ItemRepository(ISqlConnectionFactory factory) => _factory = factory;

    public async Task<(IEnumerable<Item> Items, int TotalCount)> SearchAsync(string? keyword, int pageNumber, int pageSize)
    {
        using var conn = _factory.Create();
        var p = new DynamicParameters();
        p.Add("@Keyword", keyword, DbType.String);
        p.Add("@PageNumber", pageNumber, DbType.Int32);
        p.Add("@PageSize", pageSize, DbType.Int32);

        using var multi = await conn.QueryMultipleAsync("dbo.usp_Items_SearchPaged", p, commandType: CommandType.StoredProcedure);
        var items = await multi.ReadAsync<Item>();
        var total = await multi.ReadFirstAsync<int>();
        return (items, total);
    }

    public async Task<Item?> GetByIdAsync(int id)
    {
        using var conn = _factory.Create();
        var p = new DynamicParameters();
        p.Add("@Id", id, DbType.Int32);
        return await conn.QueryFirstOrDefaultAsync<Item>("dbo.usp_Items_GetById", p, commandType: CommandType.StoredProcedure);
    }

    public async Task<int> CreateAsync(Item item)
    {
        using var conn = _factory.Create();
        var p = new DynamicParameters();
        p.Add("@SKU", item.SKU);
        p.Add("@Name", item.Name);
        p.Add("@CategoryId", item.CategoryId);
        p.Add("@Description", item.Description);
        p.Add("@Quantity", item.Quantity);
        p.Add("@UnitPrice", item.UnitPrice);
        p.Add("@NewId", dbType: DbType.Int32, direction: ParameterDirection.Output);

        await conn.ExecuteAsync("dbo.usp_Items_Insert", p, commandType: CommandType.StoredProcedure);
        return p.Get<int>("@NewId");
    }

    public async Task<bool> UpdateAsync(Item item)
    {
        using var conn = _factory.Create();
        var p = new DynamicParameters();
        p.Add("@Id", item.Id);
        p.Add("@Name", item.Name);
        p.Add("@CategoryId", item.CategoryId);
        p.Add("@Description", item.Description);
        p.Add("@Quantity", item.Quantity);
        p.Add("@UnitPrice", item.UnitPrice);

        var rows = await conn.ExecuteAsync("dbo.usp_Items_Update", p, commandType: CommandType.StoredProcedure);
        return rows > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        using var conn = _factory.Create();
        var p = new DynamicParameters();
        p.Add("@Id", id);
        var rows = await conn.ExecuteAsync("dbo.usp_Items_Delete", p, commandType: CommandType.StoredProcedure);
        return rows > 0;
    }
}