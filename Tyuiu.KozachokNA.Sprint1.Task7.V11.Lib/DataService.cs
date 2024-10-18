using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task7.V11.Lib
{
    public class DataService: ISprint1Task7V11
    {
        public double Calculate(double x, double y) 
        {
            double foo = Math.Pow(Math.Log(Math.Sin(x)), x) / (Math.Log(1 + x*x));
            foo += y - Math.Sqrt(Math.Abs(x));
            return Math.Round(foo, 3);
        }
    }
}
