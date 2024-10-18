using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task2.V19.Lib
{
    public class DataService: ISprint1Task2V19
    {
        public double ConvertInchToKm(int foo)
        {
            double bar = Convert.ToDouble(foo) * 2.54 / 100;
            bar = Math.Round(bar, 3);
            return  bar;
        }
    }
}
