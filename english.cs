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
            Welcome = "Let's play a Rock Paper Sicors!",
            Round = "Round "
        };


    }
}