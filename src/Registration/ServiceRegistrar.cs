namespace Senkel.Toolkit.ServiceLocation;

public static class ServiceRegistrar
{
    private static readonly IDictionary<Type, ServiceObject> _serviceCollection;

    static ServiceRegistrar()
    {
        _serviceCollection = ServiceStorage.GetStorage();
    }

    public static ServiceRegistrationMediator<T> Register<T>()
    {
        return new ServiceRegistrationMediator<T>(_serviceCollection);
    }

    public static void RegisterInstance<T>(T instance)
    {
        Register<T>().ToInstance(instance);
    }
    public static void RegisterSingleton<T>() where T : new()
    {
        Register<T>().AsSingleton<T>();
    }
    public static void RegisterTransient<T>() where T : new()
    {
        Register<T>().AsTransient<T>();
    }
    public static void RegisterFromFactory<T>(IFactory<T> factory)
    {
        Register<T>().FromFactory(factory);
    }

    public static void RegisterFromMethod<T>(Func<T> method)
    {
        Register<T>().FromMethod(method);
    }
}