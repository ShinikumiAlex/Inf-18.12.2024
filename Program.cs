using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n=привет");
            Console.WriteLine(n);
        }

        static int Input(string mess)
        {
            Console.Write(mess);
            return int.Parse(Console.ReadLine());
        }

        static void Func()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
