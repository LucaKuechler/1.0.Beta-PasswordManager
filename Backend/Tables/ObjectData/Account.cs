using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class Account
    {

        #region AccountData
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Mail_ID { get; set; }
        public string Notes { get; set; }
        public string Website { get; set; }
        public string Name { get; set; }
        public int Icon_ID { get; set; }
        public string Icon_Name { get; set; }
        public string Mail_Name { get; set; }
        public int RealID { get; set; }
        #endregion


        #region constructor Account
        public Account(int RealID, string Username, string Password, int Mail_ID,  string Notes, string Website, string Name, int Icon_ID, int ID)
        {
            this.RealID = RealID;
            this.Username = Username;
            this.Password = Password;
            this.Mail_ID = Mail_ID;
            this.Notes = Notes;
            this.Website = Website;
            this.Name = Name;
            this.Icon_ID = Icon_ID;
            this.ID = ID;
        }
        #endregion
    }
}
