namespace Senkel.Toolkit.Universal.ServiceLocation;


internal class TransientServiceObject<T> : ServiceObject where T : new()
{
    public override object GetService()
    {
        return new T();
    }
}