using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.MetodosEFuncoes
{
     class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }
        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a+b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2,3));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 20.4);
        }
    }
}
