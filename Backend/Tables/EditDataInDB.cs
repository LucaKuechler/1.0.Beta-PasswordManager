using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    class EditDataInDB
    {
        #region EditDataInDB
        ///<summary>
        /// add an element to the sql DB 
        ///</summary>
        public static void EditMailDB(Database PasswordManager, string input, CreateDataList ListMails)
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
        public static void EditAccountDB(Database PasswordManager, CreateDataList ListAccount, int[] ID_List, string[] Value_List)
        {


            string query = "UPDATE Accounts SET Name = :name, Username = :username, Password = :password, Notes = :notes, Website = :website, Mail_ID = :mail_ID,Icon_ID = :icon_ID where ID=:id";

            SQLiteCommand editMail = new SQLiteCommand(query, PasswordManager.mainConnection);
            PasswordManager.OpenConnection();
            editMail.Parameters.AddWithValue("iD", ID_List[2]); // because aa
            editMail.Parameters.AddWithValue("name", Value_List[0]);
            editMail.Parameters.AddWithValue("username", Value_List[1]);
            editMail.Parameters.AddWithValue("password", Value_List[2]);
            editMail.Parameters.AddWithValue("notes", Value_List[3]);
            editMail.Parameters.AddWithValue("website", Value_List[4]);
            editMail.Parameters.AddWithValue("mail_ID", ID_List[0]);
            editMail.Parameters.AddWithValue("icon_ID", ID_List[1]);

            editMail.ExecuteNonQuery();

            PasswordManager.CloseConnection();


        }

        #endregion
    }
}
