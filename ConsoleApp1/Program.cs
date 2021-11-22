using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("{Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare : }");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > 0)
                    Console.WriteLine("-" + b + "/" + a);
                else Console.WriteLine(b + "/" + a);
            }
            else
            {
                int x = -b / a;
                Console.WriteLine("{0}",x);
            }

            //2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            
            int c = int.Parse(Console.ReadLine());
           double delta = b ^ 2 - (4 * a * c);
            if (delta > 0)
            {
                double x1 = -(b - Math.Sqrt(delta)) / a;
                double x2 = -(b + Math.Sqrt(delta)) / a;
                Console.WriteLine(x1 + ",  " + x2);
            }
            else
            {

                if (delta == 0)
                {
                    int x3 = -b / a;
                    Console.WriteLine("{0}", x3);

                }
            }

            //3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0) Console.WriteLine("true");
            else Console.WriteLine("fals");











        }
    }
}
