using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Toolkit.Universal.ServiceLocation;

internal static class ServiceStorage
{
    private static Dictionary<Type, ServiceObject> _serviceStorage = new Dictionary<Type, ServiceObject>();

    internal static IDictionary<Type, ServiceObject> GetStorage()
    {
        return _serviceStorage;
    }
}