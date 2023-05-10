﻿using Quick.Onvif.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Onvif.Device
{
    public partial class DeviceClient
    {
        public DeviceClient(string url, string username, string password, ClientFactoryBase factory)
            : base(factory.Binding, new System.ServiceModel.EndpointAddress(url))
        {
            factory.InitClient(this, username, password);
        }
    }
}