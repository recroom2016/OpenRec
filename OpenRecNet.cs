using System;
using System.Net;
using System.IO;
using System.Threading;

namespace start
{
	public class OpenRecNet
	{
        public OpenRecNet()
        {
        }

        //ignore this its a beta feature
        public static void RecNet()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            if ((File.ReadAllText("SaveData\\App\\showopenrecinfo.txt")) == "Enabled")
            {
                goto ChatStart;
            }
            else
            {
                goto SkipStart;
            }

        ChatStart:
            Console.WriteLine("Welcome to OpenRecChat (Beta)!");
            Console.WriteLine("You are logged in as " + File.ReadAllText("SaveData\\Profile\\username.txt" + "."));
            Console.WriteLine("Your UserID is " + File.ReadAllText("SaveData\\Profile\\userid.txt" + "."));
            Console.WriteLine("In the future, show this message?");
            Console.WriteLine("1) Yes" + Environment.NewLine + "2) No");
            string readline = Console.ReadLine();
            if (readline == "1")
            {
                File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Enabled");
                justjoined = false;
                goto SkipStart;
            }
            if (readline == "2")
            {
                File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Disabled");
                justjoined = false;
                goto SkipStart;
            }

        SkipStart:
            for (; ; )
            {
                Console.Clear();
                string refresh = new WebClient
                {
                    Headers =
                        {
                            {
                                "username",
                                File.ReadAllText("SaveData\\Profile\\username.txt")
                            },
                            {
                                "justjoined",
                                Convert.ToString(justjoined)
                            }
                        }
                }.DownloadString("https://openrecchat.loca.lt/refresh");
                Console.WriteLine(refresh);
                Console.WriteLine(Environment.NewLine + "Commands: /r -Refresh /e -Exit");
                Console.WriteLine("Type your message below: ");
                justjoined = false;
                goto Send;
            }

        Send:
            string send = Console.ReadLine();
            if (send == "/r")
            {
                goto SkipStart;
            }
            else if (send == "/e")
            {
                Environment.Exit(0);
            }
            else if (send == "")
            {
                goto SkipStart;
            }
            new WebClient
            {
                Headers =
                        {
                            {
                                "userid",
                                File.ReadAllText("SaveData\\Profile\\userid.txt")
                            },
                            {
                                "username",
                                File.ReadAllText("SaveData\\Profile\\username.txt")
                            }
                        }
            }.UploadString("https://openrecchat.loca.lt/sendmessage", send);
            goto SkipStart;
        }

        public static bool justjoined = false;
    }
}
