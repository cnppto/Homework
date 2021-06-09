using System;
using System.Collections.Generic;

namespace HW13
{
    public interface IHomework13
    {
        int Homework13(IEnumerable<int> numbers);
    }
    class Check : IHomework13
    {
        int j;
        public int Homework13(IEnumerable<int> numbers)
        {
            return j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Set of 6 digits : ");
            string set = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The output : ");

            string[] numbers = set.Split(',',' ');

            int[] num = { };
            List<int> setnum = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                num[i] = numbers[1];
                Console.WriteLine(t);
            }
            foreach (int i in setnum)
            {
                Console.WriteLine(i);
            }


            Check c = new Check();
            c.Homework13(setnum);

        }
    }
}
