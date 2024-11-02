using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            var bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //bomComportamento = true;
            
            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; // Aceita a entrada tanto de "s" quanto de "S"


            if (nota >= 9.0 && bomComportamento) 
            {
                Console.WriteLine("Quadro de honra");
            }
        
        }
    }
}
