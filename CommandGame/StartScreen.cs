using System;
using System.Collections.Generic;
using System.Text;

namespace CommandGame
{
    class StartScreen
    {
        public void OpeningScreen()
        {

            Console.SetCursorPosition(50, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RAT SLAYER");
            Console.ResetColor();


            Console.SetCursorPosition(45, 14);

            Console.WriteLine("press ENTER to start");
            Console.ReadLine();

            Console.SetCursorPosition(50, 7);
            Console.WriteLine("          ");


            Console.SetCursorPosition(45, 14);
            Console.WriteLine("                    ");
        }
    }
}
