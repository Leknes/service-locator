 namespace Senkel.ServiceLocation
{
    public class ServiceRegistrar
    {
        private readonly IDictionary<Type, ServiceObject> _serviceCollection;

        internal ServiceRegistrar(IDictionary<Type, ServiceObject> serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public ServiceRegistrationMediator<T> Register<T>()
        {
            return new ServiceRegistrationMediator<T>(_serviceCollection);
        }

        public void RegisterInstance<T>(T instance)
        {
            Register<T>().ToInstance(instance);
        }
        public void RegisterSingleton<T>() where T : new()
        {
            Register<T>().AsSingleton<T>();
        }
        public void RegisterTransient<T>() where T : new()
        {
            Register<T>().AsTransient<T>();
        }
        public void RegisterFromFactory<T>(IFactory<T> factory)
        {
            Register<T>().FromFactory(factory);
        }

        public void RegisterFromMethod<T>(Func<T> method)
        {
            Register<T>().FromMethod(method);
        }
    }

}