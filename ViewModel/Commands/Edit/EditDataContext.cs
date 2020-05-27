using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Password_Manager
{
    class EditDataContext
    {
        EditAccount editPage;
        Overview mainPage;

        #region Shortcuts
        /// <summary>
        /// All Shortcuts will be defined here
        /// </summary>

            #region go to name
            ICommand targetName;

            public ICommand targetNameCommand
            {
                get { return targetName; }
            }
            #endregion


            #region go to notes
            ICommand targetNotes;

            public ICommand targetNotesCommand
            {
                get { return targetNotes; }
            }
            #endregion


            #region go to password
            ICommand targetPassword;

            public ICommand targetPasswordCommand
            {
                get { return targetPassword; }
            }
            #endregion


            #region go to username
            ICommand targetUsername;

            public ICommand targetUsernameCommand
            {
                get { return targetUsername; }
            }
            #endregion


            #region go to website
            ICommand targetWebsite;

            public ICommand targetWebsiteCommand
            {
                get { return targetWebsite; }
            }
            #endregion


        #endregion


        #region Functions
        /// <summary>
        /// All Functions will be defined here
        /// </summary>

        #region add new account to database
        ICommand BackEditButton;

            public ICommand BackEditButtonCommand
            {
                get { return BackEditButton; }
            }
            #endregion


            #region delete selected account from database
            ICommand DeleteExitButton;

            public ICommand DeleteExitButtonCommand
            {
                get { return DeleteExitButton; }
            }
            #endregion


            #region saves selected account in database
            ICommand SaveExitButton;

            public ICommand SaveExitButtonCommand
            {
                get { return SaveExitButton; }
            }
            #endregion

        #endregion

        public EditDataContext(Overview mainPage, EditAccount editPage)
        {
            #region global definition
            this.mainPage = mainPage;
            this.editPage = editPage;
            #endregion

            #region Shortcut Object
            targetName = new targetName(editPage);
            targetUsername = new targetUsername(editPage);
            targetPassword = new targetPassword(editPage);
            targetWebsite = new targetWebsite(editPage);
            targetNotes = new targetNotes(editPage);
            #endregion


            #region Function Object
            BackEditButton = new BackEditButton(editPage);
            DeleteExitButton = new DeleteExitButton(mainPage, editPage);
            SaveExitButton = new SaveExitButton(mainPage, editPage);
            #endregion
        }


    }
}
