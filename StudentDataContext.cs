using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Group_project
{
    public class DataContext : DbContext
    {

        //public string path = @"F:\GUI Project\Group\Save Files\Group Project 3.3\Database.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Dbase.db");
        }

        public DbSet<Admin> Admins { get; set; }
        
        public DbSet<Student> Students { get; set; }

    }
}
