using Splat;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using tg_engine;

namespace tg_engine_launcher.ViewModels
{
    public class mainVM : ViewModelBase
    {
        #region properties        
        public string Title { get => $"tg_engine_launcher {Assembly.GetExecutingAssembly().GetName().Version}"; }
        #endregion

        public mainVM()
        {
            tg_engine_v0 engine = new tg_engine_v0(null);
            engine.Start();
        }

    }
}
