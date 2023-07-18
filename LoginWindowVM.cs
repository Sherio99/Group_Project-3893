using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace Group_project
{

    public partial class LoginWindowVM:ObservableObject
    {
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public string username;
        [ObservableProperty]
        public Admin admin;

        public LoginWindowVM()
        {

        }
        [RelayCommand]
        public void AdminLog()
        {
            var db = new DataContext();
            bool fine = false;
            foreach (var item in db.Admins)
            {
                if (item.Username == username && item.Password == password)
                {
                    fine = true;
                    admin = item;

                }
            }
            if (fine && admin.IsAdmin == true)
            {
                var window = new AdminWinodow();
                window.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
            

            [RelayCommand]
            public void UserLog()
            {
                var db = new DataContext();
                bool fine = false;
                foreach (var item in db.Admins)
                {
                    if (item.Username == username && item.Password == password)
                    {
                        fine = true;
                        admin = item;

                    }
                }
                if (fine && admin.IsAdmin == false)
                {
                    var window = new UserWindow();
                    window.Show();

                }
            else
            {
                MessageBox.Show("Invalid Login");
            }


        }
        }
}
