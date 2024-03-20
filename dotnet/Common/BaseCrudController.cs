using Microsoft.AspNetCore.Mvc;

namespace Jinrage78.Common;

public class BaseCrudController : ControllerBase
{
    private readonly IBaseCrudService service;
    public BaseCrudController(IBaseCrudService service)
    {
        this.service = service;
    }

    [HttpGet]
    public string Get(int id)
    {
        return service.GetAsync(id);
    }
}
