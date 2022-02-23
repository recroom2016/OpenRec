using System;
using System.Net;
using System.IO;

namespace start
{
	public class OpenRecNet
	{
        public OpenRecNet()
        {
        }

        public static void RecNet()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            goto ChatStart;

        ChatStart:
            Console.WriteLine("Welcome to OpenRecNet!");
            Console.WriteLine("You are logged in as " + File.ReadAllText("SaveData\\Profile\\username.txt"));
            Console.WriteLine("Your UserID is " + File.ReadAllText("SaveData\\Profile\\userid.txt"));
            Console.WriteLine("In the future, show this message?");
            Console.WriteLine("1) Yes" + Environment.NewLine + "1) No");
           


        }
    }
}
