using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
   public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um instagram";

        //Herança
        protected string CorDosOlhos = "Verde";

        //Mesmo projeto (Assembly)
        internal ulong NumeroCel = 22998171289;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma Classe ou Herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //Private é o padrão (Dentro da própria classe)
        bool UsaMuitojeans = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(UsaMuitojeans);
        }

    }
}
