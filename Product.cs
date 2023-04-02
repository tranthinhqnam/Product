using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalll
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Id { get; internal set; }

        public Product(string name, string description, double price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public void AddProduct()
        {
            Console.WriteLine("Enter product details:");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Delete product: {0}", Name);
            // TODO: implement delete product functionality
        }

        public void UpdateProduct()
        {
            Console.WriteLine("Update product: {0}", Name);
            Console.WriteLine("Enter new product details:");
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }

        public static List<Product> SearchProduct(List<Product> productList, string keyword)
        {
            keyword = keyword.ToLower();
            return productList.FindAll(product =>
                product.Name.ToLower().Contains(keyword) || product.Description.ToLower().Contains(keyword)
            );
        }

        public static void DisplayProductList(List<Product> productList)
        {
            Console.WriteLine("Product list:");
            Console.WriteLine("Name\t\tDescription\t\tPrice\tQuantity");
            foreach (Product product in productList)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}", product.Name, product.Description, product.Price, product.Quantity);
            }
        }
    }

}
