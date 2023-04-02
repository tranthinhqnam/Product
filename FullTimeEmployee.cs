using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalll
{
    public class Fulltime : Employee
    {
        public Fulltime()
        {
            Type = "Fulltime";
        }

        public override double CalculateSalary() //ghi đè phương thức của lớp cha
        {
            double hourlyRate = 27000;
            return hourlyRate * WorkingHours;
        }
    }
}
