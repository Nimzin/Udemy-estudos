using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper().Insert(3, " Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // O que acontece aqui é que o valorimportante não esta definido, sendo impossivel saber o tamanho dele, uma solução para isso seria usar "?" que fará com que o valorImportante só tenha seu tamanho lido se não for nulo.
        }
    }
}
