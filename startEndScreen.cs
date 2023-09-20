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
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.StartGame, ANSI_COLORS.Colors.Green);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.changeLanguage, ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.ExitGame, ANSI_COLORS.Colors.Red);

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
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.ChooseMode, ANSI_COLORS.Colors.Bold);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Singleplayer, ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.SingleplayerBoX, ANSI_COLORS.Colors.Cyan);
            Console.WriteLine("\n");
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.TwoPlayer, ANSI_COLORS.Colors.Magenta);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.TwoPlayerBoX, ANSI_COLORS.Colors.Magenta);
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "1")
            {
                Game.gameLogic(false, false);
                return;
            }
            else if (input == "2")
            {
                Game.gameLogic(false, true, getInt());
            }
            else if (input == "3")
            {
                Game.gameLogic(true, false);
                return;
            }
            else if (input == "4")
            {
                Game.gameLogic(true, true, getInt());
            }
            else
            {
                chooseMode();
            }
        }

        public static int getInt()
        {
            Console.Clear();
            Console.WriteLine(DifferentLanguages.appText.Rounds);
            string inputRound = Console.ReadLine();
            int result = 0;
            while (!int.TryParse(inputRound, out result))
            {
                Colors.Error(DifferentLanguages.appText.RoundsError);
                inputRound = Console.ReadLine();
            }
            return result;
        }
    }





    public class EndScreen
    {
        public static void createEndScreen()
        {
            Console.WriteLine(DifferentLanguages.appText.Replay + "\n");
            Console.WriteLine(DifferentLanguages.appText.Menu);
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y" || input == "j")
            {
                StartScreen.chooseMode();
            }
            else if (input == "m")
            {
                StartScreen.createStartScreen();
            }
            else
            {
                Console.WriteLine("\n");
                ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.ThanksForPlaying, ANSI_COLORS.Colors.BoldMagenta);
            }

        }
    }
}
