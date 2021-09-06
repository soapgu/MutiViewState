using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutiViewState.ViewModels
{
    [Export(typeof(WebWidegtViewModel)), PartCreationPolicy(CreationPolicy.NonShared)]
    public class WebWidegtViewModel : Screen, IWidgetViewModel
    {
        public string Title
        {
            get { return "精准推送"; }
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
    }
}
