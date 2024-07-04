using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace tg_engine_launcher.ViewModels
{
    public class dmHandlersListVM : ViewModelBase
    {
        #region properties
        public ObservableCollection<dmHandlerVM> DMHandlers { get; } = new();

        dmHandlerVM selectedDM;
        public dmHandlerVM SelectedDM
        {
            get => selectedDM;
            set => this.RaiseAndSetIfChanged(ref selectedDM, value);
        }
        #endregion

        #region commands
        public ReactiveCommand<Unit, Unit> startAllCmd { get; }
        public ReactiveCommand<Unit, Unit> stopAllCmd { get; }
        public ReactiveCommand<Unit, Unit> refreshCmd { get; }
        #endregion

        public dmHandlersListVM() {

            #region commands
            startAllCmd = ReactiveCommand.CreateFromTask(async () => { });
            stopAllCmd = ReactiveCommand.CreateFromTask(async () => { });
            refreshCmd = ReactiveCommand.CreateFromTask(async () => { });
            #endregion

        }
    }
}
