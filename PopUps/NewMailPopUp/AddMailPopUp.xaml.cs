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
using System.Windows.Shapes;

namespace Password_Manager
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class AddMailPopUp : Window
    {
        Database PasswordManager;
        Overview MainPage;
        List<Mail> MailDropdownList = new List<Mail>();

        public AddMailPopUp(Overview current)
        {
            InitializeComponent();
            MainPage = current;
            this.PasswordManager = current.PasswordManager;
            FillCombo();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {   
            this.Close();
        }

        private void inputUsernameButton_Click(object sender, RoutedEventArgs e)
        {
            AddDataToDB.AddMailToDB(PasswordManager, inputMail.Text, MainPage.ListMails);
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!(ComboBoxMail.SelectedIndex == 0))
                RemoveData.RemoveMailDB(PasswordManager, MainPage.ListMails, ComboBoxMail.SelectedIndex);
                this.Close();
        }

        private void FillCombo()
        {
            // Mails
            for (int i = 0; i < (MainPage.ListMails.Mails.Length - 1); i++)
            {
                string curName = MainPage.ListMails.Mails[i].MailName;
                int curID = MainPage.ListMails.Mails[i].Mail_ID;
                int realID = MainPage.ListMails.Mails[i].realMail_ID;

                MailDropdownList.Add(new Mail(realID, curName, curID));
                ComboBoxMail.Items.Add(curName);
            }
        }
    }
}
