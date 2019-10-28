﻿using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using Dashboard.MainView;
using Dashboard.OrdersStatistic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class DashboardModule : IModule
    {
        IRegionManager regionManager;
        IUnityContainer unityContainer;

        public DashboardModule(IRegionManager regionManager,IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;
        }

        public void Initialize()
        {
            unityContainer.RegisterTypeForNavigation<DashboardMainView>();
            unityContainer.RegisterTypeForNavigation<OrderStatisticView>();

            regionManager.RequestNavigate("ContentRegion", "DashboardMainView");
            regionManager.RequestNavigate("OrdersRegion", "OrderStatisticView");
        }
    }
}