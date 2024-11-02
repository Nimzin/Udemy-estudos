using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; //string tem valor padrão de Nulo
        public int Idade; //int tem valor padrão de 0

        public string Apresentar()
        {
            if (string.IsNullOrEmpty(Nome) && Idade <=0)
            {
                Console.WriteLine("Coloque o nome e idade");
            }
            
            return string.Format($"Ola, me chamo {Nome} e  tenho {Idade} anos");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
            
        }
        
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
            
        }
    
    }
}
