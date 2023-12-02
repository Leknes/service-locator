namespace Senkel.Toolkit.ServiceLocation;

internal class SingletonServiceProvider : ServiceProvider
{
    private readonly Type _type;
    private readonly ServiceProvider _provider;
  
    public SingletonServiceProvider(Type type, ServiceProvider provider)
    {
         _type = type;
         _provider = provider;
    }

    public override object Provide()
    { 
        object instance = _provider.Provide();

        ServiceStorage.Storage[_type] = new InstanceServiceProvider(instance);

        return instance;
    }
}
  