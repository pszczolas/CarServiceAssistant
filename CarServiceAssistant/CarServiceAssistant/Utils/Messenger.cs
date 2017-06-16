using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace CarServiceAssistant.Utils
{
    class Messenger : IMessenger
    {
        public void ShowOK()
        {
            MessageBox.Show("Success", "Operation status", MessageBoxButton.OK, MessageBoxImage.Information);
        } 
    }
}
