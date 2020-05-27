using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace Password_Manager
{
    public class Database
    {

        public SQLiteConnection mainConnection;


        #region database constructor
        /// <summary>
        /// CREATE DATABASE CONNECTION
        /// </summary>
        public Database()
        {
            mainConnection = new SQLiteConnection("Data Source=database.sqlite3");
        }
        #endregion


        #region connection status
        public void OpenConnection()
        {
            if (mainConnection.State != System.Data.ConnectionState.Open)
            {
                mainConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (mainConnection.State != System.Data.ConnectionState.Closed)
            {
                mainConnection.Close();
            }
        }
        #endregion

    }

    public class DatabaseBackUp
    {
        public static void BackUpData()
        {
            #region Variabels
            List<DateTime> allDates = new List<DateTime>();
            string DatabaseName = "database.sqlite3";
            string newFileName = CreateNewFilename();
            int max = 3;
            #endregion


            #region Path Control

            // get app directory
            string binPath = System.IO.Directory.GetCurrentDirectory();

            // go to backup folder
            string backupPath = binPath + @"\backup\";

            // get the original Database
            string binPathFile = System.IO.Path.Combine(binPath, DatabaseName);

            // get the new backup Database 
            string backupPathFile = System.IO.Path.Combine(backupPath, DatabaseName);

            // change name from copied original Database to DateTimer DB
            string backupPathNewFile = System.IO.Path.Combine(backupPath, newFileName);

            // create Path for each Files in BackUps
            string[] allFiles = System.IO.Directory.GetFiles(backupPath);
            string[] backupFiles = new string[1];
            #endregion


            #region create and update array
            //remove Path from DateTimer DB and save name in allDates List 
            for (int i = 0; i < allFiles.Length; i++)
            {
                string _file = allFiles[i].Replace(backupPath, "");
                DateTime asd;

                #region test purposes
                try
                {
                    asd = convertToDateTime(_file);
                }
                catch
                {
                    continue;
                }
                #endregion

                asd = convertToDateTime(_file);
                allDates.Add(asd);

                backupFiles[backupFiles.Length - 1] = allFiles[i];
                Array.Resize(ref backupFiles, (backupFiles.Length + 1));

            }
            Array.Resize(ref backupFiles, (backupFiles.Length - 1));

            #region reduce list to 2 Elements
            if (backupFiles.Length >= max) // if list to big do something
            {

                int diff = backupFiles.Length - max;

                for (int i = 0; i <= diff; i++)
                {
                    int oldestIndex = 0;
                    DateTime oldestElement = allDates[0];

                    for (int a = 0; a < backupFiles.Length; a++)
                    {
                        if (DateTime.Compare(oldestElement, allDates[a]) == 1)
                        {
                            oldestElement = allDates[a];
                            oldestIndex = a;
                        }
                    }

                    System.IO.File.Delete(backupFiles[oldestIndex]); // remove from explorer
                    allDates.RemoveAt(oldestIndex); // remove from DateTimer List
                    backupFiles = resizeArray(backupFiles, oldestIndex); // update FileList
                }

            }
            #endregion

            // copy Database to Backup Folder
            System.IO.File.Copy(binPathFile, backupPathFile, true);

            // rename new DB file to DateTimer DB
            System.IO.File.Move(backupPathFile, backupPathNewFile);
            #endregion

        }


        #region CreateNewFileName
        public static string CreateNewFilename()
        {
            DateTime name = DateTime.Now;

            string[] TimeStrings = new string[6];
            TimeStrings[0] = name.Day.ToString();    // day
            TimeStrings[1] = name.Month.ToString();  // month
            TimeStrings[2] = name.Year.ToString();   // year
            TimeStrings[3] = name.Hour.ToString();   // hour
            TimeStrings[4] = name.Minute.ToString(); // min
            TimeStrings[5] = name.Second.ToString(); // sec

            if (Convert.ToInt32(TimeStrings[1]) <= 9)
                TimeStrings[1] = TimeStrings[1].Insert(0, "0");

            if (Convert.ToInt32(TimeStrings[0]) <= 9)
                TimeStrings[0] = TimeStrings[0].Insert(0, "0");


            string exitName = TimeStrings[0] + "-" + TimeStrings[1] + "-" + TimeStrings[2] + "_" + TimeStrings[3] + "'" + TimeStrings[4] + "'" + TimeStrings[5] + ".sqlite3";

            return exitName;
        }
        #endregion


        #region Converter
        public static DateTime convertToDateTime(string input)
        {

            string[] inputElements = input.Split(new char[] { '-', '_', '\'', '.' });
            int[] exportElements = new int[6];


            for (int i = 0; i < (inputElements.Length - 1); i++)
            {
                exportElements[i] = Convert.ToInt32(inputElements[i]);
            }

            DateTime curTime = new DateTime(exportElements[2], exportElements[1], exportElements[0], exportElements[3], exportElements[4], exportElements[5]);

            return curTime;
        }
        #endregion


        #region resize Array
        public static string[] resizeArray(string[] Elements, int index)
        {
            for (int i = index; i < (Elements.Length - 1); i++)
            {
                Elements[i] = Elements[i + 1];
            }
            Array.Resize(ref Elements, Elements.Length - 1);

            return Elements;
        }
        #endregion
    }
}
