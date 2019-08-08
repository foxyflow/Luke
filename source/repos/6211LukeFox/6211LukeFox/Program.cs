using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6211LukeFox
{
    class Program
    {
        
         static void Question1()
        {
            Console.WriteLine("Hello \n ");
            string name = Console.ReadLine();
            Console.WriteLine($"hello {name}");
        }

        // public static void Add(int num1, int num2)
        // {
        //   Console.WriteLine(num1 + num2);
        //}
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Question1();
            result = Add(10 + 1);
            Console.WriteLine(result);
           // Add(3, 7);
            Console.ReadLine();
        }

        
       
    }
}
