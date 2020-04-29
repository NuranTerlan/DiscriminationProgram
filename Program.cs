using System;

namespace Discrimination
{
    class Program
    {

        public static string Discrimination(double a, double b, double c)
        {
            double temp = default(double);
            double[] result = new double[2];
            double root = default(double);
            temp = b * b - 4 * a * c;
            if (temp < 0)
            {
                return $"This function * ({a})x^2+({b})x+({c})=0 * hasn't any solution !";
            }
            else if (temp == 0)
            {
                root = -(b) / (2 * a);
                return $"This function * ({a})x^2+({b})x+({c})=0 * has one root {root}";
            }

            temp = Math.Sqrt(temp);
            root = (-(b) + temp) / (2 * a);
            result[0] = root;
            root = (-(b) - temp) / (2 * a);
            result[1] = root;
            return $"Roots of this function * ({a})x^2+({b})x+({c})=0 * are : root1 => {result[0]} and root2 => {result[1]}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            // EX : 1
            string ex1 = Discrimination(2, 5, 18);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"********************************************* EXERCISE 1 *************************************************\n\n{ex1}\n");
            // EX : 2
            string ex2 = Discrimination(2, 5, -28);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"********************************************* EXERCISE 2 *************************************************\n\n{ex2}\n");
            // EX : 3
            string ex3 = Discrimination(1, 1, -35);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"********************************************* EXERCISE 3 *************************************************\n\n{ex3}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
