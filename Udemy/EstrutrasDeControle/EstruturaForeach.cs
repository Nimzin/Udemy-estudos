using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EstrutrasDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Opa";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
