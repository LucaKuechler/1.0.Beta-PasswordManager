using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Password_Manager
{
    class EditCurrentAccount : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Overview cur;

        public EditCurrentAccount(Overview cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {   
            return true;
        }

        public void Execute(object parameter)
        {
            if(cur.ContainerValue == true)
            {
                int i = cur.MailContainerItemCount;

                cur.NavigationService.Navigate(new EditAccount(cur, i));
            }
            
        }
    }
}
