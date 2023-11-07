namespace Senkel.ServiceLocation
{
    public class ServiceRegistrationMediator<T>
    {
        private readonly IDictionary<Type, ServiceObject> _serviceCollection;

        internal ServiceRegistrationMediator(IDictionary<Type, ServiceObject> serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        private void RegisterServiceObject(ServiceObject serviceObject)
        {
            _serviceCollection.Add(typeof(T), serviceObject);
        }

        public void AsTransient<TConcrete>() where TConcrete : T, new()
        {
            RegisterServiceObject(new TransientServiceObject<TConcrete>());
        }

        public void AsSingleton<TConcrete>() where TConcrete : T, new()
        {
            RegisterServiceObject(new SingletonServiceObject<TConcrete>());
        }

        public void ToInstance(T instance)
        {
            if(instance == null)
                throw new NullReferenceException(nameof(instance));

            RegisterServiceObject(new InstanceServiceObject(instance));
        }

        public void FromFactory<TConcrete>(IFactory<TConcrete> factory) where TConcrete : T
        {
            RegisterServiceObject(new FactoryServiceObject<TConcrete>(factory));
        }

        public void FromMethod<TConcrete>(Func<TConcrete> method) where TConcrete : T
        {
            RegisterServiceObject(new MethodServiceObject<TConcrete>(method));
        }
         

    }
}