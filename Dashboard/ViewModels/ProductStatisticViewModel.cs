﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using Prism.Regions;
using DataAccessLocal;
using System.Collections.ObjectModel;
using DynamicData;
using ReactiveUI;
using DynamicData.Binding;


namespace Dashboard.ViewModels
{
    public class ProductStatisticViewModel : ReactiveObject, INavigationAware, IRegionMemberLifetime
    {
        #region Declaration
        NorthwindContext northwindContext;

        #endregion

        #region Constructor
        public ProductStatisticViewModel(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;

        }
        #endregion

        #region Implementation of IRegionMemberLifeTime
        public bool KeepAlive => true;
        #endregion

        #region Implementation of INavigationAware
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
