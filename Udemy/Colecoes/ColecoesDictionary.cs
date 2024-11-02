using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Colecoes
{
    internal class ColecoesDictionary //Dicionario é uma estrutura de chave/valor,NÃO aceita repetição da chave(SET) e aceita repetição do valor(LIST). 
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); //Int n aceita repetição e a string aceita. Funciona como uma mistura do Set na parte da chave(int) e da List na parte do valor(string).
            filmes.Add(2000, "Gladiador");
            filmes.Add(2008, "Batman");
            filmes.Add(2008, "Batmaan");
            filmes.Add(2012, "Superman");

            if (filmes.ContainsKey(2008))
            {
                Console.WriteLine("2008: " + filmes[2008]);
                Console.WriteLine("2008: " + filmes.GetValueOrDefault(2008)); //Se n tiver o filme do ano especificado ele apenas retorna uma string vazia.
            }
            Console.WriteLine(filmes.ContainsValue("Nim")); //Aqui o programa fala se é false or true que possui um filme com o valor especificado.

            Console.WriteLine($"Removeu? {filmes.Remove(2008)}"); //Aqui diz se removeu o filme ou nao com true or false.


            filmes.TryGetValue(2012, out string filmes2012);
            Console.WriteLine(filmes2012!);


            //Formas de percorrer o dicionario: Pela chave, Pelo valor e duas formas de chave e valor ao mesmo tempo

            //Forma pela Chave:
            foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave); //Apenas os anos foram exibidos, as chaves.
            }

            //Forma pelo Valor:
            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor); //Como esperado, apenas a string foi imprimida.
            }

            //1º Forma de Chave e Valor:
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); //Com essa forma é possível escolher quais valores usar e usar ambos se for preciso.
            }

            //2º Forma de Chave e Valor:
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); //É a forma de leitura por inferência.
            }
        }
    }
}
