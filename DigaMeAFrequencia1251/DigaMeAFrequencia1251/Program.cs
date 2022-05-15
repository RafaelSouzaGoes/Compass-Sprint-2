using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigaMeAFrequancia1251
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Caracteres;
            int PulaLinha = 0;

            while ((Caracteres = Console.ReadLine()) != null)
            {
                var ContadorChaveValor = new SortedDictionary<int, int>();
                if (PulaLinha > 0) Console.WriteLine();
                foreach (var Caracter in Caracteres)
                {
                    if (ContadorChaveValor.ContainsKey(Caracter))
                    {
                        ++ContadorChaveValor[Caracter];
                    }
                    else
                    {
                        ContadorChaveValor.Add(Caracter, 1);
                    }
                }
                var TabelaOrdenada = ContadorChaveValor
                    .OrderBy(x => x.Value)
                    .ThenByDescending(x => x.Key)
                    
                    .Select(x => "" + x.Key + " " + x.Value)
                    .ToList();

                foreach (var Coluna in TabelaOrdenada)
                {
                    if (Coluna != "")
                    {
                        Console.WriteLine(Coluna);
                    }
                }
                PulaLinha++;
            }
        }
    }
}