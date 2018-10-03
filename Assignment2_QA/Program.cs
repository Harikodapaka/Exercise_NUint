using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.StartExecution();
            Console.WriteLine("Program Exicution Completed, Press any key to Exit");
            Console.ReadKey();
        }

        private void StartExecution()
        {
            string option;
            do
            {
                Console.WriteLine("1. Enter Triangle Dimentions");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option by entering a number: ");
                option = Console.ReadLine();
                if (option != "2" && IsvalidOption(option))
                {
                    string sideA;
                    do
                    {
                        Console.Write("Enter Side A:");
                        sideA = Console.ReadLine();
                    } while (!IsvalidType(sideA));
                    string sideB;
                    do
                    {
                        Console.Write("Enter Side B:");
                        sideB = Console.ReadLine();
                    } while (!IsvalidType(sideB));

                    string sideC;
                    do
                    {
                        Console.Write("Enter Side C:");
                        sideC = Console.ReadLine();
                    } while (!IsvalidType(sideC));
                    Console.WriteLine(TriangleSolver.Analyze(int.Parse(sideA), int.Parse(sideB), int.Parse(sideC)));
                }
            } while (option != "2");
        }

        private bool IsvalidOption(string option)
        {
            bool res = int.TryParse(option, out int n);
            if (!res || (n!=1 && n!=2) )
            {
                Console.WriteLine("Invalid input, please enter number..");
                return false;
            }
            return res;
        }

        private bool IsvalidType(string option)
        {
            bool res = int.TryParse(option, out int n);
            if (!res || n <=0)
            {
                Console.WriteLine("Invalid input, please enter number..");
                return false;
            }
            return res;
        }
    }
}
