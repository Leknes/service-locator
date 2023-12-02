namespace Senkel.Toolkit.ServiceLocation;

internal class InstanceServiceProvider : ServiceProvider
{
    private readonly object _instance;

    public InstanceServiceProvider(object instance)
    {
        _instance = instance;
    }

    public override object Provide()
    {
        return _instance;
    }
}