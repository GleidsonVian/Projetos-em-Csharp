using exercicio2._0;

namespace exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MediaSalario p1 = new MediaSalario();
            MediaSalario p2 = new MediaSalario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine($"Salário médio = {salarioMedio}");
        }
    }
}