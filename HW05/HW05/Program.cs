using System;
using System.Collections.Generic;

namespace HW05
{
    public interface IHomework05
    {
        string DisplayLEDOnScreen(string ledNo);
    }
    class ChooseLED : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
       
            string[] LED = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"};
            List<String> Number = new List<string>();
            foreach (string i in LED)
            {
                Number.Add(i);
                ///Console.Write(i + " " );
            }
            for (int i=0;i< LED.Length; i++)
            {
                string on = "[!]";
                string off = "[ ]";
                if (ledNo == "1")
                {
                    LED[0] = "[!]";
                   
                }
                if (ledNo == "2")
                {
                    LED[1] = "[!]";
                }
                if (ledNo == "3")
                {
                    LED[2] = "[!]";
                }
                if (ledNo == "4")
                {
                    LED[3] = "[!]";
                }
                if (ledNo == "5")
                {
                    LED[4] = "[!]";
                }
                if (ledNo == "6")
                {
                    LED[5] = "[!]";
                }
                if (ledNo == "7")
                {
                    LED[6] = "[!]";
                }
                if (ledNo == "8")
                {
                    LED[7] = "[!]";
                }
                if (ledNo == "9")
                {
                    LED[8] = "[!]";
                }
                if (ledNo == "A")
                {
                    LED[9] = "[!]";
                }
            }
            foreach (string i in LED)
            {
                Console.Write(i + " " );
            }
            Console.WriteLine(" ");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
           
            return ledNo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");

            string numLED;
            do
            {
                Console.WriteLine("Please choose LED to turn On/Off: ");
                numLED = Console.ReadLine();
                ChooseLED n = new ChooseLED();
                n.DisplayLEDOnScreen(numLED);
            }
            while (numLED != "stop");

            
        }
    
    }
}
