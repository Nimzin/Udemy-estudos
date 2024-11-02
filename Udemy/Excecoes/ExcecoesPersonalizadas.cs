using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }
    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }
     class ExcecoesPersonalizadas
    {
            public static int PositivoPar()
            {
                Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Número negativo...");
            }
            if (valor %2 == 1)
            {
                throw new ImparException("Número ímpar...");
            }
            return valor;
            }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }catch(NegativoException e) {  Console.WriteLine(e.Message); } catch (ImparException e) { Console.WriteLine(e.Message); }
        }
    }
}
