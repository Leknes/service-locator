using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Tools.Services;

internal class MethodServiceProvider<T> : ServiceProvider  
{ 
    private readonly Func<T> _method;
  
    public MethodServiceProvider(Func<T> method)
    {
        _method = method;
    } 
 
    public override object Provide()
    {   
        return _method()!;
    }
}
