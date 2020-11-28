using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using NetworkConfigTool.Models;

namespace NetworkConfigTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<Adapter> _Adapters = new ObservableCollection<Adapter>();
        public ObservableCollection<Adapter> Adapters
        {
            get { return _Adapters; }
            set { SetProperty(ref _Adapters, value); }
        }

        private Adapter _CurrentAdapter;
        public Adapter CurrentAdapter
        {
            get { return _CurrentAdapter; }
            set { SetProperty(ref _CurrentAdapter, value); }
        }

        private Proxy _Proxy;
        public Proxy Proxy
        {
            get { return _Proxy; }
            set { SetProperty(ref _Proxy, value); }
        }

        public MainWindowViewModel()
        {
            // TODO: for debugging...
            Adapters.AddRange(
                new List<Adapter>
                {
                    new Adapter
                    {
                        AdapterName = "Adapter 1",
                        SetUpInThisApp = true,
                        Enabled = true,
                        AutoIpAddress = false,
                        IpAddress = "192.168.1.10",
                        Mask = 24,
                        DefaultGateway = "192.168.1.1",
                        AutoDnsAddress = false,
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = "7.7.7.7"
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 2",
                        SetUpInThisApp = true,
                        Enabled = false,
                        AutoIpAddress = false,
                        IpAddress = "192.168.1.20",
                        Mask = 24,
                        DefaultGateway = "",
                        AutoDnsAddress = false,
                        PrimaryDns = "9.9.9.9",
                        SecondaryDns = ""
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 3",
                        SetUpInThisApp = false,
                        Enabled = true,
                        AutoIpAddress = false,
                        IpAddress = "192.168.62.50",
                        Mask = 22,
                        DefaultGateway = "192.168.63.254",
                        AutoDnsAddress = false,
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = ""
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 4",
                        SetUpInThisApp = false,
                        Enabled = true,
                        AutoIpAddress = true,
                        IpAddress = "192.168.62.50",
                        Mask = 16,
                        DefaultGateway = "192.168.63.254",
                        AutoDnsAddress = false,
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = ""
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 5",
                        SetUpInThisApp = false,
                        Enabled = true,
                        AutoIpAddress = false,
                        IpAddress = "192.168.62.50",
                        Mask = 20,
                        DefaultGateway = "192.168.63.254",
                        AutoDnsAddress = true,
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = ""
                    }
                }
                );

            CurrentAdapter = Adapters[0];

            Proxy = new Proxy { UseProxy = true, ProxyAddress = "192.168.1.100" };
            // ...for debugging
        }
    }
}
