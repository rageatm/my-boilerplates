using Jinrage78.Common;
using Microsoft.AspNetCore.Mvc;

namespace Jinrage78.Foo;

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
