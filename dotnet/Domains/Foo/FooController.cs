using Jinrage78.Common;
using Microsoft.AspNetCore.Mvc;

namespace Jinrage78.Foo;

[Route("api/[controller]")]
[ApiController]
public class FooController : BaseCrudController
{
    private readonly IFooService _service;

    public FooController(IFooService service) : base(service)
    {
        _service = service;
    }
}
