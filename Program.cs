namespace Finalll
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Delete product");
                Console.WriteLine("3. Update product");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Display product list");
                Console.WriteLine("6. Calculate salary for all employees");
                Console.WriteLine("7. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        store.AddProduct(name, description, price, quantity);
                        Console.WriteLine("Product added successfully");
                        break;
                    case "2":
                        Console.Write("Enter product ID to delete: ");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        bool deleted = store.DeleteProduct(idToDelete);
                        if (deleted)
                        {
                            Console.WriteLine("Product deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                        break;
                    case "3":
                        Console.Write("Enter product ID to update: ");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        Product productToUpdate = store.GetProductById(idToUpdate);
                        if (productToUpdate == null)
                        {
                            Console.WriteLine("Product not found");
                        }
                        else
                        {
                            Console.Write("Enter new product name (leave blank to keep current name): ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new product description (leave blank to keep current description): ");
                            string newDescription = Console.ReadLine();
                            Console.Write("Enter new product price (leave blank to keep current price): ");
                            string newPriceStr = Console.ReadLine();
                            Console.Write("Enter new product quantity (leave blank to keep current quantity): ");
                            string newQuantityStr = Console.ReadLine();
                            if (!String.IsNullOrEmpty(newName))
                            {
                                productToUpdate.Name = newName;
                            }
                            if (!String.IsNullOrEmpty(newDescription))
                            {
                                productToUpdate.Description = newDescription;
                            }
                            if (!String.IsNullOrEmpty(newPriceStr))
                            {
                                double newPrice = Convert.ToDouble(newPriceStr);
                                productToUpdate.Price = newPrice;
                            }
                            if (!String.IsNullOrEmpty(newQuantityStr))
                            {
                                int newQuantity = Convert.ToInt32(newQuantityStr);
                                productToUpdate.Quantity = newQuantity;
                            }
                            Console.WriteLine("Product updated successfully");
                        }
                        break;
                    case "4":
                        Console.Write("Enter product name or description to search: ");
                        string keyword = Console.ReadLine().ToLower();
                        List<Product> searchResults = store.SearchProducts(keyword);
                        if (searchResults.Count == 0)
                        {
                            Console.WriteLine("No results found");
                        }
                        else
                        {
                            Console.WriteLine("Search results:");
                            Console.WriteLine("ID\tName\tDescription\tPrice\tQuantity");
                            foreach (Product product in searchResults)
                            {
                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", product.Id, product.Name, product.Description, product.Price, product.Quantity);
                            }
                        }
                        break;
                    case "5":
                        store.DisplayProductList();
                        break;
                    case "6":
                        Console.WriteLine("Enter working hours for each employee:");
                        foreach (Employee employee in store.Employees)
                        {
                            Console.Write("{0} ({1}): ", employee.Name, employee.Type);
                            int workingHours;
                            while (!int.TryParse(Console.ReadLine(), out workingHours))
                            {
                                Console.Write("Invalid input. Please enter a valid integer: ");
                            }
                            employee.WorkingHours = workingHours;
                        }
                        Console.WriteLine("Successfully updated working hours for all employees.");
                        break;
                }
            }
        }
    }
}