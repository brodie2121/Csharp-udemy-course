using System;

namespace ForLoopTutorial {
    class Program {
        static void Main (string[] args) {
            int temp = 1;
            temp++;
            //temp = temp + 1;
            Console.WriteLine (temp);
            temp--;
            //temp = temp - 1;
            Console.WriteLine (temp);

            Console.WriteLine ("1. loop");
            int i = 0;
            for (i = 5; i > 0; i--) {
                Console.WriteLine ("Value of i is : " + i);
            }

            Console.WriteLine ("2. loop");
            string[] names = { "Ava", "Adam", "Luke", "Peter" };
            for (; i < names.Length; i++) {
                Console.WriteLine ("Value on index " + i + " is equal to " + names[i]);
            }
            Console.WriteLine (i);
        }
    }
}