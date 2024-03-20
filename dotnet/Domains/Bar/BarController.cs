using Jinrage78.Common;
using Microsoft.AspNetCore.Mvc;

namespace Jinrage78.Bar;

[Route("api/[controller]")]
[ApiController]
public class BarController : BaseCrudController
{
    private readonly IBarService service;

    public BarController(IBarService service) : base(service)
    {
        this.service = service;
    }
}
