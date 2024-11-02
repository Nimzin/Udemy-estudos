using System;
using System.IO;

namespace Udemy.API
{
    public class ExemploFileInfo
    {
        public static void EcluirSeExistir(params string[] caminhos) //Método criado para excluir o arquivo se ele ja existir
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"/arq_origem.txt".ParseHome();
            var caminhoDestino = @"/arq_destino.txt".ParseHome();
            var caminhoCopia = @"/arq_copia.txt".ParseHome();

            EcluirSeExistir(caminhoCopia, caminhoDestino, caminhoOrigem);
            
            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
