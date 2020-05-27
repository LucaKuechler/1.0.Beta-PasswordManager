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


        public static void RemoveMailDB(Database PasswordManager, CreateDataList ListMails, int ElemCounter)
        {
            string query = "DELETE FROM Mails WHERE Mail_ID=:id";

            SQLiteCommand editMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            editMail.Parameters.AddWithValue("id", ListMails.Mails[ElemCounter].realMail_ID);
            editMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();
        }
    }
}
