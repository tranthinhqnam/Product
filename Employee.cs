using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalll
{
    public class Employee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int WorkingHours { get; set; }

        public virtual double CalculateSalary() // dùng virtual cho tính đa hình
        {
            return 0;
        }
    }

}
