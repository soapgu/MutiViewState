using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutiViewState.ViewModels
{
    [Export(typeof(MeetingWidgetViewModel)), PartCreationPolicy(CreationPolicy.NonShared)]
    public class MeetingWidgetViewModel : Screen, IWidgetViewModel
    {
        public string Title
        {
            get { return "会议"; }
        }


        private string editContent;

        public string EditContent
        {
            get
            {
                return this.editContent;
            }
            set
            {
                this.editContent = value;
                this.NotifyOfPropertyChange(() => this.EditContent);
            }
        }
    }
}
