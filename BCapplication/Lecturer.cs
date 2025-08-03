using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BCapplication
{
    internal class Lecturer:Employee
    {
        string course;
        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }

        // Constructor Inheritance 
        public Lecturer():base()
        {

        }
        public Lecturer(string ename, string esurname, string eempID,string lcourse):base(ename,esurname,eempID)
        {
            this.Course = lcourse;
        }

        public override void calculateSalary()
        {
            Salary = 100000.00;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Course;
        }

    }
}
