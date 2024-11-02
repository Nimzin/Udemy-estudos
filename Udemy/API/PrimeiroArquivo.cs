using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Udemy.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH"); //Funcao para definir o caminho se fosse em linux, mac ou windows.
            return path.Replace("~", home);
        }
    }
     class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"/primeiro_arquivo.txt"; //@ serve para mostrar um caminho.
            
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("texto");
            }
        }
    }
}
