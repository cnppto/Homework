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
        string ledSt;
        string on = "[!]";
        string off = "[ ]";
        public string DisplayLEDOnScreen(string ledNo)
        {
            string[] s = { ledNo };
            for (int i = 0; i < 10; i++)
            {
                if (ledNo == "A" || ledNo == "1" || ledNo == "2" || ledNo == "3" || ledNo == "4" || ledNo == "5" || ledNo == "6" || ledNo == "7" || ledNo == "8" || ledNo == "9")
                {
                    ledSt = on;
                    break;
                }
                
                    
            }return ledSt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");

            string[] LED = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            string numLED;
            do
            {
                Console.WriteLine("Please choose LED to turn On/Off: ");
                numLED = Console.ReadLine();
                ChooseLED n = new ChooseLED();
                
                int s;
                if (numLED == "1" || numLED == "2" || numLED == "3" || numLED == "4" || numLED == "5" || numLED == "6" || numLED == "7" || numLED == "8" || numLED == "9")
                {
                    s = Convert.ToInt32(numLED) - 1;
                    for (int i = 0; i < 10; i++)
                    {
                        if(s == i && LED[s] == "[!]")
                        {
                            LED[s] = "[ ]";
                            break;
                        }
                        if (s == i)
                        {
                            LED[s] = n.DisplayLEDOnScreen(numLED);
                            break;
                        }
                    }
                }
                if (numLED == "A")
                {
                    s = 9;
                    for (int i = 0; i < 10; i++)
                    {
                        if (s == i && LED[s] == "[!]")
                        {
                            LED[s] = "[ ]";
                            break;
                        }
                        if (s == i)
                        {
                            LED[s] = n.DisplayLEDOnScreen(numLED);
                            break;
                        }
                        
                    }
                }
                foreach (string i in LED)
                {
                    Console.Write(i + " ");
                    
                }
                Console.WriteLine(" ");
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
                Console.WriteLine(" ");

            }
            while (numLED != "stop");

            
        }
    
    }
}
