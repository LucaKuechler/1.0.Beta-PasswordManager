using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Password_Manager
{
    public class Icon
    {

        #region DataIcon
        public string IconName { get; set; }
        public int Icon_ID { get; set; }
        public string FileName { get; set; }
        public string IconPath { get; set; }
        #endregion


        #region constructor Icon
        public Icon(string IconName, string FileName, int Icon_ID)
        {
            this.IconName = IconName;
            this.FileName = FileName;
            this.Icon_ID = Icon_ID;
        }
        #endregion


        #region create ImageObject
        public BitmapImage createIconFile()
        {
            string Folder = "Images/" + FileName;

            Uri IconPath = new Uri("/Password Manager;component/Resources/Images/CompanyIcon/" + FileName, UriKind.Relative);
            BitmapImage IconFile = new BitmapImage(IconPath);
            return IconFile;
        }
        #endregion


        #region create ImagePath
        public string createIconPath()
        {
            string Folder = "../../../Resources/Images/CompanyIcon/" + FileName;

            Uri IconPath = new Uri("/Password Manager;component/Resources/Images/CompanyIcon/" + FileName, UriKind.Relative);
            return Folder;
        }
        #endregion

    }
}
