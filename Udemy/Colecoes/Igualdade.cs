using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
     class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Jogo", 100);
            var p2 = new Produto("Jogo", 100);
            var p3 = p2;

            Console.WriteLine(p1 == p2); //Aqui o programa fala que não são iguais pois não referenciam o mesmo objeto na memória.
            Console.WriteLine(p3 == p2);
            
            
            
            Console.WriteLine(p1.Equals(p2)); //aqui o método pega como parametro o nome do produto e o preço, que são iguais.
        }
    }
}
