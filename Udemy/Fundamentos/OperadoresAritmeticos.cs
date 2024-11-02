using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //Preço com desconto
            var preço = 1000;
            var imposto = 355;
            var desconto = 0.1; //10%

            double total = preço + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine(totalComDesconto);

            //IMC
            double peso = 88;
            double altura = 1.90;
            double imc = peso / (altura * altura); // Outra forma de fazer um numero elevado a 2 é com o codigo: (double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine(imc);

            //Numero par / impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} tem resto {1}", par, par % 2); //Numero par o resultado é 0
            Console.WriteLine("{0}  tem resto {1}", impar , impar % 2); // Numero impar o resultado é 1
        }
    }
}
