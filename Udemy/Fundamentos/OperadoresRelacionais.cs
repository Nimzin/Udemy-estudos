using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0); //Se a nota é maior que 10 (MAIOR)
            Console.WriteLine("Nota inválida? {0}", nota < 0.0); // Se a nota é menor que 0 (MENOR)
            Console.WriteLine("Perfeito? {0}" , nota == 10.0); // Se a nota é 10 (IGUAL)
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // Se a nota for diferente de 10 (DIFERENTE)
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte); // Se a nota é maior ou igual a média (MAIOR OU IGUAL)
            Console.WriteLine("Recuperação {0}", nota < notaDeCorte); // Se a nota é menor do que a média (MENOR)
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); //Se a nota for igual ou menor do que 3 (MENOR OU IGUAL)
        }
    }
}
