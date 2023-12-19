using Senkel.Model.Creating;

namespace Senkel.Tools.Services;
 
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