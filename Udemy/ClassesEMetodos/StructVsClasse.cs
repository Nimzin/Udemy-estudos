using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
     class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }
        public class CPonto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 2 };
            SPonto copiaPonto1 = ponto1; //Atribuição por valor! Alterar o ponto1.X não vai afetar a cópiaPonto1;
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X:{0}", copiaPonto1.X);


            CPonto ponto2 = new CPonto { X = 2, Y = 3 };
            CPonto copiaPonto2 = ponto2; //Atribuição por referência! Alterar o valor do ponto2.X tb altera a da cópia, pois referenciam o mesmo objeto.
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Cópia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
