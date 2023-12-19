namespace Senkel.Tools.Services;
 
/// <summary>
/// Is responsible for locating services by type that are registrated using the <see cref="ServiceRegistrar"/> class.
/// </summary>
public static class ServiceLocator
{ 
    /// <summary>
    /// Returns the service that has been registrated using by the specified type.
    /// </summary>
    /// <typeparam name="T">The type of the service to locate.</typeparam> 
    /// <exception cref="ServiceLocationException">Throws, if the service of the specified type could not be located.</exception>
    public static T Get<T>()
    {
        Type type = typeof(T);

        if (ServiceStorage.Storage.TryGetValue(typeof(T), out ServiceProvider? provider))
            return (T)provider.Provide();

        throw new ServiceLocationException(type);
    }
     
}




