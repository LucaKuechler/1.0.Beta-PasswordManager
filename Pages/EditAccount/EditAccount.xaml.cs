using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Password_Manager
{
    /// <summary>
    /// Interaktionslogik für EditAccount.xaml
    /// </summary>

    public partial class EditAccount : Page
    {
        List<Mail> MailDropdownList = new List<Mail>();
        List<Icon> IconDropdownList = new List<Icon>();
        Database PasswordManager;
        Overview MainPage;
        int ElementCounter;

        public EditAccount(Overview current, int ElementCounter)
        {
            InitializeComponent();
            this.DataContext = new EditDataContext(current, this);
            MainPage = current;
            this.PasswordManager = current.PasswordManager;
            this.ElementCounter = ElementCounter;
            FillText();
            FillIconCombo();

            inputName.Focus();
            inputName.CaretIndex = inputName.Text.Length;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Overview());
        }



        private void FillText()
        {
            Icon.Source = MainPage.ListIcons.Icons[MainPage.ListAccounts.Accounts[ElementCounter].Icon_ID].createIconFile();
            inputName.Text = MainPage.ListAccounts.Accounts[ElementCounter].Name;
            inputUsername.Text = MainPage.ListAccounts.Accounts[ElementCounter].Username;
            inputPassword.Text = MainPage.ListAccounts.Accounts[ElementCounter].Password;
            inputNotes.Text = MainPage.ListAccounts.Accounts[ElementCounter].Notes;
            inputWeb.Text = MainPage.ListAccounts.Accounts[ElementCounter].Website;
        }


        private void FillIconCombo()
        {
            // Icons
            for (int i = 0; i < (MainPage.ListIcons.Icons.Length - 1); i++)
            {
                string curName = MainPage.ListIcons.Icons[i].IconName;
                int curID = MainPage.ListIcons.Icons[i].Icon_ID;

                IconDropdownList.Add(new Icon(curName, null, curID));
                ComboBoxIcon.Items.Add(curName);
            }
            ComboBoxIcon.SelectedIndex = MainPage.ListAccounts.Accounts[ElementCounter].Icon_ID;


            // Mails
            for (int i = 0; i < (MainPage.ListMails.Mails.Length - 1); i++)
            {
                string curName = MainPage.ListMails.Mails[i].MailName;
                int curID = MainPage.ListMails.Mails[i].Mail_ID;
                int realID = MainPage.ListMails.Mails[i].realMail_ID;

                MailDropdownList.Add(new Mail(realID, curName, curID));
                ComboBoxMail.Items.Add(curName);         
            }
            ComboBoxMail.SelectedIndex = MainPage.ListAccounts.Accounts[ElementCounter].Mail_ID;
        }


        #region Button Paste
        /// <summary>
        /// input Button Paste
        /// </summary>
        private void inputUsernameButton_Click(object sender, RoutedEventArgs e)
        {
            string inputPasteUsername = Clipboard.GetText();
            inputUsername.Text = inputPasteUsername;
        }

        private void inputPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string inputPastePassword = Clipboard.GetText();
            inputPassword.Text = inputPastePassword;
        }

        private void inputWebButton_Click(object sender, RoutedEventArgs e)
        {
            string inputPasteMail = Clipboard.GetText();
            inputWeb.Text = inputPasteMail;
        }

        private void inputNameButton_Click(object sender, RoutedEventArgs e)
        {
            string inputPasteName = Clipboard.GetText();
            inputName.Text = inputPasteName;
        }

        #endregion

    }
}
