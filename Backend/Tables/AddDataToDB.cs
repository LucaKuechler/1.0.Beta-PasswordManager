using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    class AddDataToDB
    {
        #region AddMailToDB
        ///<summary>
        /// add an element to the sql DB 
        ///</summary>
        public static void AddMailToDB(Database PasswordManager, string input, CreateDataList ListMails)
        {
            string query = "INSERT INTO Mails VALUES (@MailName, @Mail_ID)";

            SQLiteCommand addMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            addMail.Parameters.AddWithValue("MailName", input);
            addMail.Parameters.AddWithValue("Mail_ID", null);
            addMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();

        }

        #endregion


        #region AddAccountToDB
        ///<summary>
        /// add an element to the sql DB 
        ///</summary>
        public static void AddAccountToDB(Database PasswordManager, CreateDataList ListAccount, int[] ID_List, string[] Value_List)
        {


            string query = "INSERT INTO Accounts VALUES (@ID, @Username, @Password, @Mail_ID, @Notes, @Website, @Name, @Icon_ID)";

            SQLiteCommand addMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            addMail.Parameters.AddWithValue("ID", null); // because aa
            addMail.Parameters.AddWithValue("Name", Value_List[0]);
            addMail.Parameters.AddWithValue("Username", Value_List[1]);
            addMail.Parameters.AddWithValue("Password", Value_List[2]);
            addMail.Parameters.AddWithValue("Notes", Value_List[3]);
            addMail.Parameters.AddWithValue("Website", Value_List[4]);
            addMail.Parameters.AddWithValue("Mail_ID", ID_List[0]);
            addMail.Parameters.AddWithValue("Icon_ID", ID_List[1]);
            addMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();

        }
        #endregion

    }
}
