using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Encapsulamento
{
     public class FilhoReconhecido : SubCelebridade  //Herança
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaJeans);
        }
    }
}
