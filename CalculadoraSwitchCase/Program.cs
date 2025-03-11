namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Selecione a operação: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Substração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                int operacao = int.Parse(Console.ReadLine());
                int resultado = 0;

                switch (operacao) {

                    case 1:
                        resultado = numero1 + numero2;
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }

                Console.WriteLine("O resultado é: " + resultado);
        }
        }
    } }