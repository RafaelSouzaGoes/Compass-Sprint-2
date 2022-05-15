using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacaoPorTamanho1244
{
    public class Program
    {
        static void Main(string[] args)
        {

            int NumCasos = Convert.ToInt32(Console.ReadLine());

            var PalavrasOrdenadas = new List<string>();

            while (NumCasos-- > 0)
            {
                var Palavras = Console.ReadLine().Split(' ').ToList();

                Palavras = Palavras.OrderByDescending(x => x.Length).ToList();

                PalavrasOrdenadas.Add(string.Join(" ", Palavras.ToArray()));
            }

            foreach (var palavra in PalavrasOrdenadas)
            {
                Console.WriteLine(palavra);
            }
        }
    }
}