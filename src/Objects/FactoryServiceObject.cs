namespace Senkel.Services.ServiceLocation;

public interface IFactory<T>
{
    public T Create();
}

internal class FactoryServiceObject<T> : ServiceObject
{
    private readonly IFactory<T> _factory;

    public FactoryServiceObject(IFactory<T> factory)
    {
        _factory = factory;
    }

    public override object GetService()
    { 
        return _factory.Create() ?? throw new InvalidOperationException("Factory create null reference.");
    }
}