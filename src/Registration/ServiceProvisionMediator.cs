using System.Diagnostics.CodeAnalysis;
using Senkel.Model.Creating;

namespace Senkel.Tools.Services
{
   /// <summary>
   /// Functions as a mediator for setting a way of providing the object of the service to register.
   /// </summary>
   /// <typeparam name="T">The type of the service to register.</typeparam>
   public class ServiceProvisionMediator<T>
   {
      private ServiceRegistrationHelper _helper;

      internal ServiceProvisionMediator()
      {
         _helper = new ServiceRegistrationHelper(typeof(T));
      }

      /// <summary>
      /// Registers the service of the specified type from the specified instance.
      /// </summary>
      /// <param name="instance">The instance to represent the service.</param>
      /// <returns>A class granting access to unregistrating the service.</returns>
      public ServiceUnregistrar FromInstance(T instance)
      {
         return _helper.Register(new InstanceServiceProvider(instance!));
      }

      /// <summary>
      /// Sets the service of the specified type to be instantiated using the corresponding <see cref="IFactory{T}.Create"/> method.
      /// </summary>
      /// <param name="factory">The factory to use for instantiating the service.</param>
      /// <returns>A mediator for registrating by setting the scope of the service.</returns>
      public ServiceScopeMediator FromFactory(IFactory<T> factory)
      {
         return GetScopeMediator(new FactoryServiceProvider<T>(factory));
      }

      /// <summary>
      /// Sets the service of the specified type to be instantiated newly.
      /// </summary>
      /// <typeparam name="TConcrete">The concrete class that will be instantiated newly.</typeparam>
      /// <returns>A mediator for registrating by setting the scope of the service.</returns>
      public ServiceScopeMediator FromNew<TConcrete>() where TConcrete : T, new()
      {
         return GetScopeMediator(new NewServiceProvider<TConcrete>());
      }

      /// <summary>
      /// Sets the service of the specified type to be instantiated by a method.
      /// </summary>
      /// <param name="method">The method that is used for instantiating the service.</param>
       /// <returns>A mediator for registrating by setting the scope of the service.</returns>
      public ServiceScopeMediator FromMethod(Func<T> method)
      {
         return GetScopeMediator(new MethodServiceProvider<T>(method));
      }

      private ServiceScopeMediator GetScopeMediator(ServiceProvider provider)
      {
         return new ServiceScopeMediator(_helper, provider);
      }

   }


}
