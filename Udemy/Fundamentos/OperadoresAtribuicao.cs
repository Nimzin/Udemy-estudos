﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;

            num1 -= 3; // num1 = num1 - 3;

            num1 *= 5; //num1 = num1 * 5;

            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} e {b}");

            //Não se preocupar agora
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Joao";

            dynamic d = c;

            d.nome = "Maria";

            Console.WriteLine(c.nome);
            //Ocorre que os dpos compartilham o mesmo objeto, o mesmo espaço de memória;
        }
    }
}
