namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leia um arquivo chamado "dados.txt"(crie o arquivo antes com algumas linhas de texto).
            string[] dados = File.ReadAllLines("dados.txt");
            //Conte quantas linhas há no arquivo e exiba no console a quantidade.
            int linhas = 0;
            foreach (var item in dados)
            {
                linhas += 1;
            }
            Console.WriteLine("Total de linhas no arquivo: " + linhas);
        }
    }
}