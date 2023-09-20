using NORWEGIAN;
using ENGLISH;
using RPS;

namespace LANGUAGE
{
    public class DifferentLanguages
    {
        public static ApplicationStrings appText = LangEN.appTextEN;
        public static ApplicationStrings chooseLanguage()
        {
            ANSI_COLORS.Colors.AddColor("Choose a language:", ANSI_COLORS.Colors.Bold);
            Console.WriteLine("1: Norwegian (no)");
            Console.WriteLine("2: English (en)");
            string chosenLanguage = Console.ReadLine().ToLower().Trim();
            Console.Clear();
            if (chosenLanguage == "no" || chosenLanguage == "1")
            {
                ANSI_COLORS.Colors.AddColor("Du valgte Norsk!\n", ANSI_COLORS.Colors.Bold);
                LangNO.setChoiceNO();
                return LangNO.appTextNO;
            }
            else
            {
                ANSI_COLORS.Colors.AddColor("You chose english!\n", ANSI_COLORS.Colors.Bold);
                LangEN.setChoiceEN();
                return LangEN.appTextEN;
            }
        }
    }
}


public class ApplicationStrings
{
    public string Welcome { get; set; } = string.Empty;
    public string MenuOptions { get; set; } = string.Empty;
    public string BestOf { get; set; } = string.Empty;
    public string YouWon { get; set; } = string.Empty;
    public string Tie { get; set; } = string.Empty;
    public string NPCWon { get; set; } = string.Empty;
    public string PlayerPoints { get; set; } = string.Empty;
    public string NPCPoints { get; set; } = string.Empty;
    public string Player1Points { get; set; } = string.Empty;
    public string Player2Points { get; set; } = string.Empty;
    public string Player1Won { get; set; } = string.Empty;
    public string Player2Won { get; set; } = string.Empty;
    public string ChooseWeapon { get; set; } = string.Empty;
    public string YouChose { get; set; } = string.Empty;
    public string NPCChose { get; set; } = string.Empty;
    public string Player1Weapon { get; set; } = string.Empty;
    public string Player2Weapon { get; set; } = string.Empty;
    public string Player1Chose { get; set; } = string.Empty;
    public string Player2Chose { get; set; } = string.Empty;
    public string YonWon { get; set; } = string.Empty;
    public string YouLose { get; set; } = string.Empty;
    public string StartGame { get; set; } = string.Empty;
    public string changeLanguage { get; set; } = string.Empty;
    public string ExitGame { get; set; } = string.Empty;
    public string ChooseMode { get; set; } = string.Empty;
    public string Singleplayer { get; set; } = string.Empty;
    public string SingleplayerBoX { get; set; } = string.Empty;
    public string TwoPlayer { get; set; } = string.Empty;
    public string TwoPlayerBoX { get; set; } = string.Empty;
    public string Rounds { get; set; } = string.Empty;
    public string RoundsError { get; set; } = string.Empty;
    public string Replay { get; set; } = string.Empty;
    public string Menu { get; set; } = string.Empty;
    public string ThanksForPlaying { get; set; } = string.Empty;



    public string Round { get; set; } = string.Empty;

}