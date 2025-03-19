using System.IO;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Sempre que executado, registre a data e hora da execução no arquivo "log.txt", adicionando uma nova linha a cada execução.
            DateTime horaAtual = DateTime.Now;
            
            File.AppendAllText("log.txt", horaAtual.ToString());
            //Após registrar o acesso, leia e exiba todo o histórico de acessos.
            string[] logLido = File.ReadAllLines("log.txt");
            foreach (var item in logLido)
            {
                Console.WriteLine(item );
            }
        }
    }
}