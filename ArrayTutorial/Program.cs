using System;

namespace ArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 10, 5, 12, 20, 18 };
            Console.WriteLine("Number on index 0 : " + ages[0]);
            int onIndex2 = ages[2];
            Console.WriteLine("age on index 2 : " + onIndex2);
            ages[2] = ages[2] + 1;
            Console.WriteLine("age on index 2 : " + ages[2]);
            Console.WriteLine("onIndex2 : " + onIndex2);

            string[] names = { "Adam", "Ava", "Paul", "Emily" };
            string name = names[1];
            names[1] = "Peter";
            Console.WriteLine(name);
            Console.WriteLine(names[1]);
        }
    }
}
