using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per_Swich.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, per ;
            while (choice != 2)
            {
                Console.WriteLine("Enter your choice 1. calculate percentage 2. exit application");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                          Console.WriteLine("Enter Percetage");
                          per = Convert.ToInt32(Console.ReadLine());
                        if ((per >= 70) && (per <= 100))
                        {
                            Console.WriteLine("First Class");
                        }
                        else if ((per >= 60) && (per <= 70))
                        {
                            Console.WriteLine("Second Class");
                        }
                        if ((per >= 1 && (per <= 60)))
                        {
                            Console.WriteLine("Fail");
                        }
                        


                     
                       
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
