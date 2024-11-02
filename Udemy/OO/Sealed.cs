using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.OO
{
    sealed class SemFilho
    {
    public double ValorDaFortuna()
        {
            return 1_4_200.35;
        }
    }
    //class SouFilho : SemFilho   Não é possivel herdar de classe selada.
    //{

    //}
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde : Pai { }
    //{
    //    public sealed override bool HonrarNomeFamilia()    Aqui uma alternativa seria usar o "new" ao inves do override na herança.
    //    {
    //        return false;
    //    }
    //}
     class Sealed 
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
