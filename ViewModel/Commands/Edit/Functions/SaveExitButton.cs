﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Password_Manager
{
    class SaveExitButton : ICommand
    {
        public event EventHandler CanExecuteChanged;
        EditAccount cur;
        Overview mainPage;

        public SaveExitButton(Overview mainPage, EditAccount cur)
        {
            this.mainPage = mainPage;
            this.cur = cur;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int ElementCounter = mainPage.MailContainerItemCount;

            int Mail = cur.ComboBoxMail.Items.IndexOf(cur.ComboBoxMail.SelectedItem);
            int Icon = cur.ComboBoxIcon.Items.IndexOf(cur.ComboBoxIcon.SelectedItem);

            int[] ID_List =
            {
                Mail,
                Icon,
                mainPage.ListAccounts.Accounts[ElementCounter].RealID
            };

            string[] Value_List =
            {
                cur.inputName.Text.Trim(), //
                cur.inputUsername.Text.Trim(),
                cur.inputPassword.Text.Trim(), //
                cur.inputNotes.Text.Trim(),
                cur.inputWeb.Text.Trim()
            };

            if (Value_List[1] == "" || Value_List[1] == " ") { Value_List[1] = null; } //username
            if (Value_List[3] == "" || Value_List[3] == " ") { Value_List[3] = null; } //notes
            if (Value_List[4] == "" || Value_List[4] == " ") { Value_List[4] = null; } //website

            if (!(Value_List[2] == "" || Value_List[2] == " " || Value_List[0] == "" || Value_List[0] == " "))
            {
                EditDataInDB.EditAccountDB(mainPage.PasswordManager, mainPage.ListAccounts, ID_List, Value_List);
                cur.NavigationService.Navigate(new Overview());
            }
        }
    }
}
