using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;

            while (condition)
            {

                Console.WriteLine("Pętla while");
                string option = Console.ReadLine();
                Console.WriteLine(option);
                Console.ReadKey();
                System.Console.Clear();
            }
        }
    }
}
