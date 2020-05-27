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
    class targetName : ICommand
    {
        public event EventHandler CanExecuteChanged;
        EditAccount cur;

        public targetName(EditAccount cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cur.inputName.Focus();
            cur.inputName.CaretIndex = cur.inputName.Text.Length;
        }
    }
}
