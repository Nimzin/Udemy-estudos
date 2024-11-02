using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é: {i}");    
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
        double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine(media);
        }
    }
}
//O for será mais eficiente quando voce tem um determinado numero de tarefas que ele vai executar, caso seja um numero indeterminado, a estrutura que mais se encaixa é o while.