using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Diagnostics;

namespace Password_Manager
{
    class BackEditButton : ICommand
    {
        public event EventHandler CanExecuteChanged;
        EditAccount cur;

        public BackEditButton(EditAccount cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cur.NavigationService.GoBack();
        }
    }
}
