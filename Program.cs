using System;

namespace YouTube
{
    class program
    {
        static void Main(string[] args)
        {

            /* int sum = 0;
            int numberOfNums = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numberOfNums; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            */

            //Write a C# Sharp program to read 10 numbers and find their average and sum.

            int sum = 0;
            double avg;

            for (int i = 0; i < 10; i++)
            {
                int numberInput = Convert.ToInt32(Console.ReadLine());
                sum += numberInput;
            }
            avg = (double)sum / 10;

            Console.WriteLine($"Average of {sum} is {avg}");
 
        }
    }

}
