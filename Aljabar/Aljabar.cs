using System;

namespace Aljabar
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 3)
                throw new ArgumentException("Persamaan kuadrat harus memiliki 3 koefisien");

            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double d = b * b - 4 * a * c;
            if (d < 0)
                throw new ArithmeticException("Akar tidak nyata");

            double sqrtD = Math.Sqrt(d);
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            return new double[] { x1, x2 };
        }
        public static double[] HasilKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 2)
                throw new ArgumentException("Persamaan linier harus memiliki 2 koefisien");

            double a = persamaan[0];
            double b = persamaan[1];

            double aSquared = a * a;
            double bSquared = 2 * a * b;
            double cSquared = b * b;

            return new double[] { aSquared, bSquared, cSquared };
        }
    }
}