using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace tg_engine_launcher.ViewModels
{
    public class dmHandlerVM : ViewModelBase
    {
        #region properties       
        public Guid Guid { get; }

        string source;
        public string Source
        {
            get => source;
            set => this.RaiseAndSetIfChanged(ref source, value);
        }

        string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set => this.RaiseAndSetIfChanged(ref phoneNumber, value);   
        }

        dmHandlerStatus status;
        public dmHandlerStatus Status
        {
            get => status;
            set
            {
                needCode = value == dmHandlerStatus.verification;
                this.RaiseAndSetIfChanged(ref status, value);
            }
        }

        string code;
        public string Code
        {
            get => code;
            set => this.RaiseAndSetIfChanged(ref code, value);
        }

        bool needCode;
        public bool NeedCode
        {
            get => needCode;
            set => this.RaiseAndSetIfChanged(ref needCode, value);  
        }
        #endregion

        #region commands        
        public ReactiveCommand<Unit, Unit> setCodeCmd { get; }
        #endregion

        public dmHandlerVM() {

            #region commands
            setCodeCmd = ReactiveCommand.CreateFromTask(async () => {
                //rest enter code
            });
            #endregion

        }
    }

    public enum dmHandlerStatus
    {
        active,
        inactive,
        verification
    }
}
