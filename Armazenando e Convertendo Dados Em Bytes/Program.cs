using System.IO;
using System.Diagnostics;
using System.Text;
using System;

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Peça ao usuário uma frase.
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            //Converta essa frase em bytes usando Encoding.UTF8.GetBytes() e salve no arquivo "bytes.txt" com File.WriteAllBytes().
            byte[] bytes = Encoding.UTF8.GetBytes(frase);
            File.WriteAllBytes("bytes.txt",bytes);
            //Leia o arquivo, converta os bytes novamente para string e exiba no console
            byte[] readBytes = File.ReadAllBytes("bytes.txt");
            string byteConvertidoParaString = Encoding.UTF8.GetString(readBytes);
            Console.WriteLine(byteConvertidoParaString);
        }
    }
}