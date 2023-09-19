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
    public string Round { get; set; } = string.Empty;

}