using System.Diagnostics;
using System.IO;

namespace curso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(StreamReader leitor = new StreamReader("original.txt"))
            using (StreamWriter escritor = new StreamWriter("copia.txt"))
            {
                escritor.Write(leitor.ReadToEnd());

                    
                }
            StreamReader leitorCopia = new StreamReader("copia.txt");
            string linha;
            int quantidadeLinha = 0;
            while ((linha = leitorCopia.ReadLine()) != null)
            {
                quantidadeLinha += 1;
            }
            Console.WriteLine("Foram copiadas um total de " + quantidadeLinha + " linhas");
        }
        }
    }
