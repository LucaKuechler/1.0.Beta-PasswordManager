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
    class CreateEditWindow : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Overview cur;

        public CreateEditWindow(Overview cur)
        {
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int i = Convert.ToInt32(parameter);

            cur.ContainerValue = true;
            cur.MailContainerItemCount = i;
            cur.AccountInformation.Visibility = Visibility.Visible;

            cur.iconAnswer.Source = cur.ListIcons.Icons[cur.ListAccounts.Accounts[i].Icon_ID].createIconFile();
            cur.nameAnswer.Text = cur.ListAccounts.Accounts[i].Name;
            cur.usernameAnswer.Text = cur.ListAccounts.Accounts[i].Username;
            cur.websiteAnswer.Text = cur.ListAccounts.Accounts[i].Website;
            cur.notesAnswer.Text = cur.ListAccounts.Accounts[i].Notes;

        }
    }
}
