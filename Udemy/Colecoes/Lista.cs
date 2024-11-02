using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
        //public override bool Equals(object? obj)
        //{
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;                 //Método para comparar o nome e preço do produto e analisar se são o mesmo objeto.
        //}

        //public override int GetHashCode()
        //{
        //    return Nome.Length;                           //Método para ser usado no hashSet e não deixar produtos com mesmo atributos.
        //}
    }


    class Lista
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Tronos", 50.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa vasco", 100.10),
                new Produto("Short vasco", 90.90),
                new Produto("Bola vasco", 50)
            };
    
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }

            //carrinho.Add(livro); //List aceita repetição, é possivel adicionar dois elementos iguais.
            Console.WriteLine(carrinho.Count);
        }
    }
}
