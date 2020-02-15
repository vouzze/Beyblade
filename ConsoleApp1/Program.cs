using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static double Square(int a, int b)
        {
            double S = 2 * 3.14 * a * b;
            Console.WriteLine(2 + "π" + " * " + a.ToString() + " * " + b.ToString() + " = " + S.ToString());
            return S;
        }
        public static double Volume(int a, int b)
        {
            double V = 3.14 * a * a * b;
            Console.WriteLine("π" + " * " + a.ToString() + "^2" + " * " + b.ToString() + " = " + V.ToString());
            return V;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius");
            string S1 = Console.ReadLine();
            int r = int.Parse(S1);
            Console.WriteLine("Enter height");
            string S2 = Console.ReadLine();
            int h = int.Parse(S2);
            Square(r, h);
            Volume(r, h);
            Console.ReadLine();
        }
    }
}
