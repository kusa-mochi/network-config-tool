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

        public MainWindowViewModel()
        {
            // for debugging...
            Adapters.AddRange(
                new List<Adapter>
                {
                    new Adapter
                    {
                        AdapterName = "Adapter 1",
                        SetUpInThisApp = true,
                        Enabled = true,
                        IpAddress = "192.168.1.10",
                        Mask = 24,
                        DefaultGateway = "192.168.1.1",
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = "7.7.7.7"
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 2",
                        SetUpInThisApp = true,
                        Enabled = false,
                        IpAddress = "192.168.1.20",
                        Mask = 24,
                        DefaultGateway = "",
                        PrimaryDns = "9.9.9.9",
                        SecondaryDns = ""
                    },
                    new Adapter
                    {
                        AdapterName = "Adapter 3",
                        SetUpInThisApp = false,
                        Enabled = true,
                        IpAddress = "192.168.62.50",
                        Mask = 22,
                        DefaultGateway = "192.168.63.254",
                        PrimaryDns = "8.8.8.8",
                        SecondaryDns = ""
                    }
                }
                );
            // ...for debugging
        }
    }
}
