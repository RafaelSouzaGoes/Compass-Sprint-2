using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas1018
{
    public class Program
    {
        static void Main(string[] args)
        {

            int valor = Convert.ToInt32(Console.ReadLine());

            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine(valor);
            foreach (var nota in notas)
            {
                int NumeroDeNotas = valor / nota;

                Console.WriteLine($"{NumeroDeNotas} nota(s) de R$ {nota.ToString("F").Replace('.', ',')}");
                valor -= NumeroDeNotas * nota;
            }
        }
    }
}
