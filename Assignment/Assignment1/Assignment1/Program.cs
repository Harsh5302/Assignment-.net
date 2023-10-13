using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            /*Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                int result = (a + b) * 3;
                Console.WriteLine(result);
            }
            else
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
            Console.ReadLine();*/


            //Question 2
            /*Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine(a == 30 || b == 30 || c == 30);
            Console.ReadLine();*/


            //Question 3
            /*int a = 37;
            Console.WriteLine("Enter Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( (a % 3 == 0) || (a % 7 == 0));
            Console.ReadLine();*/


            //Queation 4
            /*Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( (a < 0 || a > 100) && (b > 100 || b < 0));
            Console.ReadLine();*/


            //Question 5
            /*Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( (a > 100 && a < 200) || (b > 100 && b < 200) );
            Console.ReadLine(); */


            //Question 6
            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            if (sum >= 10 && sum <= 20)
            {
                Console.WriteLine("30");
            }
            else
            {
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
