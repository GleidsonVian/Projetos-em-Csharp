using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Curso
{
    class Program
    {
       
        public static void Main(string[] args)
        {
       
            List<string> listaDeClientes = new List<string>();
            string resposta = "";
            bool continuar = false;

            while (!continuar)
            {
                Console.WriteLine("Bem vindo ao Gerenciador de Clientes");
                Console.WriteLine("1 - Adicionar Cliente");
                Console.WriteLine("2 - Remover Cliente");
                Console.WriteLine("3 - Listar Clientes");
                Console.WriteLine("4 - Encerrar Programa\n");

                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do cliente para adicionar");
                        string novoCliente = Console.ReadLine();
                        listaDeClientes.Add(novoCliente);

                        break;

                    case "2":
                        Console.WriteLine("Digite o nome da pessoa a remover");
                        string pessoaARemover = Console.ReadLine();
                        listaDeClientes.RemoveAll(pessoa => pessoa == pessoaARemover);

                        Console.WriteLine();
                        foreach (var cliente in listaDeClientes)
                        {
                            Console.WriteLine($"{cliente}");
                        }
                        break;

                    case "3":
                        Console.WriteLine();
                        foreach (var cliente in listaDeClientes)
                        {
                            Console.WriteLine($"{cliente}");
                        }
                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("Obrigado por utilizar o programa\nAdeus!");
                        continuar = true;
                        break;

                    default:
                        Console.WriteLine("Tecla não reconhecida, favor colocar entre os número 1 a 4");
                        break;
                }
            }
        }
    }
}