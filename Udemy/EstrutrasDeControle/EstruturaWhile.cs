using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
     class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativasAtuais = 0;

            while (tentativaRestante > 0 && !numeroEncontrado)
            {
                Console.Write("Digite o palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativaRestante--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Número encontrado em {tentativasAtuais} tentativas");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine($"Tentativas restantes : {tentativaRestante}");
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine($"Tentativas restantes : {tentativaRestante}");

                }
            }
        }
    }
}
