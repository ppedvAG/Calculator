﻿namespace Calculator
{
    public class Sub : ICalculationOperation
    {
        public char Operator => '-';

        public int Calculate(int v1, int v2) => v1 - v2;
    }
}