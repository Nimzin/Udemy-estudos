using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Udemy.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture transforma o ponto separando casas decimais em vírgula.


            Console.WriteLine($"{nome}, {idade}, {salario}");
        }
    }
}
