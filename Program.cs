using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(Cos2(25 * Math.PI / 180), 10));
            double ll = Math.Cos(25 * Math.PI / 180);
            Console.WriteLine(ll);
            Console.ReadKey();
        }

        public static double Cos2(double x)
        {
            const double eps = 1e-15;
            double s = 0;
            double r = 1;
            int n = 0;
            while (Math.Abs(r) > eps)
            {
                s = s + r;
                r = -r * x * x / (n * (n - 1));
            }
            return s;
        }
    }
}
