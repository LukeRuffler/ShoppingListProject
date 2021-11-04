using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // the introduction to the application for the user

            var shoppingList = new List<string>();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome To your shopping list. Type in the item name or press the 'Enter' key to finish");
            Console.ForegroundColor = ConsoleColor.White;
            // this loop takes in all the items for the shopping list: 
            // if the user presses enter, then the loop will end.

            while (true)
            {
                Console.WriteLine();
                Console.Write("Please enter an item: ");
                var listItem = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(listItem))
                {
                    break;
                }
                shoppingList.Add(listItem);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Welcome To your shopping list. Type in the item name or press the 'Enter' key to finish");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("My Shopping List:");
                Console.WriteLine();
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ") " + shoppingList[i]);
                }
            }

            // here the shopping list will be displayed back to the user.

            Console.Clear();
            Console.WriteLine("My Shopping List:");
            Console.WriteLine();
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + shoppingList[i]);
            }

            // in this loop the user has an opportunity to remove any items they wish from the shopping list. 

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Would you like to remove any items? (y/n)");    
                Console.ForegroundColor = ConsoleColor.White;
                string answer = Console.ReadLine();
                
                if (answer.ToLower() == "y")
                {
                    Console.Write("Please name an item you wish to remove: ");
                    var getRid = Console.ReadLine();                                   
                                                                                      

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        string j = shoppingList[i];
                        if(getRid == j)
                        {
                            shoppingList.Remove(j);                             // i need the loop to check every item in the list before displaying invalid

                            Console.Clear();
                            Console.WriteLine("My updated Shopping List:");
                            Console.WriteLine();
                            for (int k = 0; k < shoppingList.Count; k++)
                            {
                                Console.WriteLine((k + 1) + ") " + shoppingList[k]);
                            }
                            continue;
                            
                        }
                        else if (getRid != j && i < shoppingList.Count)
                        {
                            continue;
                        }
                        else if(getRid != j && i >= shoppingList.Count -1)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(getRid + " Is an invalid item name, please try again:");
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            
                        } 
                      
                    }

                }
                else if(answer.ToLower() == "n")
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

        
    }
}
