using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Controllers;

[ApiController]
[Route("[controller]/v{version:ApiVersion}")]
[Authorize]
public class ItemsController(IInventoryService service) : ControllerBase
{
    [HttpGet]
    [Route("Search")]
    public async Task<List<ItemDto>> Search([FromQuery] SearchItemRequest model)
    {
        var result = await service.SearchAsync(model);
        return result;
    }

    [HttpGet]
    [Route("Get")]
    public async Task<ItemDto?> Get(int id)
    {
        var item = await service.GetByIdAsync(id);
        return item;
    }

    [HttpPost]
    [Route("Create")]
    public async Task<bool> Create([FromBody] CreateItemRequest request)
    {
        var id = await service.CreateAsync(request);
        return true;
    }

    [HttpPut]
    [Route("Update")]
    public async Task<bool> Update([FromBody] UpdateItemRequest request)
    {
        var ok = await service.UpdateAsync(request);
        return ok;
    }

    [HttpDelete]
    [Route("Delete")]
    public async Task<bool> Delete(int id)
    {
        var ok = await service.DeleteAsync(id);
        return ok;
    }
}
