namespace Senkel.Toolkit.ServiceLocation;


internal class NewServiceProvider<T> : ServiceProvider where T : new()
{ 
    public override object Provide()
    {
        return new T();
    }
}

 