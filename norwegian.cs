using System.Collections;
using LANGUAGE;
using RPS;

namespace NORWEGIAN
{
    public class LangNO
    {

        public static Hashtable setChoiceNO()
        {
            return Game.choices = new(){
                { "1", "[1]Stein" },
                { "2", "[2]Papir" },
                { "3", "[3]Saks" },
                { "4", "[4]Spock" },
                { "5", "[5]Ogle" }
                };
        }
        public static ApplicationStrings appTextNO = new ApplicationStrings
        {
            Welcome = "La oss spille stein, saks, papir, spock, øgle!",
            MenuOptions = "Hva vil du gjøre?\n",
            BestOf = "Best av ",
            YouWon = "Gratulerer, du vant!",
            Tie = "Det er uavgjort!",
            NPCWon = "NPC vant!",
            PlayerPoints = "Dine poeng: ",
            NPCPoints = "NPCs poeng: ",
            Player1Points = "Spiller 1 poeng: ",
            Player2Points = "Spiller 2 poeng: ",
            Player1Won = "Spiller 1 vant!",
            Player2Won = "Spiller 2 vant!",
            ChooseWeapon = "Velg ditt våpen: ",
            YouChose = "Du valgte ",
            NPCChose = " og NPC valgte ",
            Player1Weapon = "Spiller 1 våpen: ",
            Player2Weapon = "Spiller 2 våpen: ",
            Player1Chose = "Spiller 1 valgte ",
            Player2Chose = "Spiller 2 valgte ",
            YonWon = "Du vant!",
            YouLose = "Du tapte!",
            StartGame = "1: Start spill\n",
            changeLanguage = "2: Bytt språk\n",
            ExitGame = "3: Avslutt spill\n",
            ChooseMode = "Velg modus",
            Singleplayer = "1: Enspiller",
            SingleplayerBoX = "2: Enspiller boX",
            TwoPlayer = "3: To spillere",
            TwoPlayerBoX = "4: To spillere boX",
            Rounds = "Hvor mange runder?",
            RoundsError = "Skriv inn et tall",
            Replay = "Vil du spille igjen? j/n",
            Menu = "Tilbake til [m]eny",
            ThanksForPlaying = "Takk for at du spilte",
            Round = "Runde: ",
            TimeEstimate = "Antatt tid for å fullføre er ",
            Minutes = " minutter",
            WantToContinue = "Er du sikker på at du vi spille ",
            RoundsCheck = " runder? j/n"
        };
    }
}