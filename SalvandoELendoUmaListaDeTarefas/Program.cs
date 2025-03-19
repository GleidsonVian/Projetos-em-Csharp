using System.IO;

namespace Curso
{
    class Program
    {
        static void SolicitarTarefas()
        {
            Console.WriteLine("Adicione 3 tarefas");
            List<string> tarefas = new List<string>();


            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine((i + 1) + "ª Tarefa");
                
                string tarefa = Console.ReadLine();
                tarefas.Add(tarefa);

            }

            File.WriteAllLines("tarefas.txt", tarefas);

        }

        static void LerTarefas()
        {
            string[] tarefasLidas = File.ReadAllLines("tarefas.txt");
            Console.Clear();
            Console.WriteLine("Seguintes Tarefas na lista: \n");
            foreach (var item in tarefasLidas)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main(string[] args)
        {
            SolicitarTarefas();

            LerTarefas();
        }
    }
}