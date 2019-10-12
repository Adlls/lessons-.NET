using System;

namespace quadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Program p = new Program();

            double x1 = 0;
            double x2 = 0;

            p.desqe(1,-12,27, ref x1, ref x2);

            var s = p.summ(5,5,5,5,10);
            Console.WriteLine($"sum - {s}");

        }

        public int desqe(double a, double b, double c, ref double  x1, ref double x2) {

            double D = b * b - 4 * a * c;
            int countr = D > 0 ? 2 : (int)D == 0 ? 1 : 0;

            if (countr != 0) {
                x1 = (-1 * b + Math.Sqrt(D)) / 2 * a;
                x2 = (-1 * b - Math.Sqrt(D)) / 2 * a;

                Console.WriteLine($"numbers of radicals = {countr}");
                Console.WriteLine($"first radical = {x1}");
                Console.WriteLine($"second radical = {x2}");
                return countr;
            }
            else {
                Console.WriteLine("no radicals");
                return countr;
            }

        }

        public int summ(params int[] vals) {

           int sum = 0;
           foreach(int val in vals) sum += val;
           return sum;
        }
    }

   
}
