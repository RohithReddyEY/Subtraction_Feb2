﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtraction_Feb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, result;
            Console.WriteLine("Enter the numbers to sub :");
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            result = (firstNum - secondNum);
            Console.WriteLine("Result =" + result);

        }
    }
}
