using Microsoft.AspNetCore.Mvc;

namespace Jinrage78.Common;

public class BaseCrudController : ControllerBase
{
    private readonly IBaseCrudService _service;
    public BaseCrudController(IBaseCrudService service)
    {
        _service = service;
    }

    [HttpGet]
    public string Get(int id)
    {
        return _service.GetAsync(id);
    }
}
