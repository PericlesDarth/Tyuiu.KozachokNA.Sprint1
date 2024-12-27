using Tyuiu.KozachokNA.Sprint1.Task8.V10.Lib;

namespace Tyuiu.KozachokNA.Sprint1.Task8.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Здесь будет красивый шаблон");

            Console.WriteLine("Введите Х:");
            double x = Convert.ToDouble(Console.ReadLine());

            double z = ds.Calculate(x);

            Console.WriteLine("Результат:");
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
