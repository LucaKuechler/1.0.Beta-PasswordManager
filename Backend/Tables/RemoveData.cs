using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    class RemoveData
    {
        public static void RemoveAccountDB(Database PasswordManager, CreateDataList ListAccount, int realID)
        {
            string query = "DELETE FROM Accounts WHERE ID=:id";

            SQLiteCommand editMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            editMail.Parameters.AddWithValue("id", realID);
            editMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();
        }


        public static void RemoveMailDB(Database PasswordManager, CreateDataList ListMails, int ElemCounter, Overview mainPage)
        {
            string query = "DELETE FROM Mails WHERE Mail_ID=:id";

            SQLiteCommand editMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            editMail.Parameters.AddWithValue("id", ListMails.Mails[ElemCounter].realMail_ID);
            editMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();

            fitAccounts(PasswordManager, ElemCounter, mainPage);
        }


        public static void fitAccounts(Database PasswordManager, int ElemCounter, Overview mainPage)
        {
            for(int i = 0; i < (mainPage.ListAccounts.Accounts.Length - 1); i++)
            {
                int curID = mainPage.ListAccounts.Accounts[i].Mail_ID; 

                if(curID >= ElemCounter)
                {
                    string query = "UPDATE Accounts SET Mail_ID = :mail_ID where ID=:id";

                    SQLiteCommand editMail = new SQLiteCommand(query, PasswordManager.mainConnection);
                    PasswordManager.OpenConnection();
                    editMail.Parameters.AddWithValue("iD", mainPage.ListAccounts.Accounts[i].RealID);
                    editMail.Parameters.AddWithValue("mail_ID", (curID - 1));

                    editMail.ExecuteNonQuery();

                    PasswordManager.CloseConnection();
                }
                
            }
            
        }
    }
}
