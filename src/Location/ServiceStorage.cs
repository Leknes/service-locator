﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senkel.Tools.Services;

internal static class ServiceStorage
{
    public static IDictionary<Type, ServiceProvider> Storage {get;} = new Dictionary<Type, ServiceProvider>();
}