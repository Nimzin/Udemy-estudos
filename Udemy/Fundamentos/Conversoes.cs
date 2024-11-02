using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            var quebrado = inteiro; //houve uma conversão aqui, mas implicita.
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //int notaTruncada = nota; // conversão que não é possivel de ser feita (double em int) a conversao deve ser explicita
            int notaTruncada = (int) nota;
            Console.WriteLine(notaTruncada); // aqui ocorre a conversão, pois esta explicita e houve perda de informação, pois no console aparece apenas 9 e nao 9.7;


            Console.WriteLine("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro); // Primeira forma de converter string em int


            idadeInteiro = Convert.ToInt32(idadeString); // Segunda forma de converter string em int
            Console.WriteLine(idadeInteiro);


            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            //int numero;
            int.TryParse(palavra, out int numero); //Aqui o TryParse vai tentar converter a string palavra em INT, caso uma string seja digitada, o valor será 0, devido ao uso do "out".
            Console.WriteLine(numero);

            Console.Write("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);
        }
    }
}
