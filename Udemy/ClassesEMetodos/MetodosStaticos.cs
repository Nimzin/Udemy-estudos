using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public  int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {

            return a * b;

        }
    }
  

    internal class MetodosStaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2,2); //Método que é static é acessível pela classe. Se um atributo é estatico, ele tem uma unica copia.
            Console.WriteLine(resultado);

            var calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(5,5)); //Método sem static fica acessível apenas quando instanciado
        }
    }
}
