using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCumparaturi
{
    internal class ShoppingList
    {
        private List<string> shoppingList;

        public ShoppingList()
        {
            shoppingList = new List<string>();
        }
        public void AddProduct(string productName)
        {
            shoppingList.Add(productName);
        }
        public void ShowProducts()
        {
            if (shoppingList.Count == 0)
            {
                Console.WriteLine("The list is empty !");
            }
            else
            {
                Console.WriteLine("Shopping list: ");
                foreach (var product in shoppingList)
                {
                    Console.WriteLine(product);
                }
            }
        }
        public void RemoveProduct(string productName)
        {
            if (shoppingList.Contains(productName))
            {
                shoppingList.Remove(productName);
                Console.WriteLine($"The product {productName} has been sucessfully removed from the shopping list.");
            }
            else
            {
                Console.WriteLine($"Error. The product {productName} does not exist in the shopping list !");
            }
        }
    }
}
