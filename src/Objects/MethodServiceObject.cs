using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Toolkit.Universal.ServiceLocation;

internal class MethodServiceObject<T> : ServiceObject
{
    private readonly Func<T> _method;

    public MethodServiceObject(Func<T> method)
    {
        _method = method;
    }

    public override object GetService()
    {
        return _method() ?? throw new NullReferenceException();
    }
}
