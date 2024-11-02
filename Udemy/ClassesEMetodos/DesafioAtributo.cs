using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
     class DesafioAtributo
     {
        int a = 10;

        public static void Executar()
        {
            //Acessar a variável "a" dentro do método Executar sem alterar a mesma.
            //Console.WriteLine(a);
            
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

        }
     }
}


//Solução, a maneira mais pratica seria transformar o "a" em static, mas como não é permitido alterar o objeto, o jeito seria criar uma instancia de DesafioAtributo.
// Depois era só chamar a variavel a pelo que foi instanciado.