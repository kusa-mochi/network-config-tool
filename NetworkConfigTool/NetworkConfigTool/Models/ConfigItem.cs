using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class ConfigItem
    {
        public string Name { get; set; } = "";
        public List<Adapter> Adapters = new List<Adapter>();
    }
}
