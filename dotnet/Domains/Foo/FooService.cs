using Jinrage78.Common;

namespace Jinrage78.Foo;

public class FooService : BaseCrudService, IFooService
{
    public override string GetAsync(int id)
    {
        return $"Foo Service ID ={id}";
    }
}
