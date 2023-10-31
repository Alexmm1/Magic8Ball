using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    // class Jerry
    // {
    //     private string name = "Jerry";
    //     public string alias = "Barnacules";
    //     private int age = 34;
    // }
    class Program
    {
        static void Main(string[] args)
        {
            // Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;
            TellPeopleWhatProgramThisIs();
            

            while(true)
            {
            Console.Write("Ask a question?:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();
            Console.ForegroundColor = oldColor;
            }
        }

        static void TellPeopleWhatProgramThisIs()
        {
            
            // Change console text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Magic 8 Ball");
        }
    }
}