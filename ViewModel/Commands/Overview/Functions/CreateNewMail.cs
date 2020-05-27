using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Input;

namespace Password_Manager
{
    class CreateNewMail : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Overview cur;

        public CreateNewMail(Overview cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            AddMailPopUp w = new AddMailPopUp(cur);
            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Nullable<bool> dialogResult = w.ShowDialog();
            cur.NavigationService.Navigate(new Overview());
        }
    }
}
