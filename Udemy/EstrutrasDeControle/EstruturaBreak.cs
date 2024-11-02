using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
    internal class EstruturaBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);


            Console.WriteLine("O número que queremos é {0}", numero);
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("O número que queremos é {0}?", i);
                if (i == numero)
                {
                    Console.WriteLine("sim");
                    //break; o break aqui iria impedir a impressão dos numeros seguintes ao numero que queriamos, se o numero fosse 14, iria parar por ali e nao printar o 15.
                }
                else { Console.WriteLine("não"); }
            }
        }

    }
}
