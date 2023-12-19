namespace Senkel.Tools.Services;

internal class ServiceRegistrationHelper
{
    public readonly Type Type;

    public ServiceRegistrationHelper(Type type)
    {
        Type = type;
    }

    public ServiceUnregistrar Register(ServiceProvider provider)
    { 
        ServiceStorage.Storage.Add(Type, provider);
 
        return new ServiceUnregistrar(Type);
    }

}
