using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_project
{
    public class ModuleClass

    {
        
        public string Id { get; set; }
      
        public string ModuleName { get; set; }

        public int Credit { get; set; }

        public double Marks { get; set; }
        public ModuleClass() { }

        public ModuleClass(String id, string moduleName, int credit, double marks)
        {
            Id = id;
            ModuleName = moduleName;
            Credit = credit;
            Marks = marks;
        }
    }
}
