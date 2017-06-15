using CarServiceAssistant.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CarServiceAssistant.ViewModel
{
    class ViewModel
    {
        protected WindowManager windowManager;
        public ICommand OpenAddingFromMenu { get; set; }
        public ICommand OpenSelectionFromMenu { get; set; }
        public ViewModel()
        {
            windowManager = new WindowManager();
            OpenAddingFromMenu = new Command(x => true, x => windowManager.OpenAdding());
            OpenSelectionFromMenu = new Command(x => true, x => windowManager.OpenSelection());
        }
    }
}
