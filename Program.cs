using System;

namespace YouTube
{
    class program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int numberOfNums = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= numberOfNums; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }

}
