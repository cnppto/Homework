using System;
using System.Linq;
using System.Collections.Generic;

namespace HW07
{
    public interface IHomework07
    {
        string RemoveAndSortTextByAlphabetical(string text);
    }
    class Check : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            Console.WriteLine(" ");
            Console.WriteLine("The output : ");
         
            List<String> word_list = new List<string>();
            string[] datas = text.Split(" ");

             foreach (string to in datas)
            {
                word_list.Add(to);
            }

            for (int i = 0; i < datas.Length; i++)
            {
                for (int j = 0; j < datas.Length; j++)
                {
                    if (datas[i] == datas[j] && i != j)
                    {
                        word_list.Remove(datas[j]);
                        break;
                    }
                    else if(datas[i] == datas[j] && i == j)
                    {
                        word_list.Remove(datas[j]);
                        word_list.Add(datas[i]);
                        break;
                    }
                }
                    
            }
            


            word_list.Sort();
            foreach(string i in word_list)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            return null;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input to the program : ");
            string data = Console.ReadLine();
            Console.WriteLine("");
            Check d = new Check();
            d.RemoveAndSortTextByAlphabetical(data);



        }
    }
}
