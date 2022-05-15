using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesEImpares1259
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Repeticoes = Convert.ToInt32(Console.ReadLine());
            var Pares = new List<int>();
            var Impares = new List<int>();

            for (int i = 0; i < Repeticoes; i++)
            {
                var Valor = Convert.ToInt32(Console.ReadLine());

                if (Valor % 2 == 0)
                {
                    Pares.Add(Valor);
                }
                else
                {
                    Impares.Add(Valor);
                }
            }
            Pares.OrderBy(x => x)
                .ToList()
                .ForEach(par => Console.WriteLine(par));
            Impares
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(impar => Console.WriteLine(impar));
        }
    }
}