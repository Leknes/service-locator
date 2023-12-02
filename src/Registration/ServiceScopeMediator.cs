namespace Senkel.Toolkit.ServiceLocation;

/// <summary>
/// Functions as a mediator for registrating a service by setting a scope for the service.
/// </summary>
public class ServiceScopeMediator
{
    private readonly ServiceProvider _provider;

    private ServiceRegistrationHelper _helper;

    internal ServiceScopeMediator(ServiceRegistrationHelper helper, ServiceProvider provider)
    {
        _provider = provider;
        _helper = helper;
    }

    /// <summary>
    /// Registrated the service as a singleton, which means that the service is always the same, when located. 
    /// However the service is first instantiated when the service is located the first time.
    /// </summary>
    /// <returns>A class granting access to unregistrating the service.</returns>
    public ServiceUnregistrar AsSingleton()
    {
        return _helper.Register(new SingletonServiceProvider(_helper.Type, _provider));
    }
    /// <summary>
    /// Registrated the service as a singleton, that is immediately instantiated upon registration.
    /// </summary>
    /// <returns>A class granting access to unregistrating the service.</returns>
    public ServiceUnregistrar AsNonLazy()
    {
        return _helper.Register(new InstanceServiceProvider(_provider.Provide()));
    }

    /// <summary>
    /// Registrated the service as transient, which means that a new instance of service is provided whenever the service is located.
    /// However, depending on the way of providing the service the reference could also remain the same, like a singleton.
    /// </summary>
    /// <returns>A class granting access to unregistrating the service.</returns>
    public ServiceUnregistrar AsTransient()
    {
        return _helper.Register(_provider);
    }
}