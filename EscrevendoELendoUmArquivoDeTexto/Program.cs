using System.ComponentModel;
using System.IO;
using System.Text;

namespace curso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                // Solicite ao usuário que digite um texto.
                Console.WriteLine("Digite um texto para escrever num arquivo txt");
               string texto = Console.ReadLine();
                // Salve esse texto em um arquivo chamado "meuarquivo.txt" usando File.WriteAllText().
                File.WriteAllText("meuarquivo.txt", texto);
                // Leia o conteúdo do arquivo e exiba no console.
                string conteudo = File.ReadAllText("meuarquivo.txt");
                Console.WriteLine(conteudo);
            }
        }
    }
}