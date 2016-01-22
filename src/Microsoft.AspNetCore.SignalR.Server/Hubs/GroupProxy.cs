// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Infrastructure;

namespace Microsoft.AspNetCore.SignalR.Hubs
{
    public class GroupProxy : SignalProxy
    {
        public GroupProxy(IConnection connection, IHubPipelineInvoker invoker, string signal, string hubName, IList<string> exclude) :
            base(connection, invoker, signal, hubName, PrefixHelper.HubGroupPrefix, exclude)
        {

        }
    }
}
