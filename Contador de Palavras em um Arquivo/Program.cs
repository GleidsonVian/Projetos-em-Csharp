using System;
using System.IO;
using System.Text;

namespace curso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(StreamReader leitor =  new StreamReader("texto.txt")) 
            {
                string linha;
                int quantidadeLinhas =0 ;

                while ((linha = leitor.ReadLine()) != null)
                {
                    quantidadeLinhas += 1;

                }
                Console.WriteLine("Quantidade de linhas: " + quantidadeLinhas);
            }
        }
    }
    } 
