// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Runtime.Loader;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.DotNet.HotReloadWatcher
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Microsoft.DotNet.Watcher.Program.Main(args);
        }
    }
}
