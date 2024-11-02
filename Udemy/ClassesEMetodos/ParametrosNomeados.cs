using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
           
        }
        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    } 
}
// Foi usado no método fomartar o "D2" para adicionar um 0 à esquerda caso o valor tenha apenas uma casa decimal. 
//Quando chamado no Executar, o método irá colocar a sequencia que foi dada em seus parametros, no executar foi chamado o mes antes do dia, no cw o dia foi exibido antes, conforme sequencia do método.