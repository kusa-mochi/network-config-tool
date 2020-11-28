using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class Adapter
    {
        public string AdapterName { get; set; } = "";
        public bool SetUpInThisApp { get; set; } = true;
        public bool Enabled { get; set; } = true;
        public bool AutoIpAddress { get; set; } = false;
        public string IpAddress { get; set; } = "192.168.1.1";
        public int Mask { get; set; } = 24;
        public string DefaultGateway { get; set; } = "";
        public bool AutoDnsAddress { get; set; } = false;
        public string PrimaryDns { get; set; } = "";
        public string SecondaryDns { get; set; } = "";

        // getter only properties

        public string MaskAddress
        {
            get
            {
                string binMask = "";
                for (int i = 0; i < Mask; i++)
                {
                    binMask += "1";
                }
                for (int i = 0; i < 32 - Mask; i++)
                {
                    binMask += "0";
                }

                string output = "";
                for (int i = 0; i < 4; i++)
                {
                    int currentNumber = Convert.ToInt32(binMask.Substring(i * 4, 4), 2);
                    output += currentNumber.ToString();
                    if (i < 3) output += ".";
                }

                return output;
            }
        }
    }
}
