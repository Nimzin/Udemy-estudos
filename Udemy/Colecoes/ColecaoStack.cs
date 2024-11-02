using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
     class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack(); //Stack diferentemente da fila, o primeiro a entrar é o último a sair.

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);            //"Push" serve para adicionar
            pilha.Push(true);            //"Pop" serve para remover
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}"); //Aqui o "pop" vai remover o ultimo elemento adicionado.

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //"Peek" mostra o primeiro item da pilha.
            Console.WriteLine(pilha.Count);
        }
    }
}
