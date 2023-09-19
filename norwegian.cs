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
            Welcome = "La oss spille Stein Saks Papir!",
            Round = "Runde "
        };


    }
}