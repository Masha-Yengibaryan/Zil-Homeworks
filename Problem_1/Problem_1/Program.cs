using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            int first = num / 1000;
            int second = (num - first * 1000) / 100;
            int third = (num - (first * 1000 + second * 100)) / 10;
            int fourth = num - (first * 1000 + second * 100 + third * 10);
            int sum = first + second + third + fourth;
            Console.WriteLine("The first number is " + first);
            Console.WriteLine("The second number is " + second);
            Console.WriteLine("The third number is " + third);
            Console.WriteLine("The fourth number is " + fourth);
            Console.WriteLine(sum);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
