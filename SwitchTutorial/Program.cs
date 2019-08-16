using System;

namespace SwitchTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int switched = 5;
            int result = 0;
            switch (switched)
            {
                case 1:
                    result = 10;
                    break;
                case 3:
                    result = 30;
                    break;
                case 5:
                    result = 50;
                    break;
                default:
                    result = 100;
                    break;
            }
            //using if statement
            if (1 == switched)
            {
                result = 10;
            }
            else if (3 == switched)
            {
                result = 30;
            }
            else if (5 == switched)
            {
                result = 50;
            }
            else
            {
                result = 100;
            }
            Console.WriteLine(result);
        }
    }
}
