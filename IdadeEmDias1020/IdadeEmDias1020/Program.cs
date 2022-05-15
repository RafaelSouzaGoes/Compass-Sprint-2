using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias1020
{
    public class Program
    {
        static void Main(string[] args)
        {
            int IdadeDias = Convert.ToInt32(Console.ReadLine());
            int Anos = 0, Meses = 0 ;
            while (IdadeDias >= 365)
            {
                Anos++;
                IdadeDias = IdadeDias - 365;                
            }
            while (IdadeDias >= 30)
            {
                Meses++;
                IdadeDias = IdadeDias - 30;
            }
            
            Console.WriteLine($"{Anos} ano(s)");
            Console.WriteLine($"{Meses} mes(es)");
            Console.WriteLine($"{IdadeDias} dia(s)");

        }
    }
}