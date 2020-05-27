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
    class DeleteExitButton : ICommand
    {
        public event EventHandler CanExecuteChanged;
        EditAccount cur;
        Overview mainPage;

        public DeleteExitButton(Overview mainPage, EditAccount cur)
        {
            this.mainPage = mainPage;
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int ElementCounter = mainPage.MailContainerItemCount;

            RemoveData.RemoveAccountDB(mainPage.PasswordManager, mainPage.ListAccounts, mainPage.ListAccounts.Accounts[ElementCounter].RealID);
            cur.NavigationService.Navigate(new Overview());
        }
    }
}
