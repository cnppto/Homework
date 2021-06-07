using System;

namespace HW04
{
    public interface IHomework04
    {
        string GetDivisibleBy5Text(string text);
    }

    class Cal : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            string[] numbers = text.Split(',');
            foreach (string part in numbers)
            {
                int intp = Convert.ToInt32(part, 2);

                if (intp % 5 == 0)
                {
                    Console.WriteLine("Binary number divisible by 5 : " + part);
                   
                }
            }return null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 4 binary digits separated by comma ','");
            string num = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Binary number is : " + num);

            Cal n = new Cal();
            n.GetDivisibleBy5Text(num);
            
        }

    
    }

}
