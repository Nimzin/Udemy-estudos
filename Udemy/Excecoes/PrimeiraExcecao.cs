using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Excecoes
{
    public class Conta
    {
        double Saldo;
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente!!");
            }
            Saldo -= valor;
        }
    }
    
     class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_240.45);
            try
            {
                conta.Sacar(1500);
                Console.WriteLine("Retirada com sucesso!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name); //Serve para descobrir qual a exceção que esta acontecendo, sendo q "Exception" é a mãe das exceções.
            }
            finally //Sempre sera executado, tanto se ocorrer erro ou n.
            {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
