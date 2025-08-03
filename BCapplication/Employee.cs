using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCapplication
{
    internal class Employee
    {
        string name, surname, empID;
        double salary;
        
        public Employee() //Default 
        {

        }

        public Employee(string ename, string esurname, string eempID) //Parameterised Constructor 
        {
            this.Name = ename;
            this.Surname = esurname;
            this.EmpID = eempID;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()// override space 
        {
            return $"{Name} {Surname} {EmpID} {Salary:C2}";
        }

        public virtual void calculateSalary()
        {
            Salary = 0.00;
        }
    }
}
