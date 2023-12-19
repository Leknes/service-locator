namespace Senkel.Tools.Services;


internal class NewServiceProvider<T> : ServiceProvider where T : new()
{ 
    public override object Provide()
    {
        return new T();
    }
}

 