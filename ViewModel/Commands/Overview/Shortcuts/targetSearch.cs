using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Password_Manager
{
    class targetSearch : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Overview cur;

        public targetSearch(Overview cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            cur.searchBar.Focus();   
        }
    }
}
