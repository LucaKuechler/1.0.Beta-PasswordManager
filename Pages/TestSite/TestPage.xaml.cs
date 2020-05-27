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
    /// Interaktionslogik für TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        List<Mail> MailDropdownList = new List<Mail>();
        List<Icon> IconDropdownList = new List<Icon>();
        Database PasswordManager;
        Overview MainPage;

        public TestPage(Overview current, Database PasswordManager)
        {
            InitializeComponent();
            MainPage = current;
            this.PasswordManager = PasswordManager;
        }
    }
}
