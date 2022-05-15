using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioComBonus1009
{
    public class SalarioComBonus1009
    {
        static void Main(string[] args)
        {

            string NomeVend = Console.ReadLine().ToUpper();

            double SalarioVend = Convert.ToDouble(Console.ReadLine());

            double VendasTotal = Convert.ToDouble(Console.ReadLine());

            double CalcSalario = (VendasTotal * 0.15) + SalarioVend;

            Console.WriteLine($"TOTAL = R$ {CalcSalario.ToString("F")}");

            Console.ReadKey();
        }
    }
}
