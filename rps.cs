using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



class Game
{
    public static string playerChoice = "";
    public static string npcChoice = "";
    public static bool replay = true;
    public static string language = "en";
    public static ApplicationStrings appText = null;
    public static Hashtable choices = new(){
            { "R", "Rock" },
            { "P", "Paper" },
            { "S", "Scissors" }
        };


    public static void Main(string[] args)
    {
        appText = Game.ChooseLanguage(null);
        StartScreen(appText);
        while (replay)
        {
            Round(appText);
        }
    }

    static void StartScreen(ApplicationStrings appText)
    {

        /*
            Single or two-player
            Choose language
        */
        Console.Clear();

        Console.WriteLine(appText.LetsPlay);
        Console.WriteLine(appText.ChooseLanguage);
        Console.WriteLine(appText.StartGame);
        int input = int.Parse(Console.ReadLine());
        if(input == 1) {
            Console.WriteLine("Do you want English or Norwegian?");
            appText = Game.ChooseLanguage(null);
        }
        

    }

    static void Round(ApplicationStrings appText)
    {
        Console.Clear();
        npcChoice = MakeNPCChoice(choices);
        // Untill the player chooses a valid option, keep asking
        playerChoice = "";
        while (choices.ContainsKey(playerChoice) == false)
        {
            Console.WriteLine(appText.ChooseWeapon + "\n" + $"{CombineChoices(choices, ", ")}");
            playerChoice = (Console.ReadLine() ?? "").ToUpper();
        }
        // summarize the game and declare the winner 
        Console.WriteLine(appText.YouChose + $"{choices[playerChoice]}" + appText.NPCChose + $"{choices[npcChoice]}.");
        Console.WriteLine(DetermineWinner(appText, playerChoice, npcChoice));
        Console.WriteLine(appText.PlayAgain);
        if (Console.ReadLine().ToLower() == "n")
        {
            replay = false;
            return;
        }
        Game.Round(appText);

    }

    static string MakeNPCChoice(Hashtable choices)
    {
        int min = 0;
        int max = choices.Count;
        int choiceIndex = new Random().Next(min, max);
        return choices.Keys.OfType<string>().ElementAt(choiceIndex);
    }

    static string DetermineWinner(ApplicationStrings appText, string playerChoice, string npcChoice)
    {
        if (playerChoice == npcChoice)
        {
            return appText.Tie;
        }
        else if (playerChoice == "R" && npcChoice == "S" || playerChoice == "P" && npcChoice == "R" || playerChoice == "S" && npcChoice == "P")
        {
            return appText.YouWin;
        }

        return appText.YouLose;

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

    public static ApplicationStrings ChooseLanguage(ApplicationStrings appText)
    {
        Console.Clear();
        if(language != "en") {
            language = Console.ReadLine().ToLower();
        }
        bool validLanguage = false;
        if ((string.Equals(language, "english")) || (string.Equals(language, "en")) || (string.Equals(language, "engelsk")) || (string.Equals(language, "norwegian")) || (string.Equals(language, "no")) || (string.Equals(language, "norsk")))
        {
            validLanguage = true;
        }
        if ((string.Equals(language, "english")) || (string.Equals(language, "en")) || (string.Equals(language, "engelsk")) && validLanguage)
        {
            return new ApplicationStrings
            {
                ChooseLanguage = "1: Do you want to choose a different language?",
                StartGame = "2: Do you want to start the game?",
                LetsPlay = "Let's play a Rock Paper Scissors!",
                ChooseWeapon = "Choose your weapon!",
                YouChose = "You chose ",
                NPCChose = " and the NPC chose: ",
                YouWin = "You won!",
                YouLose = "You lost!",
                Tie = "It's a tie!",
                PlayAgain = "Do you want to play again? y/n"
            };
        }
        else if ((string.Equals(language, "norwegian")) || (string.Equals(language, "no")) || (string.Equals(language, "norsk")) && validLanguage)
        {
            return new ApplicationStrings
            {
                StartGame = "2: Vil du starte spillet?",
                LetsPlay = "La oss spille Stein Saks Papir!",
                ChooseWeapon = "Velg ditt våpen: ",
                YouChose = "Du valgte ",
                NPCChose = " og NPCen valgte ",
                YouWin = "Du vant!",
                YouLose = "Du tapte!",
                Tie = "Det ble uavgjort!",
                PlayAgain = "Vil du spille igjen? y/n"
            };
        }
        else
        {
            return Game.ChooseLanguage(null);
        }
    }

}

class ApplicationStrings
{
    public string ChooseLanguage { get; set; }
    public string NPCChose { get; set; }
    public string StartGame { get; set; }
    public string LetsPlay { get; set; }
    public string ChooseWeapon { get; set; }
    public string YouChose { get; set; }
    public string YouWin { get; set; }
    public string YouLose { get; set; }
    public string Tie { get; set; }
    public string PlayAgain { get; set; }

}