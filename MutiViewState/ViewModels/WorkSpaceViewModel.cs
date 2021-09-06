using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutiViewState.ViewModels
{
    [Export(typeof(WorkSpaceViewModel))]
    public class WorkSpaceViewModel:Conductor<IWidgetViewModel>.Collection.OneActive
    {
        private List<IWidgetViewModel> saveCollection;
        private IWidgetViewModel saveActiveItem;

        protected override void OnInitialize()
        {
            base.OnInitialize();
            this.ActivateItem(IoC.Get<WebWidegtViewModel>());
            this.ActivateItem(IoC.Get<MeetingWidgetViewModel>());
            this.ActivateItem(IoC.Get<ScheduleWidgetViewModel>());
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);
        }

        public void SnapshotAndClean()
        {
            this.saveCollection = new List<IWidgetViewModel>(this.Items);
            this.saveActiveItem = this.ActiveItem;
            this.Items.Clear();
            this.ActiveItem = null;
            this.Views.Clear();
        }

        public void Restore()
        {
            var b = this.ActiveItem;
            saveCollection.ForEach(t =>
                {
                    this.Items.Add(t);
                });
            var a = this.ActiveItem;
            this.ActiveItem = saveActiveItem;
        }

        public void CloseSelf( IWidgetViewModel item )
        {
            this.CloseItem( item );
        }
    }
}
