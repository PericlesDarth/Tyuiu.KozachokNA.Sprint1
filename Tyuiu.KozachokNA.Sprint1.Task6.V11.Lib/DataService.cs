using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task6.V11.Lib
{
    public class DataService: ISprint1Task6V11
    {
        public bool ChekeFirstLetterRepetition(string s)
        {
            bool foo = false;
            char bar = s[0];

            int l = s.Length;

            for (int i = 0; i < l; i++)
            {
                if (s[i] == bar)
                {
                    foo = true;
                }
            }
            return foo;
        }
    }
}
