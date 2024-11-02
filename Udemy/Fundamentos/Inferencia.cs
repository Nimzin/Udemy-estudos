using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
     class Inferencia
    {
        public static void Executar()
        {
            var nome = "Breno";
            //nome = 123; (Nao da p converter int em string, inferencia)
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);
        }        
    }
}


// Inferencia é quando o C# sabe qual o tipo de valor que foi aplicado numa variavel, como no primeiro exemplo foi uma string devido as aspas duplas e na segunda por conta de um numero.