using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.TopicosAvancados
{
     class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 22, Nota = 9.0 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Ana", Idade = 26, Nota = 5.5 },
                new Aluno() { Nome = "Nim", Idade = 27, Nota = 8.5 },
                new Aluno() { Nome = "Julio", Idade = 30, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 26, Nota = 6.5 }
            };
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine(pedro.Nome);

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente");
            }
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("aluno  inexistente");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(4);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somaDasNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaDasNotas);

            var mediaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaTurma);

            var mediaTurma7 =alunos.Where(a => a.Nota >=7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaTurma7);

        }
    }
}
