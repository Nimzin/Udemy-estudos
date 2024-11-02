using System;
using System.IO;
using System.Linq.Expressions;

namespace Udemy.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"/lendo_arquivos.txt".ParseHome();



            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Quantidade");
                    sw.WriteLine("Caneta bic; 3.59; 100");
                    sw.WriteLine("Caderno; 10; 50");
                    sw.WriteLine("Lapis; 2.50; 150");
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                } 
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}