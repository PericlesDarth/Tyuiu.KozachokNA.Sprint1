using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task5.V3.Lib
{
    public class DataService: ISprint1Task5V3
    {
        public int Calculate(int bar)
        {
            int foo = (bar / 100) % 10;
            return foo;
        }
    }
}
