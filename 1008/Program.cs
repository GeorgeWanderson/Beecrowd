using System;
using System.Globalization;
namespace Beecrowd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroFuncionario = Convert.ToInt32(Console.ReadLine());
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            double valorPorHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioFinal = valorPorHora * horasTrabalhadas;
            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Read();
        }
    }
}
