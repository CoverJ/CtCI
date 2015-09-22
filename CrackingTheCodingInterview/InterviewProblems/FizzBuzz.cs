using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.InterviewProblems
{
    class FizzBuzz
    {
        // Write a program that prints the numbers 1-100, but for multiples of 3 from "Fizz" and for multiples of 5 print "Buzz",
        // and for numbers divisible by 3 and 5, print "FizzBuzz".
        public static void solution()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 5 == 0) 
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
