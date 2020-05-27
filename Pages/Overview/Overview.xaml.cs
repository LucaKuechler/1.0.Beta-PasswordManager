using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaktionslogik für Overview.xaml
    /// </summary>
    public partial class Overview : Page
    {

        public Database PasswordManager = new Database();
        public Button[] MailContainerArray = new Button[1];
        public int MailContainerItemCount;
        public bool ContainerValue = false;

        OverviewDataContext commands;

        #region CreateDataList
        ///<summary>
        /// DataList is an Object that stores all Icons, Mails and Icons 
        ///</summary>
        public CreateDataList ListIcons = new CreateDataList();
        public CreateDataList ListMails = new CreateDataList();
        public CreateDataList ListAccounts = new CreateDataList();
        #endregion

        public Overview()
        {
            InitializeComponent();

            CreateDataList.CreateAll(PasswordManager, ListAccounts, ListMails, ListIcons);

            DataContext = new OverviewDataContext(this);      
            commands = (OverviewDataContext)DataContext;


            createMailButton(this);
            createAccountButton(this);

            
        }    

        #region create Buttons
        /// <summary>
        /// Dynamically creates MailContainer and MailRoundButton
        /// </summary>
        public void createMailButton(Overview a)
        {
            for(int i = 0; i < (ListMails.Mails.Length - 1); i++)
            {
                if(i == 0)
                    continue;

                Button newBtn = new Button();
                newBtn.Click += new RoutedEventHandler(Mail_Click);

                Style style = a.FindResource("ButtonMailList") as Style;
                newBtn.Style = style;
                newBtn.Content = createNameAlgo(i);
                newBtn.Tag = ListMails.Mails[i].MailName;

                a.MailRoundButtons.Children.Add(newBtn);
                MailRoundButtons.Height = 90 * (i);
            }
        }


        public void createAccountButton(Overview a)
        {
            for (int i = 0; i < (ListAccounts.Accounts.Length - 1); i++)
            {
                string AccName = ListAccounts.Accounts[i].Name;
                string AccMail = ListAccounts.Accounts[i].Mail_Name;

                Button newBtn = new Button();
                newBtn.Name = ("Mail_Container_" + i);

                newBtn.Command = commands.CreateEditWindowCommand;
                newBtn.CommandParameter = i;
                newBtn.Content = AccMail;
                newBtn.DataContext = AccName;
                newBtn.Tag = ListIcons.Icons[ListAccounts.Accounts[i].Icon_ID].createIconPath();
                MailContainerArray[i] = newBtn;
                Array.Resize(ref MailContainerArray, MailContainerArray.Count() + 1);

                newBtn.OnApplyTemplate();

                Style style = FindResource("MailContainer") as Style;
                newBtn.Style = style;

                AccountContainer.Children.Add(newBtn);

                AccountContainer.Height = 112 * (i + 1);
            }
        }
        #endregion


        #region Algo
        public string createNameAlgo(int i)
        {
            string Name = ListMails.Mails[i].MailName;

            string result = string.Concat(Name.Where(c => c >= 'A' && c <= 'Z'));

            if(result == "")
            {
                result = ListMails.Mails[i].MailName.Substring(0, 1);
                result = result.ToUpper();
            }
                
            return result;
        }
        #endregion


        #region Copy Buttons
        /// <summary>
        /// Copy Data to Clipboard
        ///</summary>
        private void Mail_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(ListAccounts.Accounts[MailContainerItemCount].Mail_Name);
        }


        private void Username_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(usernameAnswer.Text);
        }


        private void Password_Copy_Click(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText(ListAccounts.Accounts[MailContainerItemCount].Password);
        }


        private void Web_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(websiteAnswer.Text);
        }
        #endregion


        #region Mail Search Button
        /// <summary>
        /// Click on Mail to search accounts listed on this Mail
        /// </summary>
        private void Mail_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            string searchMailInput = clicked.Tag.ToString();

            AccountContainer.Children.Clear();
            AccountContainer.Height = 0;
            for (int a = 0; a < (ListAccounts.Accounts.Length - 1); a++)
            {
                if (ListAccounts.Accounts[a].Mail_Name.Contains(searchMailInput))
                {
                    AccountContainer.Children.Add(MailContainerArray[a]);
                    AccountContainer.Height += 112;
                }   
            }
        }


        private void Mail_All_Click(object sender, RoutedEventArgs e)
        {
            AccountContainer.Children.Clear();
            for (int b = 0; b < (MailContainerArray.Length - 1); b++)
            {
                AccountContainer.Children.Add(MailContainerArray[b]);
            }
            AccountContainer.Height = 112 * (MailContainerArray.Length - 1);
        }
        #endregion


        #region SearchBar
        /// <summary>
        /// search Bar
        /// </summary>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchBarInput = searchBar.Text;

            if(searchBarInput == "" || searchBarInput ==" ")
            {
                AccountContainer.Children.Clear();
                for (int b = 0; b < (MailContainerArray.Length - 1); b++)
                {
                    AccountContainer.Children.Add(MailContainerArray[b]);
                }
                
                return;
            }

            AccountContainer.Children.Clear();

            for (int a = 0; a < (ListAccounts.Accounts.Length - 1);a++)
            {
                if (ListAccounts.Accounts[a].Name.Contains(searchBarInput))
                {
                    AccountContainer.Children.Add(MailContainerArray[a]);
                }
            }
        }

        #endregion

    }

}
