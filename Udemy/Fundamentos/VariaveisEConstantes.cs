using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
     class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;


            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);


            bool estaChovendo = true;
            Console.WriteLine("Está chovendo:" + estaChovendo);


            byte idade = byte.MinValue;
            Console.WriteLine(idade);

            sbyte teste = sbyte.MinValue;
            Console.WriteLine(teste);

            short teste1 = short.MinValue;
            Console.WriteLine(teste1);

            int teste2 = int.MinValue;
            Console.WriteLine(teste2);

            float teste3 = 781.5f;


        }
    }
}
