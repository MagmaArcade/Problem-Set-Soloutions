using System.Collections.Generic;
using System;

namespace Collatz_Conjecture
{
    public class Func
    {
        List<int> History = new List<int>();
        int Target;

        public Func()
        {
            Console.WriteLine("This program explores the Collatz Conjecture. The conjecture asks whether repeating two \nsimple arithmetic operations will eventually transform every positive integer into 1");
            Console.WriteLine();
            Console.WriteLine("What is your target number?");
            Target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            // calculation: check whether the current number is even or odd
            // this will affect what calculation is applied to the number
            int currentNum = Target;
            while (currentNum != 1)
            {
                if (currentNum % 2 == 0)
                {
                    //number is even
                    currentNum = currentNum / 2;
                    History.Add(currentNum);
                }
                else
                {
                    // number is odd
                    currentNum = (3 * currentNum) + 1;
                    History.Add(currentNum);
                }
            }
        }


        // print: the target number and all iterations made to reach the final number of 1
        public void Print()
        {
           Console.WriteLine("input: " + Target);
           Console.WriteLine("output: [" + string.Join(", ", History) + "]");
        }
    }
}
    

