using System;
using System.Globalization;
namespace Beecrowd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            double comissao = totalVendas * 0.15;
            double salarioFinal = (salarioFixo + comissao);

            Console.WriteLine($"TOTAL = R$ {salarioFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Read();
        }
    }
}
