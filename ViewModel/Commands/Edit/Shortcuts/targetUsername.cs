using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Password_Manager
{
    class targetUsername : ICommand
    {
        public event EventHandler CanExecuteChanged;
        EditAccount cur;

        public targetUsername(EditAccount cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cur.inputUsername.Focus();
            cur.inputUsername.CaretIndex = cur.inputUsername.Text.Length;
        }
    }
}
