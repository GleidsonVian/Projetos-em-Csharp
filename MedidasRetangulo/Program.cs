using RetanguloExercicio1;
using System.Globalization;

namespace Exercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre a altura do retângulo:");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA = " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRo = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}