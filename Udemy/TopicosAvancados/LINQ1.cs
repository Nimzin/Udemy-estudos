using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
     class LINQ1
    {
        
        public static void Executar()
        {


            var alunos = new List<Aluno> //List<Aluno>(); => dessa forma não deixava eu colocar a "," apos cada aluno criado.
            {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 22, Nota = 9.0 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Ana", Idade = 26, Nota = 5.5 },
                new Aluno() { Nome = "Nim", Idade = 27, Nota = 8.5 },
                new Aluno() { Nome = "Julio", Idade = 30, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 26, Nota = 6.5 }
            };

         

            Console.WriteLine("=== Aprovados ===");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => -a.Nota).ToList();
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
                
            }

            Console.WriteLine("\n=== Chamada dos Alunos ===");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("=== Chamada por Idade ==="); //Usando linguagem SQL
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby -aluno.Idade //o "-" na frente do aluno serve pra inverter a ordem de crescente para decrescente
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
