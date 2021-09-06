using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutiViewState.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<WorkSpaceViewModel>, IShell
    {
        private int modeIndex;

        public static readonly List<string> modeList = new List<string>() { "Tab", "Simple" };//"List",

        protected override void OnInitialize()
        {
            var item = IoC.Get<WorkSpaceViewModel>();
            this.ActivateItem(item);
            base.OnInitialize();
        }

        public string Mode
        {
            get
            {
                return modeList[modeIndex];
            }
        }

        public void ChangeMode()
        {
            this.ActiveItem.SnapshotAndClean();
            this.modeIndex = (this.modeIndex + 1) % modeList.Count;
            this.NotifyOfPropertyChange(() => this.Mode);
            //绑定后强制刷新列表
            this.ActiveItem.Restore();
        }
    }
}
