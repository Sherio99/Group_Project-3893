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
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using System.Windows.Data;

namespace Group_project
{
    public partial class UserWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student selectedStudent;
        
        public UserWindowVM() { 
            var db=new DataContext();
            var list=db.Students.ToList();
            students = new ObservableCollection<Student>(list);
        }

        [RelayCommand]
        public void Update()
        {
            if(selectedStudent != null)
            {
                var vm = new StudentRegistrationVM(selectedStudent);
                var window = new StudentRegistration(vm);
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
            var vm = new StudentRegistrationVM();
            var window = new StudentRegistration(vm);
            window.Show();

        }
        [RelayCommand]
        public void Delete()
        {
            if(selectedStudent != null)
            {
                var db=new DataContext();
               Student u = db.Students.FirstOrDefault(user => user.Id == selectedStudent.Id);
                if(u != null)
                {
                    db.Students.Remove(u);
                    db.SaveChanges();   
                    students.Remove(selectedStudent);
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
            CollectionViewSource.GetDefaultView(students).Refresh();

        }

    }
}
