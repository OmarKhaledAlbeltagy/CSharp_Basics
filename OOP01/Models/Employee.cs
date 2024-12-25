using OOP01.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01.Models
{
    internal class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Permissions Permissions { get; set; }
    }
}
