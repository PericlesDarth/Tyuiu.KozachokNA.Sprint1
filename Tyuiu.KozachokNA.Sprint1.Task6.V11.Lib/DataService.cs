using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task6.V11.Lib
{
    public class DataService: ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string s)
        {
            bool foo = false;

            int l = s.Length;

            for (int i = 0; i < l; i++)
            {
                if (s[i] == s[0])
                {
                    foo = true;
                }
            }
            return foo;
        }
    }
}
