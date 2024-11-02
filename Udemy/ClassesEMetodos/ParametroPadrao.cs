using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
     class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10, 20));
            Console.WriteLine(Somar(20));
            Console.WriteLine(Somar());
        }
    }
}
//Os valores padrões serao usados se nao for definido nenhum valor na chamada do metodo.