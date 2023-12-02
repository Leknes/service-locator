using Senkel.ObjectModel.Creation;

namespace Senkel.Toolkit.ServiceLocation;

/// <summary>
/// Responsible for registrating services that can be located using the <see cref="ServiceLocator"/> class.
/// </summary>
public static class ServiceRegistrar
{
    /// <summary>
    /// Prepares the registration of a service of the specified type.
    /// </summary>
    /// <typeparam name="T">The type that represents the service.</typeparam>
    /// <returns>The mediator that is used to finish the registration of the service.</returns>
    public static ServiceProvisionMediator<T> Register<T>()
    {
        return new ServiceProvisionMediator<T>();
    }
 
}