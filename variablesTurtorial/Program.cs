using System;

namespace variablesTurtorial {
    class Program {
        static void Main (string[] args) {
            int ourNumber;
            ourNumber = 0;
            Console.WriteLine (ourNumber);
            ourNumber = 10;
            Console.WriteLine (ourNumber);
            ourNumber = 2 + 2;
            Console.WriteLine (ourNumber);
            double decimanNumber;
            decimanNumber = 10.15;
            Console.WriteLine (decimanNumber);
            int number = 5;

            char myCharacter = 'c';
            Console.WriteLine (myCharacter);

            string myName = "Luke";
            Console.WriteLine (myName);

            int newVariable = ourNumber - number;
            Console.WriteLine (newVariable);

            Boolean temp = true;
            Console.WriteLine (temp);

            char myChar = 'd';
            myChar += (char) 1;
            Console.WriteLine (myChar);
        }
    }
}