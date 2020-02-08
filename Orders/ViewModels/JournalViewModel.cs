﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.ViewModels
{
    public class JournalViewModel : BindableBase, IRegionMemberLifetime
    {
        #region Declarations
        IRegionManager regionManager;
        #endregion

        #region Construct
        public JournalViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        #endregion

        #region Properties
        public bool KeepAlive => true;
        #endregion

        #region Commands
        #endregion
    }
}
