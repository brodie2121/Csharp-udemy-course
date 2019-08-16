using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggerNumber = 10;
            int smallerNumber = 1;

            Console.WriteLine("1. condition");
            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            }

            Console.WriteLine("2. condition");
            if (biggerNumber == smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is equal " + smallerNumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("3. condition");
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is greater than " + smallerNumber);
            }
            else if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("4. condition");
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is greater than " + smallerNumber);
            }

            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine(biggerNumber + " is not equal to " + smallerNumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("5. condition");
            if (biggerNumber <= smallerNumber)
            {
                Console.WriteLine("bigger is smaller");
            }
            else if (biggerNumber == smallerNumber)
            {
                Console.WriteLine("they are equal");
            }
            else if (biggerNumber != smallerNumber)
            {
                Console.WriteLine("they are not equal");
            }
            else if (biggerNumber > smallerNumber)
            {
                Console.WriteLine("bigger is greater");
            }

            Console.WriteLine("6. condition");
            if (biggerNumber <= smallerNumber)
            {
                Console.WriteLine("bigger is smaller");
            }
            if (biggerNumber == smallerNumber)
            {
                Console.WriteLine("they are equal");
            }
            if (biggerNumber != smallerNumber)
            {
                Console.WriteLine("they are not equal");
            }
            if (biggerNumber > smallerNumber)
            {
                Console.WriteLine("bigger is greater");
            }

            Console.WriteLine("7. condition");
            if ((biggerNumber > smallerNumber) && (biggerNumber < smallerNumber))
            {
                Console.WriteLine("first");
            }
            else if ((biggerNumber > smallerNumber) && (!(biggerNumber < smallerNumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }

            Console.WriteLine("8. condition");
            if ((biggerNumber > smallerNumber) || (biggerNumber < smallerNumber))
            {
                Console.WriteLine("first");
            }
            else if ((biggerNumber > smallerNumber) || (!(biggerNumber < smallerNumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }
        }
    }
}
