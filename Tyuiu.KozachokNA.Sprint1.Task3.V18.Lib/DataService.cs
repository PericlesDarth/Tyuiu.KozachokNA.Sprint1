﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KozachokNA.Sprint1.Task3.V18.Lib
{
    public class DataService: ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double foo = a * b / (c*c);
            return Math.Round(foo, 3);
        }
    }
}