using System.Collections;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

using ANSI_COLORS;
using LANGUAGE;
using RPS;

namespace SCREEN
{
    public class StartScreen
    {
        public static void createStartScreen()
        {
            Console.Clear();
            ANSI_COLORS.Colors.AddColor("1: Start game", ANSI_COLORS.Colors.Green);
            ANSI_COLORS.Colors.AddColor("2: Change language", ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor("3: Exit game", ANSI_COLORS.Colors.Red);

            string input = Console.ReadLine().ToLower().Trim();
            if (input == "1")
            {
                chooseMode();
            }
            else if (input == "2")
            {
                Console.Clear();
                DifferentLanguages.appText = DifferentLanguages.chooseLanguage();
                createStartScreen();
            }
            else if (input == "3")
            {
                Console.Clear();
                System.Environment.Exit(1);
            }
            else
            {
                createStartScreen();
            }
        }

        public static void chooseMode()
        {
            Console.Clear();
            ANSI_COLORS.Colors.AddColor("Choose mode", ANSI_COLORS.Colors.Bold);
            ANSI_COLORS.Colors.AddColor("1: Singleplayer", ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor("2: Singpleplayer bo3\n", ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor("3: Two-Player", ANSI_COLORS.Colors.Magenta);
            ANSI_COLORS.Colors.AddColor("4: Two-Player bo3", ANSI_COLORS.Colors.Magenta);
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "1")
            {
                Game.gameLogic(false, false);
                return;
            }
            else if (input == "2")
            {
                Game.gameLogic(false, true);
            }
            else if (input == "3")
            {
                Game.gameLogic(true, false);
                return;
            }
            else if (input == "4")
            {
                Game.gameLogic(true, true);
            }
            else
            {
                chooseMode();
            }
        }
    }



    public class EndScreen
    {
        public static void createEndScreen()
        {
            Console.WriteLine("Do you want to play again? y/n");
            Console.WriteLine("Back to [m]enu");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                StartScreen.chooseMode();
            }
            else if (input == "m")
            {
                StartScreen.createStartScreen();
            }
            else
            {
                ANSI_COLORS.Colors.AddColor("\nThanks for playing", ANSI_COLORS.Colors.BoldMagenta);
            }

        }
    }
}
