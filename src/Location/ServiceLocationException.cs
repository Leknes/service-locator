namespace Senkel.Toolkit.ServiceLocation;

/// <summary>
/// This exception is thrown, when a service could not be located by the <see cref="ServiceLocator"/> class.
/// </summary>
public class ServiceLocationException : Exception
{ 
    internal ServiceLocationException(Type serviceType) : base($"The service of type {serviceType} could not be located.") { }
}

