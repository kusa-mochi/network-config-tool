using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using NetworkConfigTool.Models;

namespace NetworkConfigTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<ConfigItem> _ConfigItems = new ObservableCollection<ConfigItem>();
        public ObservableCollection<ConfigItem> ConfigItems
        {
            get { return _ConfigItems; }
            set { SetProperty(ref _ConfigItems, value); }
        }

        public MainWindowViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                ConfigItems.AddRange(new List<ConfigItem>() {
                    new ConfigItem()
                    {
                        Name = "TestItem1",
                        Adapters = new List<Adapter>()
                        {
                            new Adapter()
                            {
                                AdapterName = "Adapter 1",
                                IpAddress = new IPAddressData(192,168,1,1),
                                Mask = 24,
                                DefaultGateway = new IPAddressData(192,168,1,254),
                                PrimaryDns = new IPAddressData(8,8,8,8),
                                SecondaryDns = null
                            },
                            new Adapter()
                            {
                                AdapterName = "Adapter 2",
                                IpAddress = new IPAddressData(192,168,0,10),
                                Mask = 16,
                                DefaultGateway = new IPAddressData(192,168,0,1),
                                PrimaryDns = new IPAddressData(192,168,0,1),
                                SecondaryDns = new IPAddressData(192,168,0,2)
                            }
                        }
                    },
                    new ConfigItem()
                    {
                        Name = "TestItem2",
                        Adapters = new List<Adapter>()
                        {
                            new Adapter()
                            {
                                AdapterName = "Adapter 1",
                                IpAddress = new IPAddressData(192,168,1,1),
                                Mask = 24,
                                DefaultGateway = new IPAddressData(192,168,1,254),
                                PrimaryDns = new IPAddressData(8,8,8,8),
                                SecondaryDns = null
                            },
                            new Adapter()
                            {
                                AdapterName = "Adapter 2",
                                IpAddress = new IPAddressData(192,168,0,10),
                                Mask = 16,
                                DefaultGateway = new IPAddressData(192,168,0,1),
                                PrimaryDns = new IPAddressData(192,168,0,1),
                                SecondaryDns = new IPAddressData(192,168,0,2)
                            }
                        }
                    },
                    new ConfigItem()
                    {
                        Name = "TestItem3",
                        Adapters = new List<Adapter>()
                        {
                            new Adapter()
                            {
                                AdapterName = "Adapter 1",
                                IpAddress = new IPAddressData(192,168,1,1),
                                Mask = 24,
                                DefaultGateway = new IPAddressData(192,168,1,254),
                                PrimaryDns = new IPAddressData(8,8,8,8),
                                SecondaryDns = null
                            },
                            new Adapter()
                            {
                                AdapterName = "Adapter 2",
                                IpAddress = new IPAddressData(192,168,0,10),
                                Mask = 16,
                                DefaultGateway = new IPAddressData(192,168,0,1),
                                PrimaryDns = new IPAddressData(192,168,0,1),
                                SecondaryDns = new IPAddressData(192,168,0,2)
                            }
                        }
                    }
                });
            }

        }
    }
}
