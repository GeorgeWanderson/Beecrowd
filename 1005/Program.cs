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

            double MEDIA = (A * 3.5 + B * 7.5) / 11.0;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.Read();
        }
    }
}
