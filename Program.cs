using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;
            TellPeopleWhatProgramThisIs();

            // Create a randomizer object
            Random randomObject = new Random();

            while(true)
            {
                string questionString = GetQuestionFromUser();

                int numberofSecondsToSleep = randomObject.Next(5)+1;
                Console.WriteLine("Thinking about your answer, stand by...");
                Thread.Sleep(numberofSecondsToSleep * 1000);
                if(questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question");
                    continue;
                }

                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                if(questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more! Bye!");
                    break;
                }

                int radNum = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)radNum;
                switch(radNum)
                {
                    case 0:
                        {
                            Console.WriteLine("Hell Yes");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Yes");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Hell No");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("No");
                            break;
                        }
                }
            }
        }

        static void TellPeopleWhatProgramThisIs()
        {
            
            // Change console text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Magic 8 Ball");
        }

        static string GetQuestionFromUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;

        }
    }
}