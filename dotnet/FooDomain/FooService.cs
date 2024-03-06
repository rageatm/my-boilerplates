namespace Infinitt.Lis.Foo;

public class FooService : IFooService
{
    public string GetAsync(int id)
    {
        return $"Id={id}";
    }
}
