using Infinitt.Lis.BaseCrud;
using Microsoft.AspNetCore.Mvc;

namespace Infinitt.Lis.Foo;

[Route("api/[controller]")]
[ApiController]
public class FooController : BaseCrudController
{
    private readonly IFooService service;

    public FooController(IFooService service) : base(service)
    {
        this.service = service;
    }
}
