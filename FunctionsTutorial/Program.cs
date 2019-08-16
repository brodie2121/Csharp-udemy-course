using System;

namespace FunctionsTutorial {
    class Program {
        public static int squared (int x) {
            int y = x * x;
            return y;
        }

        public static void printNumber (int number) {
            Console.WriteLine ("Number: " + number);
        }

        public static Boolean isBigger (int first, int second) {
            Boolean temp = first > second;
            return temp;
        }

        static void Main (string[] args) {
            int temp = 10;
            int result = squared (temp);
            printNumber (temp);
            printNumber (result);
            Console.WriteLine (isBigger (10, 20));
            if (isBigger (20, 10)) {
                printNumber (result);
            }
        }
    }
}