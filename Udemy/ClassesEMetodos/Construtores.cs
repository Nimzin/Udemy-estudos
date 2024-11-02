using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }
    }
    internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro(); // Neste exemplo eu nao tinha o construtor, após criar o construtor, uma solução seria criar um construtor vazio na classe Carro, possibilitando duas formas diferentes de construir o objeto;
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2020;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} do ano de {carro1.Ano}");

            var carro2 = new Carro("KA", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} do ano de {carro2.Ano}");

            var carro3 = new Carro() // Outra maneira de criar um objeto com construtor padrão;
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2018
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} do ano de {carro3.Ano}");

        }
    }
}
