using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
     class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento; //readonly é usado quandoi vc quer definir um valor ja na propriedade e fazer com que a propriedade seja apenas de leitura.
            
            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }
            public string GetDataNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var NovoCliente = new Cliente("Nim", new DateTime(1996, 10, 25));
            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataNascimento());
           
        }
    }
}
