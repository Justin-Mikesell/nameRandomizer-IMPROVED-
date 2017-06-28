using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameRando
{
    class Program
    {
        static void Main(string[] args)
        {
            // A small pet project I did to fix the lack of volunteering in a class I was in.

            // keeps program running...
            while (true)
            {
                
                Console.WriteLine("Press Enter for a new name or type \"quit\" to exit: ");
                string entry = Console.ReadLine().ToLower();
                //... until quit is entered
                if (entry == "quit")
                {
                    break;
                }

                
                else
                {
                    // generates string of names                                                    
                    string[] names = new string[13] { "Jeff", "Angela", "Chris R.", "Ethan", "Mike", "Justin", "Jessica", "Amanda", "Chris L.", "Brian", "Chris M.", "Juan", "Richard" };

                    // instantiates a new object of type Random
                    Random rand = new Random();

                    //instantiates a new list
                    List<int> result = new List<int>();

                    // runs the loop the amount of times = to the amount of items in the array (update acordingly)
                    for (int i = 0; i < 13; i++)
                    {
                        // pulls a random number between 0-12 (.Next) never pulls the max value -1 so 13 will never be generated
                        int curName = rand.Next(0, 13);

                        // check if the current random number exists inside the list...
                        while (result.Contains(curName))
                        {
                            // ... if it does it will pull a new random number until the number pulled doesnt
                            // exist inside the list
                            curName = rand.Next(0, 13);
                        }

                        // add the random umber to the list
                        result.Add(curName);

                        //create a string of the the current name in the array
                        string nameNum = names[curName];

                        //print current name to string
                        Console.WriteLine(nameNum);

                        // prompt user to continue or stop
                        Console.WriteLine("type \"stop\" to start over or press enter for a new name: ");                           
                        string newEntry = Console.ReadLine().ToLower();
                        Console.Clear();

                        // if user enters stop returns to the main menu and the list will
                        // be reset upon beginning the process again
                        if (newEntry == "stop")
                        {
                            break;
                        }                                                                      
                    }                    
                }
                Console.Clear();
                continue;
            }              
         }                       
     }
 }

