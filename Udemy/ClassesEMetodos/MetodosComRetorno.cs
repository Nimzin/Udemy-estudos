using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b) //Todo método dentro de uma classe deve ter uma assinatura unica, ou seja, Nome e parâmetros unicos.
        {
            return a + b;
   
        }
        public int Subtrair(int a, int b)
        {
            return a- b;

        }
        public int Multiplicar(int a, int b)
        {
            return a * b;

        }
    }
     class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
            
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }

    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 2);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(10, 2));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 3));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }



   

}
