using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NetworkConfigTool.Models
{
    public class ConfigManager
    {
        public void LoadConfig(out Adapter adapter, out Proxy proxy)
        {
            // TODO: load current settings
            adapter = null;
            proxy = null;
        }

        public void ApplyConfig(Adapter adapter, Proxy proxy)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.StartInfo = startInfo;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                string command = "";

                command = $"netsh interface ip set address \"{adapter.AdapterName}\" ";
                command += (adapter.AutoIpAddress || string.IsNullOrEmpty(adapter.IpAddress)) ? "dhcp" : $"static {adapter.IpAddress} {adapter.MaskAddress} {adapter.DefaultGateway}";
                sw.WriteLine(command);

                command = $"netsh interface ip set dns \"{adapter.AdapterName}\" ";
                command += (adapter.AutoDnsAddress || string.IsNullOrEmpty(adapter.PrimaryDns)) ? "dhcp" : $"static {adapter.PrimaryDns}";
                sw.WriteLine(command);

                if (!string.IsNullOrEmpty(adapter.SecondaryDns))
                {
                    command = $"netsh interface ip add dns {adapter.AdapterName} {adapter.SecondaryDns}";
                    sw.WriteLine(command);
                }

                // TODO: proxy settings
            }
        }
    }
}
