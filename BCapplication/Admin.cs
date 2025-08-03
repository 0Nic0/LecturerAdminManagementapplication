using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCapplication
{
    internal class Admin:Employee
    {
        double commission;

        public double Commision
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

        public Admin() : base()
        {

        }
        public Admin(string ename, string esurname, string eempID, double acommision) : base(ename, esurname, eempID)
        {
            this.Commision = acommision;
        }

        public override void calculateSalary()
        {
            Salary = 25000 + Commision;
        }
    }
}
