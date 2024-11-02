using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
     class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 5;
            AlterarOut(out int b);
            Console.WriteLine(b);

        }
    }
}
//Resumindo, quando usada a ref seria como se o int a foss p metodo alterarRef e depois retornasse com o valor somado. Ja no out, é apenas o valor do metodo que vai para a chamada da variavel.
// o numero = 0 deve ser atribuido no proprio metodo.
//Definindo out que nada mais são do que variáveis para guardarmos valores que queremos retornar além do valor no return da função.