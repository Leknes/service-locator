 namespace Senkel.ServiceLocation;

public abstract class ServiceRegistrationStorage
{
    public void Register()
    {
        RegisterStorage(ServiceLocator.GetRegistrar());
    }

    protected abstract void RegisterStorage(ServiceRegistrar registrar);
}
