using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentencaDancante1234
{
    class Program
    {
        static void Main(string[] args)
        {

            string FraseEntrada;


            while ((FraseEntrada = Console.ReadLine()) != null)
            {
                var FraseArray = FraseEntrada.ToCharArray();
                bool CharAtual = false;

                string FraseDancante = "";

                for (int i = 0; i < FraseArray.Length; i++)
                {
                    if (!char.IsWhiteSpace(FraseArray[i]))
                    {
                        FraseDancante += !CharAtual ? char.ToUpper(FraseArray[i]) :
                            char.ToLower(FraseArray[i]);
                        CharAtual = !CharAtual;
                    }
                    else
                    {
                        FraseDancante += FraseArray[i];
                    }
                }
                Console.WriteLine(FraseDancante);
            }
        }
    }
}
