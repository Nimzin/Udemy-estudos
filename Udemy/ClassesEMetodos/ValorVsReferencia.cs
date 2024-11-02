using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
     class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            numero++;

            Console.WriteLine($"{numero} {copiaNumero}"); //O numero foi incrementado enquanto a cópia permaneceu em 3, pois é apenas uma cópia do numero e não teve alteração.

            Dependente dep = new Dependente
            {
                Nome = "Nim",
                Idade = 27
            };
            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Brenin";
            copiaDep.Idade = 30;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            //Aqui quando o valor da cópia é alterado, o do dep tb é, pois referenciam o mesmo objeto.


        }
    }
}
