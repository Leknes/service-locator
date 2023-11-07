namespace Senkel.ServiceLocation;

public class ServiceLocationException : Exception
{
    public ServiceLocationException(Type serviceType) : base($"The service of type {serviceType} could not be located.") { }
}

