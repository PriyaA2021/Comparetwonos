using System;

namespace Comparetwonos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a=Convert.ToInt32(Console.ReadLine());//This statement is to convert string to integer
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine(a.ToString() + " is greater");
            }
            else
            {
                Console.WriteLine(b.ToString() + " is greater");
            }
           
        }
    }
}
