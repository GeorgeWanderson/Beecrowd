using System;

namespace Beecrowd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string primeiraLinha = Console.ReadLine();
            string segundaLinha = Console.ReadLine();

            string[] values = primeiraLinha.Split(' ');
            int codigo1 = Convert.ToInt32(values[0]);
            int quantidade1 = Convert.ToInt32(values[1]);
            double valor1 = Convert.ToDouble(values[2]);

            string[] secondValues = segundaLinha.Split(' ');
            int codigo2 = Convert.ToInt32(secondValues[0]);
            int quantidade2 = Convert.ToInt32(secondValues[1]);
            double valor2 = Convert.ToDouble(secondValues[2]);

            double total = (valor1 * quantidade1) + (valor2 * quantidade2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:00.00}", total);
        }
    }
}
