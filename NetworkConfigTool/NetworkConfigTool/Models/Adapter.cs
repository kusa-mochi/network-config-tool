using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class Adapter
    {
        public string AdapterName { get; set; } = "";
        public bool SetUpInThisApp { get; set; } = true;
        public bool Enabled { get; set; } = true;
        public string IpAddress { get; set; } = "192.168.1.1";
        public int Mask { get; set; } = 24;
        public string DefaultGateway { get; set; } = "";
        public string PrimaryDns { get; set; } = "";
        public string SecondaryDns { get; set; } = "";
    }
}
