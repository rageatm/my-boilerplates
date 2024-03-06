using Microsoft.AspNetCore.Mvc;

namespace Infinitt.Lis.BaseCrud;

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
