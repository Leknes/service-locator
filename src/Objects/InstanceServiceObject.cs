namespace Senkel.ServiceLocation;

internal class InstanceServiceObject : ServiceObject
{
    private readonly object _instance;

    public InstanceServiceObject(object instance)
    {
        _instance = instance;
    }

    public override object GetService()
    {
        return _instance;
    }
}