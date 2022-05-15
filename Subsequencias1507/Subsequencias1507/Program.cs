using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsequencias1507
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var NumeroCasos = Convert.ToInt32(Console.ReadLine());
            var EscreverSaida = new List<string>();

            for (int i = 0; i < NumeroCasos; i++)
            {
                string Sequencia = Console.ReadLine();

                var NumeroQueries = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < NumeroQueries; j++)
                {
                    string SubSequencia = Console.ReadLine();

                    if (TesteSubSequencia(Sequencia, SubSequencia))
                    {
                        EscreverSaida.Add("Yes");
                    }
                    else
                    {
                        EscreverSaida.Add("No");
                    }
                }
            }
            EscreverSaida.ForEach(x => Console.WriteLine(x));
        }
        static bool TesteSubSequencia(string sequencia, string subsequencia)
        {

            int j = 0;
            for (int i = 0; i < sequencia.Length; i++)
            {
                if (subsequencia[j] == sequencia[i])
                {
                    j++;
                }
                if (j == subsequencia.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}