using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++;
            Console.WriteLine(num1);

            num1--;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2); // colocar o sinal "--" antes da variavel faz com que o num2 seja decrementado antes da comparação com o num1, tornando o resultado true, caso o sinal de "--" fique depois da variavel, serial false;
        }
    }
}
