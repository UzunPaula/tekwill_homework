using System;

namespace AppListaDeCumparaturi
{
    /*	Exercițiu: "Lista de Cumpărături"
    Cerință: Implementați un program care să permită utilizatorului să adauge și să șteargă elemente
    dintr-o listă de cumpărături. Utilizatorul ar trebui să poată vizualiza lista completă și să poată
    șterge articolele după ce le-a cumpărat. */
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList = new ShoppingList();

            int option;
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1: Add product");
                Console.WriteLine("2: View the products from the shopping list");
                Console.WriteLine("3: Remove product");
                Console.WriteLine("0: Exit");

                Console.WriteLine("Choose an option: ");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Please enter a valid option !");
                }
                
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the product name:");
                        string productName = Console.ReadLine();
                        shoppingList.AddProduct(productName);
                        Console.Clear();
                        break;
                    case 2:
                        shoppingList.ShowProducts();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Enter the product name which you want to delete:");
                        string productNameRemove = Console.ReadLine();
                        shoppingList.RemoveProduct(productNameRemove);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("EXIT");
                        break;
                    default:
                        Console.WriteLine("Invalid option ! Please try again.");
                        break;
                }
            } while (option != 0);
            Console.ReadKey();
        }
    }
}