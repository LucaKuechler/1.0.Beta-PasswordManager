using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Password_Manager
{
    class OverviewDataContext
    {
        Overview mainPage;

        #region Shortcuts

            #region reload Page
            ICommand reloadPage;

            public ICommand reloadPageCommand
            {
                get { return reloadPage; }
            }
            #endregion


            #region instant search in searchbar
            ICommand targetSearch;

            public ICommand targetSearchCommand
            {
                get { return targetSearch; }
            }
            #endregion

        #endregion


        #region Functions

            #region createEditWindow
            ICommand CreateEditWindow;

            public ICommand CreateEditWindowCommand
            {
                get { return CreateEditWindow; }
            }
            #endregion


            #region EditCurrentAccount
            ICommand EditCurrentAccount;

            public ICommand EditCurrentAccountCommand
            {
                get { return EditCurrentAccount; }
            }
            #endregion


            #region create new account
            ICommand CreateNewAccount;

            public ICommand CreateNewAccountCommand
            {
                get { return CreateNewAccount; }
            }
            #endregion


            #region create new mail window
            ICommand CreateNewMail;

            public ICommand CreateNewMailCommand
        {
                get { return CreateNewMail; }
            }
            #endregion

        #endregion

        public OverviewDataContext(Overview mainPage)
        {
            #region global definition
            this.mainPage = mainPage;
            #endregion


            #region Shortcut Object

            reloadPage = new reloadPage(mainPage);
            targetSearch = new targetSearch(mainPage);

            #endregion


            #region Function Object

            CreateEditWindow = new CreateEditWindow(mainPage);
            EditCurrentAccount = new EditCurrentAccount(mainPage);
            CreateNewAccount = new CreateNewAccount(mainPage);
            CreateNewMail = new CreateNewMail(mainPage);

            #endregion
        }


    }
}
