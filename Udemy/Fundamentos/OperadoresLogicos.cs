using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // E
            Console.WriteLine(comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // OU
            Console.WriteLine(comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //APENAS UM V /XOR
            Console.WriteLine(comprouTv32);


        }
    }
}
