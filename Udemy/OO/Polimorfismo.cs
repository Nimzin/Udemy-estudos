using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.OO
{
     public class Polimorfismo
    {
        public class Comida
        {
            public double Peso;
            public Comida(double peso)
            {
                Peso = peso;
            }

            public Comida()
            {

            }
        }
        public class Feijao : Comida
        {
            public Feijao(double peso) : base(peso) { } //Aqui feijao pega o atributo "peso" da classe base e ja é possivel defini-lo na instancia.
        }
        public class Arroz : Comida
        {
            
        }
        public class Carne : Comida
        {
        
        }
        public class Pessoa
        {
            public double Peso;

            //public void Comer(Feijao feijao)
            //{
            //    Peso += feijao.Peso;
            //}
            //public void Comer(Arroz arroz)
            //{
            //    Peso += arroz.Peso;
            //}
            //public void Comer(Carne carne)
            //{
            //    Peso += carne.Peso;
            //}                                      Aqui o feijão, a carne e o arroz ainda n herdavam de Comida, tinha que fazer manualmente um de cada
        public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.3);
            

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}");

        }
    }
}
