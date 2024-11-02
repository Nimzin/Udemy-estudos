using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
        public class Uno : Carro
        {
            public Uno() : base(200)
            {

            }
        }
        public class Ferrari : Carro 
        {
            public Ferrari() : base(350)
            {

            }
            public override int Acelerar()
            {
                return AlterarVelocidade(20);
            }
            
            //Outra maneira de herdar da classe pai é usando o new no lugar de virtual ou abstract.
            public new int Frear()
            {
                return AlterarVelocidade(-20);
            }
        }
        public class Heranca
        {
            public static void Executar()
            {
                Console.WriteLine("Uno... ");
                Uno carro1 = new Uno();
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Frear());
                Console.WriteLine(carro1.Frear());
                Console.WriteLine(carro1.Frear());


                Console.WriteLine("Ferrari...");
                Ferrari carro2 = new Ferrari();
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Acelerar());
                Console.WriteLine(carro2.Frear());
                Console.WriteLine(carro2.Frear());


                Console.WriteLine("Ferrari com o tipo carro...");
                Carro carro3 = new Ferrari();
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Acelerar());
                Console.WriteLine(carro3.Frear());
                Console.WriteLine(carro3.Frear());
            }
        }
    }
}
