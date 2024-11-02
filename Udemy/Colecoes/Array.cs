using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
     class Array  //É homogenea e estatica.
    {
        public static void Executar()
        {
            string [] alunos = new string [5];
            alunos[0] = "Nim";
            alunos[1] = "Breno";
            alunos[2] = "Chaves";
            alunos[3] = "Almeida";
            alunos[4] = "Breninho";

            foreach (var nim in alunos)
            {
                Console.WriteLine(nim);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 8.5, 6.3, 7.5, 5.4 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)  //É o mesmo método de percorrer o Array do exemplo acima, porem usando o for.
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
