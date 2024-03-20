namespace Jinrage78.Common;

public class BaseCrudService : IBaseCrudService
{
    public virtual string GetAsync(int id)
    {
        return $"Base Service ID ={id}";
    }
}
