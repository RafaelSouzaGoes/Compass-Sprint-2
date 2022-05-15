using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMaior1013
{
    public class Program
    {
        static void Main(String[] args)
        {

            string[] linha = Console.ReadLine()
                .Split(' ');
            int a = Convert.ToInt32(linha[0]);
            int b = Convert.ToInt32(linha[1]);
            int c = Convert.ToInt32(linha[2]);
            
            int MaiorAB = (a + b + Math.Abs(a- b)) / 2;

            int MaiorNumero = Math.Max(c, MaiorAB);
    
            Console.WriteLine($"{MaiorNumero} eh o maior");
        
        }
    }
}
