using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
   


    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Tronos", 50.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa vasco", 100.10),
                new Produto("Short vasco", 90.90),
                new Produto("Bola vasco", 50),
                new Produto("Bola vasco", 50)
            };
    
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }

            //carrinho.Add(livro); //List aceita repetição, é possivel adicionar dois elementos iguais.
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
