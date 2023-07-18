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
using System.Xml.Schema;

namespace Group_project
{
    public partial class StudentRegistrationVM : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string department;
        [ObservableProperty]
        public Student s;
        [ObservableProperty]
        public ObservableCollection<ModuleClass> modules;

        [ObservableProperty]
        public double gp;

        [ObservableProperty]
        public double marks1;
        [ObservableProperty]
        public double marks2;
        [ObservableProperty]
        public double marks3;

        public StudentRegistrationVM() {
            modules = new ObservableCollection<ModuleClass>();


        }
        public StudentRegistrationVM(Student student)
        {
            id=student.Id; 
            name=student.Name;
            department=student.Department;
            s = student;
            modules = new ObservableCollection<ModuleClass>();



        }
        [RelayCommand]
        public void SaveStudent()
        {
            ModuleClass module1 = new ModuleClass();
            ModuleClass module2 = new ModuleClass();
            ModuleClass module3 = new ModuleClass();
            module1.ModuleName = "Analog Electronics";
            module1.Credit = 3;
            module1.Id = "EE4310";
            module2.ModuleName = "GUI Programming";
            module2.Credit = 2;
            module2.Id = "EE4215";
            module2.ModuleName = "Data Structures";
            module2.Credit = 3;
            module2.Id = "EE4325";
            module1.Marks = marks1;
            module2.Marks = marks2;
            module3.Marks = marks3;

            modules.Add(module1);
            modules.Add(module2);
            modules.Add(module3);
            double total = 0;
            int totalcredits = 0;
            foreach (var module in modules)
            {
               
                if(module.Marks>=75 && module.Marks <= 100)
                {
                    total = total + 4*module.Credit;
                    totalcredits = totalcredits + module.Credit;

                }
                else if(module.Marks > 65)
                {
                    total = total + 3 * module.Credit;
                    totalcredits = totalcredits + module.Credit;

                }
                else if (module.Marks > 50)
                {
                    total = total + 2 * module.Credit;
                    totalcredits = totalcredits + module.Credit;

                }
                else if (module.Marks > 35)
                {
                    total = total + 1 * module.Credit;
                    totalcredits = totalcredits + module.Credit;

                }
                else if (module.Marks >= 0)
                {
                    total = total + 0 * module.Credit;
                    totalcredits = totalcredits + module.Credit;

                }
                else
                {
                    MessageBox.Show("inavlid input");
                    return;
                }
            }
            double gpa=total/totalcredits;
            var db = new DataContext();
            if (s == null)
            {
                s = new Student();
                var db2=new DataContext();
                s.Name = name;
                s.Department = department;
                s.Gpa=gpa;
                db.Add(s);
                db.SaveChanges();
                var window = new UserWindow();
                window.Show();

                MessageBox.Show(" GPA value is", gpa.ToString());
                MessageBox.Show("Succesfully Added the Student");

              
            }
            else
            {
                var db3=new DataContext();
                s.Name = name;
                s.Department = department;
                s.Gpa = gpa;
                var stu=db3.Students.FirstOrDefault(st=>st.Id==s.Id);
                db.Students.Remove(stu);
                db.SaveChanges();
                db.Students.Add(s);
                db.SaveChanges();
                var window = new UserWindow();
                window.Show();
                MessageBox.Show(" GPA value is", gpa.ToString());
                MessageBox.Show("Succesfully Edited the Student");


            }
            
        }
      
    }
}
