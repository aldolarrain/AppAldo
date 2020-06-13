using System;
using System.Collections.Generic;
using System.Text;

namespace AppAldo.Infrastructure
{
    using AppAldo.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
