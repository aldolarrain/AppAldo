using System;
using System.Collections.Generic;
using System.Text;

namespace AppAldo.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public IdViewModel Identificador { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Identificador = new IdViewModel();
        }
        #endregion
    }
}
