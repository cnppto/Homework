using System;
using System.Collections.Generic;

namespace HW12
{
    public interface IHomework12
    {
        char FirstDuplicateCharactor(string text);
        char FirstNotDuplicateCharactor(string text);
    }
    class CheckCharactor : IHomework12
    {
        char txt;
        public char FirstDuplicateCharactor(string text)
        {
            string t ;
            
            List<String> word = new List<string>();
            List<String> wordlist = new List<string>();
            

            for (int i = 0; i < text.Length; i++)
            {
                t = text.Substring(i, 1);
                word.Add(t);
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (word[i] == word[j] && i != j)
                    {
                        wordlist.Add(word[i]);
                        i = text.Length;
                        j = text.Length;
                        break;
                    }
                } 
            }
            if(wordlist.Count == 0)
            {
                Console.WriteLine("First duplicate charactor is: -");
            }

            foreach (string i in wordlist)
            {
                Console.WriteLine("First duplicate charactor is: "+i);
            }
            return txt;
        }
        public char FirstNotDuplicateCharactor(string text)
        {
            string t;
            int len = text.Length;
            List<String> word = new List<string>();
            List<String> wordlist = new List<string>();
            

            for (int i = 0; i < len; i++)
            {
                t = text.Substring(i, 1);
                word.Add(t);
                wordlist.Add(t);
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (word[i] == word[j] && i != j)
                    {
                        wordlist.Remove(word[i]);
                        break;
                    }
                }
            }
            if (wordlist.Count == 0)
            {
                Console.WriteLine("First not duplicate charactor is: -");
            }
            foreach (string i in wordlist)
            {
                Console.WriteLine("First not duplicate charactor is: " + i);
                break;
            }
            Console.WriteLine(" ");
            return txt; ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input string : ");
            string text = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("The output : ");

            CheckCharactor c = new CheckCharactor();
            c.FirstDuplicateCharactor(text);
            c.FirstNotDuplicateCharactor(text);
        }
    }
}
