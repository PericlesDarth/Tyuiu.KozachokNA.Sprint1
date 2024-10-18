using Tyuiu.KozachokNA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KozachokNA.Sprint1.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Козачок Н. А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:  Создания итогового решения по спринту                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                              *");
            Console.WriteLine("* Выполнил: Козачок Никита Андреевич | РППб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле x*y/(5+x) и печатает его на экране.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            //Console.WriteLine("Введите значение X:");


            //Console.WriteLine("Введите значение Y:");
            //y = Convert.ToDouble(Console.ReadLine());

            int inch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double bar = Convert.ToDouble(ds.ConvertInchToKm(inch));
            Math.Round(bar, 2);

            Console.WriteLine(bar);
            Console.ReadLine();
        }
    }
}
