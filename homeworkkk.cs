using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkk2.homeworkk
{
    public class employee
    { 
        public string name { get; set; }
        public string surname { get; set; }
        public double salary { get; set; }

        public employee(string name,string surname,double salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }

    }
}
