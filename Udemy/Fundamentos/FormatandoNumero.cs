using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Udemy.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 arredonda
            Console.WriteLine(valor.ToString("C")); // Transforma em valor monetário, no caso o R$.
            Console.WriteLine(valor.ToString("P")); // Valor percentual
            Console.WriteLine(valor.ToString("#.##")); // Arredonda pra 15.18

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura)); // C0 retorna sem casa decimal, o valor aqui será 15 na moeda real, definida na cultura


            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // adiciona casas decimais à esquerda

        }
    }
}
