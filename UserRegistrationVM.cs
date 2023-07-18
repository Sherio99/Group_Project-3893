using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Group_project
{
    public partial class UserRegistrationVM : ObservableObject
    {
        [ObservableProperty]
        int id;
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        public string password;
        [ObservableProperty]
        public bool isadmin;
        [ObservableProperty]
        public Admin adm;

        public UserRegistrationVM()
        {

        }

        public UserRegistrationVM(Admin admin)
        {
            adm = admin;
            id = admin.Id;
            name = admin.Name;
            userName = admin.Username;
            password = admin.Password;
            isadmin = admin.IsAdmin;
           
        }

        [RelayCommand]
        public void Save()
        {
            if (adm == null)
            {
                adm = new Admin();
                adm.Id = id;
                adm.Name = name;
                adm.Username = userName;
                adm.Password = password;
                adm.IsAdmin = isadmin;
                if (adm.IsAdmin)
                {
                    var db = new DataContext();
                    db.Admins.Add(adm);
                    db.SaveChanges();
                    MessageBox.Show("Succesfully Added A New Admin");
                    var window = new AdminWinodow();
                    window.Show();

                }
                else
                {
                    var db=new DataContext(); 
                    db.Admins.Add(adm);
                    db.SaveChanges ();
                    MessageBox.Show("Succesfully Added A New User");
                    var window = new AdminWinodow();
                    window.Show();
                }


            }
            else
            {
                adm.Id = id;
                adm.Name = name;
                adm.Username = userName;
                adm.Password = password;
                adm.IsAdmin = isadmin;
               var db = new DataContext();
                    Admin m=db.Admins.FirstOrDefault(a=>a.Id == adm.Id);
                    if(m!= null)
                    {
                        db.Admins.Remove(m);
                        db.SaveChanges();
                        db.Admins.Add(adm);
                        db.SaveChanges();

                        MessageBox.Show("Succesfully Edited The Selected Admin");
                    var window = new AdminWinodow();
                    window.Show();
                }
           
            }

        }


     }
 }

