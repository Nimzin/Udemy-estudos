using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.OO
{
    public abstract class Celular //classe abstrata não pode ser instanciada.
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "tri trim trim...";
        }

    }
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá, meu nome é Nim";
        }
      
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Siri";
        }
    }
     class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular> 
                {
                new Samsung(),
                new Iphone(),
            
                };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}








//Quando uma classe herdeira de uma classe base abstrata, ela se for concreta terá que herdar os métodos da classe base, caso ela também seja abstrata, poderá herdar apenas os que quiser.
//Os métodos concretos herdados por herança são automaticamente herdados, os abstratos não.
//O conceito de classe abstrata é uma classe inacabada. pode ou n estar inacabada. Serve para ser herdada.