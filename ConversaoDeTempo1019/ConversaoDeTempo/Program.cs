using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTempo1019
{
    public class Program
    {
        static void Main(string[] args)
        {

            int Segundos = Convert.ToInt32(Console.ReadLine());

            int horas = (int)Segundos / 3600;
            int minutos = (int)((Segundos % 3600) / 60);
            int SegRelogio = (int)Segundos % 60;

            Console.WriteLine($"{horas}:{minutos}:{SegRelogio}");

        }
    }
}