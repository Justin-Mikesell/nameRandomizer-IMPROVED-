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
            while (true)
            {
                
                Console.WriteLine("Press Enter for a new name or type \"quit\" to exit: ");
                string entry = Console.ReadLine().ToLower();
                if (entry == "quit")
                {
                    break;
                }
                else
                {
                                                                       
                string[] names = new string[13] { "Jeff", "Angela", "Chris R.", "Ethan", "Mike", "Justin", "Jessica", "Amanda", "Chris L.", "Brian", "Chris M.", "Juan", "Richard" };

                    Random rand = new Random();
                    List<Int32> result = new List<Int32>();

                    for (Int32 i = 0; i < 13; i++)
                    {
                        Int32 curName = rand.Next(0, 13);

                        while (result.Exists(value => value == curName))
                        {
                            curName = rand.Next(0, 13);
                        }

                            result.Add(curName);
                            string nameNum = names[curName];
                            Console.WriteLine(nameNum);
                            Console.WriteLine("type stop to start over or press enter for a new name: ");                           
                            string newEntry = Console.ReadLine().ToLower();
                            Console.Clear();
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

