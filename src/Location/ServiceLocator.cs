namespace Senkel.Toolkit.Universal.ServiceLocation;

// Services may be provided if the following rule applies.
// A service may only depend on other services or on scripts that do not depend on any classes at all.
// Also a class may not instantiate a class unless it does not interact with any classes that aren't services.
// Also a class can be instantiated when publicly it will only be accessable by an interface or a base class.
// Instead a class should use the service locator or inject the dependency via unitys inspector; 
// this is usually done when a class, in its function, does not represent a service but an object. 

public static class ServiceLocator
{
    private static IDictionary<Type, ServiceObject> _serviceCollection;
     
    static ServiceLocator()
    {
        _serviceCollection = ServiceStorage.GetStorage();
    }

    public static T Get<T>()
    {
        Type type = typeof(T);

        if (_serviceCollection.TryGetValue(typeof(T), out ServiceObject? getter))
            return (T)getter.GetService();

        throw new ServiceLocationException(type);
    }
     
}




