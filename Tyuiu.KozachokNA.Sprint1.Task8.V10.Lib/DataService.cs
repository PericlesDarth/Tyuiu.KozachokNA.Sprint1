namespace Tyuiu.KozachokNA.Sprint1.Task8.V10.Lib
{
    public class DataService
    {
        public double Calculate(double x) 
        {
            double foo = 2 / Math.Tan(3 * x);
            foo -= Math.Log(Math.Cos(x)) / (Math.Log(1 + x * x));
            return Math.Round(foo, 3);
        }
    }
}
