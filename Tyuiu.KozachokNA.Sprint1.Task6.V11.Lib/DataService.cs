using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task6.V11.Lib
{
    public class DataService: ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string s)
        {
            bool foo = false;
            string bar = s.Substring(1, s.Length - 1);

            if (bar.IndexOf(s[0]) != -1)
            {
                foo = true;
            }
            return foo;
        }
    }
}
