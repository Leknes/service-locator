namespace Senkel.Tools.Services;

/// <summary>
/// Grants access to unregistrating a service that has previously been registrated.
/// </summary>
public class ServiceUnregistrar
{
    private readonly Type _type;

    internal ServiceUnregistrar(Type type)
    {
        _type = type;
    }

    /// <summary>
    /// Unregisters the corresponding service.
    /// </summary>
    public void Unregister()
    {
        ServiceStorage.Storage.Remove(_type);
    }
}