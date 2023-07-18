using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace Group_project
{
    public partial class AdminPageWindowVM: ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Admin> users;
        [ObservableProperty]
        public Admin selectedUser;

        public AdminPageWindowVM()
        {
            var db = new DataContext();
            var list = db.Admins.ToList();
            users = new ObservableCollection<Admin>(list);
        }

        [RelayCommand]
        public void Update()
        {
            if (selectedUser != null)
            {
                var vm = new UserRegistrationVM(selectedUser);
                var window = new UserRegistration(vm);
                window.Show();
            }
            else
            {
                MessageBox.Show("Please Select A Student");
                return;
            }

        }
        [RelayCommand]
        public void Create()
        {
            var vm = new UserRegistrationVM();
            var window = new UserRegistration(vm);
            window.Show();

        }
        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                var db = new DataContext();
               Admin u = db.Admins.FirstOrDefault(user => user.Id == selectedUser.Id);
                if (u != null)
                {
                    db.Admins.Remove(u);
                    db.SaveChanges();
                    users.Remove(SelectedUser);
                    MessageBox.Show("Succesfully Deleted");


                }

            }
            else
            {
                MessageBox.Show("Please Select Student");
            }
        }
        [RelayCommand]
        public void Refresh()
        {
            CollectionViewSource.GetDefaultView(users).Refresh();
        }
    }
}
