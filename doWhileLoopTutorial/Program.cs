using System;

namespace doWhileLoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                i++;
            } while (i < 0);
            Console.WriteLine(i);

            while (i < 0)
            {
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
