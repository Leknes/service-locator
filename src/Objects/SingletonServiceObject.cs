namespace Senkel.Services.ServiceLocation;

internal class SingletonServiceObject<T> : ServiceObject where T : new()
{
    private T? _singleton;

    public override object GetService()
    {
        if(_singleton == null)
            _singleton = new T();

        return _singleton;
    }
}