using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafSaveAction.Module.Controllers
{
    public class SavingActionController : ViewController
    {
        public SavingActionController() : base()
        {
            // Target required Views (use the TargetXXX properties) and create their Actions.
            this.TargetViewType = ViewType.DetailView;
            
        }
        ModificationsController modificactioController;
        protected override void OnActivated()
        {
            base.OnActivated();
            modificactioController = this.Frame.GetController<ModificationsController>();
            if (modificactioController != null)
            {
                modificactioController.SaveAction.Executing += SaveAction_Executing;
                modificactioController.SaveAction.Executed += SaveAction_Executed;
            }
            // Perform various tasks depending on the target View.
        }

        private void SaveAction_Executed(object sender, DevExpress.ExpressApp.Actions.ActionBaseEventArgs e)
        {
           //Esto va a pasar despues de que guardo
        }

        private void SaveAction_Executing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //esto va a pasar antes de guardar
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            if (modificactioController != null)
            {
                modificactioController.SaveAction.Executing -= SaveAction_Executing;
                modificactioController.SaveAction.Executed -= SaveAction_Executed;
            }
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
    }
}
