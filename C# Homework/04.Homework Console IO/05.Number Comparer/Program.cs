﻿using System;

class NumberComparer
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else
        {
            Console.WriteLine(secondNumber);
        }
    }
}

