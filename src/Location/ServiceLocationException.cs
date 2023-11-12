namespace Senkel.Services.ServiceLocation;

public class ServiceLocationException : Exception
{
    internal ServiceLocationException(Type serviceType) : base($"The service of type {serviceType} could not be located.") { }
}

