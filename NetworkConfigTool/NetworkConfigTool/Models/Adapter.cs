using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class Adapter
    {
        public string AdapterName { get; set; } = "";
        public IPAddressData IpAddress { get; set; } = new IPAddressData(192, 168, 1, 1);
        public int Mask { get; set; } = 24;
        public IPAddressData? DefaultGateway { get; set; } = null;
        public IPAddressData? PrimaryDns { get; set; } = null;
        public IPAddressData? SecondaryDns { get; set; } = null;
    }
}
