using ANSI_COLORS;
using LANGUAGE;

namespace SPLASHSCREEN
{
    public static class SplashSCreen
    {

        public static void writeSplashScreen()
        {
            Colors.AddColor("Welcome to rock, paper, scissors, spock, lizard!", Colors.Green);
            LoadingBar();
            Colors.AddColor("Where only the most brutal of plays take place!", Colors.Magenta);
            LoadingBar();
            Colors.AddColor("Saddle up, and get ready for a ride!", Colors.BoldRed);
            LoadingBar();
            LoadingNumber();
        }
        public static void LoadingBar()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(10);
                int width = (i + 1) / 4;
                string bar = "[" + new string('#', width) + new string(' ', 50 - width) + "]";
                Console.Write("\r" + bar);
            }
            Console.WriteLine();
            Console.Clear();
        }

        public static void LoadingNumber()
        {
            int randomNumber = new Random().Next(1, 100);
            int minNumber = 5;
            int maxNumber = 1000;
            char letterToBeOutputted;
            string loadingMenu = "Loading menu... ";
            for (int i = 0; i < 13; i++)
            {
                letterToBeOutputted = loadingMenu[i];
                Console.Write(letterToBeOutputted);
                Thread.Sleep(90);
            }
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(randomNumber = new Random().Next(minNumber, maxNumber));
                if (maxNumber > 100)
                {
                    maxNumber -= 50;
                }

                string bar = i + "%";

                Console.Write("\rLoading menu... " + bar);
            }
            Console.WriteLine();
            Console.Clear();
        }
    }
}
