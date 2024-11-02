using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public  double Preco;
        public  double Desconto = 0.1;
        
        
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto() { }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    public class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0.2);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.5
                
                
            };
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
          
                // Produto.Desconto = 0.5; Aqui o desconto seria para todos os produtos, seria definido na classe a porcentagem do desconto, mas para isso teria que alterar o atributo para static na propria classe.
                // ou seja, só existe uma cópia de desconto para todos os produtos na classe.
            }
    }

}
