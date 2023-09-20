using System.Collections;
using LANGUAGE;
using RPS;

namespace ENGLISH
{

    public class LangEN
    {
        public static Hashtable setChoiceEN()
        {
            return Game.choices = new(){
                { "1", "[1]Rock" },
                { "2", "[2]Paper" },
                { "3", "[3]Scissors" },
                { "4", "[4]Spock" },
                { "5", "[5]Lizzard" }
            };
        }


        public static ApplicationStrings appTextEN = new ApplicationStrings
        {
            Welcome = "Let us play rock paper scissor spock lizard!",
            BestOf = "Best of ",
            YouWon = "Congratulations you won!",
            Tie = "It's a tie!",
            NPCWon = "The NPC won!",
            PlayerPoints = "Your points: ",
            NPCPoints = "NPC points: ",
            Player1Points = "Player 1 points: ",
            Player2Points = "Player 2 poitns: ",
            Player1Won = "Player 1 won!",
            Player2Won = "Player 2 won!",
            ChooseWeapon = "Choose your weapon: ",
            YouChose = "You chose ",
            NPCChose = " and the NPC chose ",
            Player1Weapon = "Player 1 weapon: ",
            Player2Weapon = "Player 2 weapon: ",
            Player1Chose = "Player 1 chose ",
            Player2Chose = "Player 2 chose ",
            YonWon = "You win!",
            YouLose = "You lose!",
            StartGame = "1: Start game",
            changeLanguage  = "2: Change language",
            ExitGame = "3: Exit game",
            ChooseMode = "Choose mode",
            Singleplayer = "1: Singleplayer",
            SingleplayerBoX = "2: Singpleplayer boX",
            TwoPlayer = "3: Two-Player",
            TwoPlayerBoX = "4: Two-Player boX",
            Rounds = "How many rounds?",
            RoundsError = "Input a number",
            Replay = "Do you want to play again? y/n",
            Menu = "Back to [m]enu",
            ThanksForPlaying = "Thanks for playing",
            Round = "Round: "
        };


    }
}