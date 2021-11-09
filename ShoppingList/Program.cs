using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputInstruction = "Type in the item name or press the 'Enter' key to finish";

            // the introduction to the application for the user

            var shoppingList = new List<string>();

            ChangeToGreen();
            Console.WriteLine("Welcome To your shopping list.");
            Console.WriteLine(inputInstruction);
            ChangeToWhite();

            // this loop takes in all the items for the shopping list: 
            // if the user presses enter, then the loop will end.

            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter an item: ");
                var listItem = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(listItem))
                {
                    Console.Clear();
                    break;
                }
                shoppingList.Add(listItem);
                Console.Clear();
                ChangeToGreen();
                Console.WriteLine(inputInstruction);
                ChangeToWhite();
                PrintMyShoppingList(shoppingList);
            }

            // here the shopping list will be displayed back to the user.

            PrintMyShoppingList(shoppingList);

            // in this loop the user has an opportunity to remove any items they wish from the shopping list. 

            while (true)
            {
                ChangeToGreen();
                Console.WriteLine();
                Console.WriteLine("Would you like to remove any items? (y/n)");
                ChangeToWhite();
                string answer = Console.ReadLine();
                
                if (answer.ToLower() == "y")
                {
                    Console.Write("Please enter the number that correlates to the item you wish to remove: ");
                    var itemToRemove = Convert.ToInt32(Console.ReadLine());                                   
                                                                                      
                    if (itemToRemove > shoppingList.Count)
                    {
                        // Invalid option
                        Console.WriteLine(itemToRemove + " is not a valid option");
                    }
                    else
                    {
                        shoppingList.Remove(shoppingList[itemToRemove - 1]);

                        Console.Clear();
                        PrintMyShoppingList(shoppingList);
                    }
            
                }
                else if (answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    
                    continue;
                }

            }
           

            Console.ReadKey();
        }

        public static void PrintMyShoppingList(List<string> shoppingList)
        {

            Console.WriteLine();
            Console.WriteLine("My Shopping List:");
            Console.WriteLine();
            for (int i = 0; i < shoppingList.Count; i++)
            {
               Console.WriteLine((i + 1) + ") " + shoppingList[i]);
            }
            
        }
        public static void ChangeToGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void ChangeToWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
