using System;
using System.Globalization;
namespace Beecrowd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double MEDIA = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.Read();
        }
    }
}
