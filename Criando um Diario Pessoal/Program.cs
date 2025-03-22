using System.IO;

namespace curso
{
    public class Program
    {
        public static void Main() {

            

            using(FileStream fluxo = new FileStream("diario.txt", FileMode.Create, FileAccess.Write))
                using(StreamWriter escritor = new StreamWriter(fluxo))
                
            {
                while (true)
                {
                    Console.WriteLine("Digite (f) para sair do programa ou (c) para continuar");
                    string continuar = Console.ReadLine();

                    if (continuar.ToLower() == "f") {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Criando um Diário Pessoal");
                        Console.WriteLine("Escreva uma entrada de diário");
                        DateTime horaAtual = DateTime.Now;
                        escritor.WriteLine(horaAtual.ToString());
                        string entrada = Console.ReadLine();
                        escritor.WriteLine(entrada);
                        Console.Clear();
                    }
                }


                
            }
            Console.Clear();
            StreamReader leitor = new StreamReader("diario.txt");
            Console.WriteLine(leitor.ReadToEnd());

        }
    }
}