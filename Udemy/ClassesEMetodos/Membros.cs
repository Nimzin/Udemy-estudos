using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Nim";
            sicrano.Idade = 27;


            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Breno";
            fulano.Idade = 25;

            var apresentacaoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoFulano);
            


        }
    }
}
