using ANSI_COLORS;
using LANGUAGE;
using RPS;

namespace SCREEN
{
    public class StartScreen
    {
        public static void createStartScreen(int delay = 80)
        {
            Console.Clear();
            char letterToBeOutputted;
            for (int i = 0; i < DifferentLanguages.appText.MenuOptions.Length; i++)
            {
                letterToBeOutputted = DifferentLanguages.appText.MenuOptions[i];
                ANSI_COLORS.Colors.AddColorChar(letterToBeOutputted, ANSI_COLORS.Colors.BoldGreen, true);
                Thread.Sleep(delay);
            }
            for (int i = 0; i < DifferentLanguages.appText.StartGame.Length; i++)
            {
                letterToBeOutputted = DifferentLanguages.appText.StartGame[i];
                ANSI_COLORS.Colors.AddColorChar(letterToBeOutputted, ANSI_COLORS.Colors.White, true);
                Thread.Sleep(delay);
            }
            for (int i = 0; i < DifferentLanguages.appText.changeLanguage.Length; i++)
            {
                letterToBeOutputted = DifferentLanguages.appText.changeLanguage[i];
                ANSI_COLORS.Colors.AddColorChar(letterToBeOutputted, ANSI_COLORS.Colors.White, true);
                Thread.Sleep(delay);
            }
            for (int i = 0; i < DifferentLanguages.appText.ExitGame.Length; i++)
            {
                letterToBeOutputted = DifferentLanguages.appText.ExitGame[i];
                ANSI_COLORS.Colors.AddColorChar(letterToBeOutputted, ANSI_COLORS.Colors.Red, true);
                Thread.Sleep(delay);
            }

            string input = Console.ReadLine().ToLower().Trim();
            if (input == "1")
            {
                chooseMode();
            }
            else if (input == "2")
            {
                Console.Clear();
                DifferentLanguages.appText = DifferentLanguages.chooseLanguage();
                createStartScreen(0);
            }
            else if (input == "3")
            {
                Console.Clear();
                System.Environment.Exit(1);
            }
            else
            {
                createStartScreen(0);
            }
        }

        public static void chooseMode()
        {
            Console.Clear();
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.ChooseMode, ANSI_COLORS.Colors.Bold);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Singleplayer, ANSI_COLORS.Colors.Cyan);
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.SingleplayerBoX, ANSI_COLORS.Colors.Cyan);
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
                StartScreen.createStartScreen(0);
            }
            else
            {
                Console.Clear();
                ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.ThanksForPlaying, ANSI_COLORS.Colors.BoldMagenta);
            }
        }
    }
}
