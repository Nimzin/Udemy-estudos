using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
     class MyQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Sicrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            var fila2 = new Queue();
            fila2.Enqueue(3);
            fila2.Enqueue("Nim");
            fila2.Enqueue(true);

            Console.WriteLine(fila2.Contains("Nim"));

        }
    }
}
