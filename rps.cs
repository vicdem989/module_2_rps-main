using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

using ANSI_COLORS;
using SCREEN;
using LANGUAGE;
using SPLASHSCREEN;
using ENGLISH;
using System.Drawing;
using System.Reflection.Metadata;

namespace RPS
{
    public class Game
    {
        public static int player1Points = 0;
        public static int player2Points = 0;
        public static int playerPoints = 0;
        public static int NPCPoints = 0;
        public static int amountTies = 0;

        /*
        
        Fix bo3
            Problem with boX and tie!

        Make splash screen load in
            Use timer
            Can skip with enter/esc (?)
         
        Make splash screen with timer and loading

        */

        public static Hashtable choices = LangEN.setChoiceEN();

        public static void Main(string[] args)
        {
            Console.Clear();
            StartScreen.createStartScreen();
        }

        public static void gameLogic(bool twoPlayer = false, bool bo3 = false, int amountRounds = 3)
        {
            Console.Clear();
            Console.WriteLine("\u001b[1m" + DifferentLanguages.appText.Welcome + "\u001b[0m");
            
            playerPoints = 0;
            NPCPoints = 0;

            player1Points = 0;
            player2Points = 0;



            if (bo3)
            {
                int bestOf = (amountRounds + 1) / 2;
                Colors.AddColor(DifferentLanguages.appText.BestOf + bestOf + "\n", Colors.BoldWhite);
                for (int i = 1; i <= amountRounds; i++)
                {
                    if (playerPoints != bestOf && NPCPoints != bestOf)
                    {
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Round + i, ANSI_COLORS.Colors.Underline);
                        singlePlayer();
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.PlayerPoints + playerPoints, ANSI_COLORS.Colors.BoldGreen);
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.NPCPoints + NPCPoints + "\n", ANSI_COLORS.Colors.BoldRed);
                    }
                }
                if (playerPoints > NPCPoints)
                {
                    Colors.AddColor(DifferentLanguages.appText.YouWon, ANSI_COLORS.Colors.BoldGreen);
                }
                else if (playerPoints == NPCPoints)
                {
                    Colors.AddColor(DifferentLanguages.appText.Tie, ANSI_COLORS.Colors.BoldBlue);
                }
                else
                {
                    Colors.AddColor(DifferentLanguages.appText.NPCWon, ANSI_COLORS.Colors.BoldRed);
                }

                EndScreen.createEndScreen();
                return;
            }
            if (twoPlayer && bo3)
            {
                int bestOf = (amountRounds + 1) / 2;
                Colors.AddColor(DifferentLanguages.appText.BestOf + bestOf+ "\n", Colors.BoldWhite);
                for (int i = 1; i <= amountRounds; i++)
                {
                    if (player1Points != bestOf && player2Points != bestOf)
                    {
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Round + i, ANSI_COLORS.Colors.Underline);
                        hotSeat();
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Player1Points + player1Points, ANSI_COLORS.Colors.BoldGreen);
                        ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Player2Points + player2Points + "\n", ANSI_COLORS.Colors.BoldRed);
                    }
                }
                if (player1Points > player2Points)
                {
                    Colors.AddColor(DifferentLanguages.appText.Player1Won, ANSI_COLORS.Colors.BoldGreen);
                }
                else if (player1Points == player2Points)
                {
                    Colors.AddColor(DifferentLanguages.appText.Tie, ANSI_COLORS.Colors.BoldBlue);
                }
                else
                {
                    Colors.AddColor(DifferentLanguages.appText.Player2Won, ANSI_COLORS.Colors.BoldRed);
                }
                EndScreen.createEndScreen();
                return;
            }
            else if (twoPlayer)
            {
                hotSeat();
                EndScreen.createEndScreen();
                return;
            }

            singlePlayer();
            EndScreen.createEndScreen();

        }

        public static void singlePlayer()
        {
            string playerChoice = string.Empty;
            string npcChoice = string.Empty;

            while (choices.ContainsKey(playerChoice) == false)
            {
                Console.WriteLine( DifferentLanguages.appText.ChooseWeapon + $"{CombineChoices(choices, ", ")}");
                playerChoice = (Console.ReadLine() ?? "").ToUpper();
            }
            Console.Clear();
            npcChoice = MakeNPCChoice(choices);
            Console.WriteLine(DifferentLanguages.appText.YouChose + $"{choices[playerChoice]}" + DifferentLanguages.appText.NPCChose + $"{choices[npcChoice]}\n");
            ANSI_COLORS.Colors.AddColor(DetermineWinnerNPC(playerChoice, npcChoice) + "\n", ANSI_COLORS.Colors.Bold);
        }

        public static void hotSeat()
        {
            string player1Choice = string.Empty;
            string player2Choice = string.Empty;


            while (choices.ContainsKey(player1Choice) == false)
            {
                ANSI_COLORS.Colors.AddColor("\n" + DifferentLanguages.appText.Player1Weapon + $"{CombineChoices(choices, ", ")}", ANSI_COLORS.Colors.Green);
                player1Choice = (Console.ReadLine() ?? "").ToUpper();
            }

            while (choices.ContainsKey(player2Choice) == false)
            {
                ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Player2Weapon + $"{CombineChoices(choices, ", ")}", ANSI_COLORS.Colors.Blue);
                player2Choice = (Console.ReadLine() ?? "").ToUpper();
            }

            Console.Clear();
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Player1Chose + $"{choices[player1Choice]}", ANSI_COLORS.Colors.Green, true);
            Console.Write(" and ");
            ANSI_COLORS.Colors.AddColor(DifferentLanguages.appText.Player2Chose + $"{choices[player1Choice]}", ANSI_COLORS.Colors.Blue, true);
            ANSI_COLORS.Colors.AddColor("\n\n" + determineWinnerTwoPlayer(player1Choice, player2Choice) + "\n", ANSI_COLORS.Colors.Bold);
        }

        static string MakeNPCChoice(Hashtable choices)
        {
            int min = 0;
            int max = choices.Count;
            int choiceIndex = new Random().Next(min, max);
            return choices.Keys.OfType<string>().ElementAt(choiceIndex);
        }

        public static string determineWinnerTwoPlayer(string player1Choice, string player2Choice)
        {
            if (player1Choice == player2Choice)
            {
                amountTies++;
                return DifferentLanguages.appText.Tie;
            }
            else if ((player1Choice == "1" && (player2Choice == "3" || player2Choice == "4")) ||
                (player1Choice == "2" && (player2Choice == "1" || player2Choice == "5")) ||
                (player1Choice == "3" && (player2Choice == "2" || player2Choice == "4")) ||
                (player1Choice == "4" && (player2Choice == "5" || player2Choice == "2")) ||
                (player1Choice == "5" && (player2Choice == "3" || player2Choice == "1")))
            {
                player1Points++;
                return DifferentLanguages.appText.Player1Won;
            }
            player2Points++;
            return DifferentLanguages.appText.Player2Won;
        }

        static string DetermineWinnerNPC(string playerChoice, string npcChoice)
        {
            if (playerChoice == npcChoice)
            {
                return DifferentLanguages.appText.Tie;
            }
            else if ((playerChoice == "1" && (npcChoice == "3" || npcChoice == "4")) ||
                (playerChoice == "2" && (npcChoice == "1" || npcChoice == "5")) ||
                (playerChoice == "3" && (npcChoice == "2" || npcChoice == "4")) ||
                (playerChoice == "4" && (npcChoice == "5" || npcChoice == "2")) ||
                (playerChoice == "5" && (npcChoice == "3" || npcChoice == "1")))
            {

                playerPoints++;
                return DifferentLanguages.appText.YouWon;
            }
            NPCPoints++;
            return DifferentLanguages.appText.YouLose;

        }

        static string CombineChoices(Hashtable choices, string separator)
        {
            string combinedChoices = "";
            foreach (DictionaryEntry choice in choices)
            {
                combinedChoices += (choice.Value as string) + separator;
            }
            return combinedChoices.Remove(combinedChoices.Length - separator.Length);
        }
    }
}