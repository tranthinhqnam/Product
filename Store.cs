using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalll
{
    class Store
    {
        public List<Product> Products { get; set; }
        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            // Find the index of the employee in the list
            int index = Employees.FindIndex(e => e.Name == employee.Name);
            if (index != -1)
            {
                // Replace the old employee with the new one
                Employees[index] = employee;
            }
        }

        public void DisplayEmployeeList()
        {
            Console.WriteLine("Employee List:");
            Console.WriteLine("Name\t\tType\t\tWorking Hours");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", employee.Name, employee.Type, employee.WorkingHours);
            }
        }

        public void InputWorkingHours()
        {
            Console.WriteLine("Enter working hours for each employee:");
            foreach (Employee employee in Employees)
            {
                Console.Write("{0} ({1}): ", employee.Name, employee.Type);
                int hours;
                while (!int.TryParse(Console.ReadLine(), out hours))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }
                employee.WorkingHours = hours;
            }
        }

        public void CalculateAllSalary()
        {
            foreach (Employee employee in Employees)
            {
                double salary = employee.CalculateSalary();
                Console.WriteLine("{0}: {1}", employee.Name, salary);
            }
        }

        public void DisplaySalaryTable()
        {
            Console.WriteLine("Salary table:");
            Console.WriteLine("Name\t\tType\t\tWorking Hours\tSalary");
            foreach (Employee employee in Employees)
            {
                double salary = employee.CalculateSalary();
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", employee.Name, employee.Type, employee.WorkingHours, salary);
            }
        }

      /*  public void AddProduct(string? name, Product product)
        {
            Products.Add(product);
        }
      */

        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            // Find the index of the product in the list
            int index = Products.FindIndex(p => p.Name == product.Name);
            if (index != -1)
            {
                // Replace the old product with the new one
                Products[index] = product;
            }
        }

        public List<Product> SearchProducts(string keyword)
        {
            return Products.FindAll(product =>
                product.Name.ToLower().Contains(keyword) || product.Description.ToLower().Contains(keyword)
            );
        }

        public void DisplayProductList()
        {
            Console.WriteLine("Product List:");
            Console.WriteLine("Name\t\tDescription\t\tPrice\tQuantity");
            foreach (Product product in Products)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}", product.Name, product.Description, product.Price, product.Quantity);
            }
        }

        internal void AddProduct(string? name, string? description, double price, int quantity)
        {
            throw new NotImplementedException();
        }

        internal bool DeleteProduct(int idToDelete)
        {
            throw new NotImplementedException();
        }

        internal Product GetProductById(int idToUpdate)
        {
            throw new NotImplementedException();
        }

        /* internal void AddProduct(string? name, string? description, double price, int quantity)
           {
               throw new NotImplementedException();
           }


           internal bool DeleteProduct(int idToDelete)
           {
               throw new NotImplementedException();
           }

           internal Product GetProductById(int idToUpdate)
           {
               throw new NotImplementedException();
           }*/
    }

}
