using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEMoedas1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor, cem, cinquenta, vinte, dez, cinco, dois;
            double MoedaUmReal, MoedaCinquenta, MoedaVintec, MoedaDez, MoedaCinco, MoedaUmCent, resto;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cem = valor / 100;
            resto = valor % 100;

            cinquenta = resto / 50;
            resto = resto % 50;

            vinte = resto / 20;
            resto = resto % 20;

            dez = resto / 10;
            resto = resto % 10;

            cinco = resto / 5;
            resto = resto % 5;

            dois = resto / 2;
            resto = resto % 2;

            MoedaUmReal = resto / 1;
            resto = resto % 1;

            resto = resto * 100.0;

            MoedaCinquenta = resto / 50;
            resto = resto % 50;

            MoedaVintec = resto / 25;
            resto = resto % 25;

            MoedaDez = resto / 10;
            resto = resto % 10;

            MoedaCinco = resto / 5;
            resto = resto % 5;

            MoedaUmCent = resto / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{(int)vinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{(int)cinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{(int)dez} nota(s) de R$ 10.00");
            Console.WriteLine($"{(int)cinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{(int)dois} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{(int)MoedaUmReal} moeda(s) de R$ 1.00");
            Console.WriteLine($"{(int)MoedaCinquenta} moeda(s) de R$ 0.50");
            Console.WriteLine($"{(int)MoedaVintec} moeda(s) de R$ 0.25");
            Console.WriteLine($"{(int)MoedaDez} moeda(s) de R$ 0.10");
            Console.WriteLine($"{(int)MoedaCinco} moeda(s) de R$ 0.05");
            Console.WriteLine($"{(int)MoedaUmCent} moeda(s) de R$ 0.01");

        }
    }
}