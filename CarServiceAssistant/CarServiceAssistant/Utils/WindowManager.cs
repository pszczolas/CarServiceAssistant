using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CarServiceAssistant.ViewModel;
using CarServiceAssistant.View;

namespace CarServiceAssistant.Utils
{
    class WindowManager
    {
        private ServiceSelection selection;
        private ServiceModification modification;
        private ServiceAdding adding;
        public void OpenModification(int id)
        {
            modification = new ServiceModification();
            modification.DataContext = new ServiceModificationViewModel(id);
            modification.Show();
        }
        public void OpenSelection()
        {
            selection = new ServiceSelection();
            selection.DataContext = new ServiceSelectionViewModel();
            selection.Show();
        }
        public void OpenAdding()
        {
            adding = new ServiceAdding();
            adding.DataContext = new ServiceAddingViewModel();
            adding.Show();
        }
    }
}
