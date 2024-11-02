using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com uma nota de 0 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Boa");
                    break;
                case 5:
                    Console.WriteLine("Ótima");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }
            Console.WriteLine("Fim!");
        }
    }
}
