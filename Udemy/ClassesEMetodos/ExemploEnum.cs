using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ClassesEMetodos
{
    public class ExemploEnum
    {
        public enum Genero { Acao, Terror, Comedia, Drama, Suspense}
        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar()
        {
            int id = (int) Genero.Acao;
            Console.WriteLine(id);

            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "O Dia Depois de Amanhã";
            filmeFamilia.GeneroDoFilme = Genero.Suspense;
            Console.WriteLine("{0} é {1}!", filmeFamilia.Titulo, filmeFamilia.GeneroDoFilme);


        }
    }
}
