using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class Proxy
    {
        public bool UseProxy { get; set; } = false;
        public string ProxyAddress { get; set; } = "";
    }
}
