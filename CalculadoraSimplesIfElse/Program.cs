namespace Aula10
{
    public class Program
    {
        public static void Main()
        {

            bool varContinue = true;

            while (varContinue)
            {

                Console.WriteLine("====Calculadora Simples===");
                Console.WriteLine("Digite o primeiro numero");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());

                //sELECIONAR A OPERAÇÃO

                Console.WriteLine("\nEscolha uma operação");
                Console.WriteLine("0. Encerrar Programa");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("Digite o número da operação: ");

                int operation = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                if (operation == 0)
                {
                    Console.WriteLine("Programa Encerrado");
                    varContinue = false;
                }
                else if (operation == 1)
                {
                    result = num1 + num2;
                }
                else if (operation == 2)
                {
                    result = num1 - num2;
                }
                else if (operation == 3)
                {
                    result = num1 * num2;
                }
                else if (operation == 4)
                {

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel fazer divisão por zero");
                    }
                }
                else
                {
                    Console.WriteLine("Operação inválida");
                }

                Console.WriteLine("\nResultado: " + result);
                Console.Clear();
            }


        }
    }
}