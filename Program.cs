using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Read(); 
        }
        static void Func()
        {
            for (int x = 1; x <= 18; x++)
            {
                Console.WriteLine("#");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}
