using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace Udemy.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho n reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCel);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaJeans);
        }
    }
    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(amiga.NumeroCel);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaJeans);
        }
    }
     class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
           
            new AmigoProximo().MeusAcessos();
            
            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();
        }
    }
}
