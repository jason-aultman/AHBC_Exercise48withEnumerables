using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AHBC_Exercise48withEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            string inputAsString;

            do
            {
                IEnumerable<int> enumerableList = new List<int>();
                var nonEnumerableList = (ICollection<int>)enumerableList;
                do
                {
                    inputAsString = GetUserInput();

                    if (inputAsString!="q")
                    {
                        var inputAsInt=int.Parse(inputAsString);
                        nonEnumerableList.Add(inputAsInt);
                    }
                } while (inputAsString != "q");

                foreach(int i in enumerableList)
                {
                    
                    if(i!=enumerableList.Last<int>())
                    Console.Write($"{i}+");
                    else Console.Write($"{i}");
                }
                Console.WriteLine("="+enumerableList.Sum());
            } while (PromptUserToRunAgain());
        }


        private static string GetUserInput()
        {
            Console.WriteLine("Enter a number: q to quit");
            var userInput = Console.ReadLine();
            return userInput.ToLower();
        }


        private static bool PromptUserToRunAgain()
        {
            Console.WriteLine("Would you like to continue? y/n");
            var answer = Console.ReadLine();
            if (answer.Where(thing => answer.StartsWith('y')).Count() > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Goodbye");
                return false;
            }
        }

       
        
    }
}
