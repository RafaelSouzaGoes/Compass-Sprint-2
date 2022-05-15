using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSimples1010
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            string[] linha1 = Console.ReadLine().Split(' ');
            int Codigo1 = Convert.ToInt32(linha1[0]);
            int Quantidade1 = Convert.ToInt32(linha1[1]);
            double Preco1 = Convert.ToDouble(linha1[2]);

          
            string[] linha2 = Console.ReadLine().Split(' ');
            int Codigo2 = Convert.ToInt32(linha2[0]);
            int Quantidade2 = Convert.ToInt32(linha2[1]);
            double Preco2 = Convert.ToDouble(linha2[2]);
            
            double totalCompras = (Preco1 * Quantidade1)
                + (Preco2 * Quantidade2);

            Console.WriteLine($"VALOR A PAGAR: R$ {totalCompras.ToString("F")}");
        }

    }
    

}