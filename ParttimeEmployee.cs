using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalll
{
    public class Parttime : Employee
    {
        public Parttime()
        {
            Type = "Parttime";
        }

        public override double CalculateSalary() //ghi đè phương thức của lớp cha
        {
            double hourlyRate = 23000;
            return hourlyRate * WorkingHours;
        }
    }
}
