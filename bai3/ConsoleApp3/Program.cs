using System;
using System.Collections.Generic;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> Manage = new Dictionary<string, Dictionary<string, int>>();

            
            Add(Manage);
            Add(Manage);

            FindTopEmployee(Manage);
            FindTopProduct(Manage);
        }

        
        static void Add(Dictionary<string, Dictionary<string, int>> Manage)
        {
            Console.Write("Add employee's name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (!Manage.ContainsKey(employeeName))
            {
                Manage[employeeName] = new Dictionary<string, int>();
            }

            if (Manage[employeeName].ContainsKey(productName))
            {
                Manage[employeeName][productName] += quantity;
            }
            else
            {
                Manage[employeeName][productName] = quantity;
            }
        }

        
        static void FindTopEmployee(Dictionary<string, Dictionary<string, int>> Manage)
        {
            string topEmployee = null;
            int maxTotalQuantity = 0;

            foreach (var employee in Manage)
            {
                int employeeTotal = 0;
                foreach (var product in employee.Value)
                {
                    employeeTotal += product.Value;
                }

                if (employeeTotal > maxTotalQuantity)
                {
                    maxTotalQuantity = employeeTotal;
                    topEmployee = employee.Key;
                }
            }

            if (topEmployee != null)
            {
                Console.WriteLine($"The Saler sales most: {topEmployee} sum Quantity {maxTotalQuantity}");
            }
            else
            {
                Console.WriteLine("No data.");
            }
        }

        
        static void FindTopProduct(Dictionary<string, Dictionary<string, int>> Manage)
        {
            Dictionary<string, int> productTotals = new Dictionary<string, int>();

            foreach (var employee in Manage)
            {
                foreach (var product in employee.Value)
                {
                    if (productTotals.ContainsKey(product.Key))
                    {
                        productTotals[product.Key] += product.Value;
                    }
                    else
                    {
                        productTotals[product.Key] = product.Value;
                    }
                }
            }

            string topProduct = null;
            int maxProductQuantity = 0;

            foreach (var product in productTotals)
            {
                if (product.Value > maxProductQuantity)
                {
                    maxProductQuantity = product.Value;
                    topProduct = product.Key;
                }
            }

            if (topProduct != null)
            {
                Console.WriteLine($"Best product: {topProduct} sum Quantity {maxProductQuantity}");
            }
            else
            {
                Console.WriteLine("No data.");
            }
        }
    }
}
