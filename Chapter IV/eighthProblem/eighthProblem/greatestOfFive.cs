﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eighthProblem
{
    class greatestOfFive
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            double d;
            double e;

            Console.Write("Enter the first number: ");
            bool first = double.TryParse(Console.ReadLine(), out a);
            while (first == false)
            {
                Console.Write("Invalid input. Please try again: ");
                first = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Enter the second number: ");
            bool second = double.TryParse(Console.ReadLine(), out b);
            while (second == false)
            {
                Console.Write("Invalid input. Please try again: ");
                second = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Enter the third number: ");
            bool third = double.TryParse(Console.ReadLine(), out c);
            while (third == false)
            {
                Console.Write("Invalid input. Please try again: ");
                third = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Enter the fourth number: ");
            bool fourth = double.TryParse(Console.ReadLine(), out d);
            while (fourth == false)
            {
                Console.Write("Invalid input.Please try again: ");
                fourth = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Enter the fifth number: ");
            bool fifth = double.TryParse(Console.ReadLine(), out e);
            while (fifth == false)
            {
                Console.Write("Invalid input. Please try again: ");
                fifth = double.TryParse(Console.ReadLine(), out a);
            }

            double firstCheck = Math.Max(a, b);
            double secondCheck = Math.Max(c, d);
            double thirdCheck = Math.Max(firstCheck, secondCheck);
            double result = Math.Max(thirdCheck, e);
            Console.WriteLine("The greatest number is: {0}", result);
        }
    }
}
