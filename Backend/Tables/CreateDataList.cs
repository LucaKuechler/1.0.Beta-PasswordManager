using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace Password_Manager
{
    public class CreateDataList
    {
        public Icon[] Icons = new Icon[1];
        public Mail[] Mails = new Mail[1];
        public Account[] Accounts = new Account[1];

        #region Create different lists of objects
        /// <summary>
        /// create everything
        /// </summary>
        public static void CreateAll(Database PasswordManager, CreateDataList ListAccounts, CreateDataList ListMails, CreateDataList ListIcons)
        {
            ListAccounts.CreateAccounts(PasswordManager);
            ListMails.CreateMails(PasswordManager);
            ListIcons.CreateIcons(PasswordManager);
            ListAccounts.ExchangeIDToName(ListIcons, ListMails, PasswordManager);
        }

        #region CreateAccounts
        /// <summary>
        ///  Read out all data from accounts and store it in object account
        /// </summary>
        public void CreateAccounts(Database PasswordManager)
        {
            int i = 0;
            string query = "SELECT * FROM Accounts";

            SQLiteCommand presentIcons = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            SQLiteDataReader result = presentIcons.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    var Real_IdData = Convert.ToInt32(result["ID"]);
                    var UsernameData = result["Username"].ToString();
                    var PasswordData = result["Password"].ToString();
                    var Mail_IDData = Convert.ToInt32(result["Mail_ID"]);
                    var Notes = result["Notes"].ToString();
                    var Website = result["Website"].ToString();
                    var Name = result["Name"].ToString();
                    var Icon_ID = Convert.ToInt32(result["Icon_ID"]);

                    Account Object = new Account(Real_IdData, UsernameData, PasswordData, Mail_IDData, Notes, Website, Name, Icon_ID, i);
                    Accounts[i] = Object;

                    Array.Resize(ref Accounts, Accounts.Count() + 1);
                    i++;
                }
                PasswordManager.CloseConnection();
            }

        }
        #endregion


        #region CreateMails
        /// <summary>
        ///  Read out all data from mails store it in object mail
        /// </summary>
        public void CreateMails(Database PasswordManager)
        {
            int i = 0;
            string query = "SELECT * FROM Mails";

            SQLiteCommand presentIcons = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            SQLiteDataReader result = presentIcons.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    var MailNameData = result["MailName"];
                    var real_ID = Convert.ToInt32(result["Mail_ID"]);

                    Mail Object = new Mail(real_ID, MailNameData.ToString(), i);
                    Mails[i] = Object;

                    Array.Resize(ref Mails, Mails.Count() + 1);
                    i++;
                }
                PasswordManager.CloseConnection();
            }
        }
        #endregion


        #region CreateIcons
        /// <summary>
        ///  Read out all data from icons store it in object icons
        /// </summary>
        public void CreateIcons(Database PasswordManager)
        {
            int i = 0;
            string query = "SELECT * FROM Icons";

            SQLiteCommand presentIcons = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            SQLiteDataReader result = presentIcons.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    var IconNameData = result["IconName"];
                    var FileName = result["FileName"];

                    Icon Object = new Icon(IconNameData.ToString(), FileName.ToString(), i);
                    Icons[i] = Object;

                    Array.Resize(ref Icons, Icons.Count() + 1);
                    i++;
                }
                PasswordManager.CloseConnection();
            }
        }
        #endregion

        #endregion


        #region ExchangeIDToName
        /// <summary>
        /// grab ID from account and store value in accounts compared to the primary key from Icons or Mails
        /// </summary>
        public void ExchangeIDToName(CreateDataList IconList, CreateDataList ListMails, Database Passwordmanager)
        {
            for(int i = 0; i  < Accounts.Length - 1; i++)
            {
                var Icon_Code = Accounts[i].Icon_ID;
                Accounts[i].Icon_Name = IconList.Icons[Icon_Code].IconName;

                var Mail_Code_Test = Accounts[i].Mail_ID;

                if(ListMails.Mails[Mail_Code_Test] == null)
                {      
                    Accounts[i].Mail_Name = "missing";
                    Accounts[i].Mail_ID = ListMails.Mails[0].Mail_ID;
                }
                else
                {
                    Accounts[i].Mail_Name = ListMails.Mails[Mail_Code_Test].MailName;
                }

            }
        }
        #endregion
 
    }
}
