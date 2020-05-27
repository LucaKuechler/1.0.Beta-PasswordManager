using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Password_Manager
{
    class CreateDataContext
    {
        CreateAccount createPage;
        Overview mainPage;

        #region Shortcuts
        /// <summary>
        /// All Shortcuts will be defined here
        /// </summary>


        #endregion


        #region Functions
        /// <summary>
        /// All Functions will be defined here
        /// </summary>
    
            #region add new account to database
            ICommand AddAccountButton;

            public ICommand AddAccountButtonCommand
            {
                get { return AddAccountButton; }
            }
            #endregion


            #region go back to main
            ICommand BackAccountButton;

            public ICommand BackAccountButtonCommand
        {
                get { return BackAccountButton;  }
            }
            #endregion


        #endregion

        public CreateDataContext(Overview mainPage, CreateAccount createPage)
        {
            #region global definition
            this.mainPage = mainPage;
            this.createPage = createPage;
            #endregion

            #region Shortcut Object

            #endregion


            #region Function Object
            AddAccountButton = new AddAccountButton(mainPage, createPage);
            BackAccountButton = new BackAccountButton(createPage);
            #endregion
        }


    }
}
