using Senkel.ObjectModel.Creation;

namespace Senkel.Toolkit.ServiceLocation;
 
internal class FactoryServiceProvider<T> : ServiceProvider
{
    private readonly IFactory<T> _factory;

    public FactoryServiceProvider(IFactory<T> factory)
    {
        _factory = factory;
    }

    public override object Provide()
    { 
        return _factory.Create()!;
    }
}