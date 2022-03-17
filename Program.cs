using System;
using server;
using System.IO;
using ws;
using api;
using System.Net;
using System.Diagnostics;

namespace start
{
    class Program
    {
        static void Main()
        {
            //startup for openrec
            Setup.setup();
            goto Start;

            Start:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OpenRec - Open source RecNet server software. (Version: " + appversion + ")");
            Console.WriteLine("Made and provided by RecRoom 2016.");
            Console.WriteLine("Download source code here: https://github.com/recroom2016/OpenRec");
            Console.WriteLine("Discord: https://discord.gg/daC8QUhnFP" + Environment.NewLine);
            if (!(new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/version.txt").Contains(appversion)))
            {
                Console.WriteLine("This version of OpenRec is outdated. We recommend you install the latest version, OpenRec " + new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/version.txt"));
            }
            if (File.Exists("SaveData\\Profile\\userid.txt"))
            {
                if (new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/banned.txt").Contains(File.ReadAllText("SaveData\\Profile\\userid.txt")))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are banned. Using this version of OpenRec will not work, please download OpenRec 0.4.2 or prior.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bannedflag = true;
                }
            }
            Console.WriteLine("1) Changelog" + Environment.NewLine +"2) Change Settings" + Environment.NewLine + "3) Modify Profile" + Environment.NewLine + "4) Start Server");
            string readline = Console.ReadLine();
            if (readline == "1")
            {
                Console.Clear();
                Console.WriteLine(new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/changelog.txt"));
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Console.Clear();
                goto Start;
            }
            if (readline == "2")
            {
                Console.Clear();
                goto Settings;

                Settings:
                Console.WriteLine("1) Private Rooms: " + File.ReadAllText("SaveData\\App\\privaterooms.txt") + Environment.NewLine + "2) OpenRecNet Info Tab: " + File.ReadAllText("SaveData\\App\\showopenrecinfo.txt") + Environment.NewLine + "3) Reset SaveData" + Environment.NewLine + "4) Go Back");
                string readline4 = Console.ReadLine();
                if (readline4 == "1")
                {
                    if (File.ReadAllText("SaveData\\App\\privaterooms.txt") == "Disabled")
                    {
                        File.WriteAllText("SaveData\\App\\privaterooms.txt", "Enabled");
                    }
                    else
                    {
                        File.WriteAllText("SaveData\\App\\privaterooms.txt", "Disabled");
                    }
                    Console.Clear();
                    Console.WriteLine("Success!");
                    goto Settings;
                }
                else if (readline4 == "2")
                {
                    if (File.ReadAllText("SaveData\\App\\showopenrecinfo.txt") == "Disabled")
                    {
                        File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Enabled");
                    }
                    else
                    {
                        File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Disabled");
                    }
                    Console.Clear();
                    Console.WriteLine("Success!");
                    goto Settings;
                }
                else if (readline4 == "3")
                {
                    File.Delete("SaveData\\avatar.txt");
                    File.Delete("SaveData\\avataritems.txt"); 
                    File.Delete("SaveData\\equipment.txt");
                    File.Delete("SaveData\\consumables.txt");
                    File.Delete("SaveData\\gameconfigs.txt");
                    File.Delete("SaveData\\storefronts2.txt");
                    File.Delete("SaveData\\Profile\\username.txt");
                    File.Delete("SaveData\\Profile\\level.txt"); 
                    File.Delete("SaveData\\Profile\\userid.txt");
                    File.Delete("SaveData\\myrooms.txt"); 
                    File.Delete("SaveData\\settings.txt");
                    File.Delete("SaveData\\App\\privaterooms.txt");
                    File.Delete("SaveData\\App\\showopenrecinfo.txt");
                    File.Delete("SaveData\\App\\facefeaturesadd.txt");
                    File.Delete("SaveData\\profileimage.png");
                    Console.WriteLine("Success!");
                    Setup.setup();
                    goto Settings;
                }
                else if (readline4 == "4")
                {
                    Console.Clear();
                    goto Start;
                }
            }
            if (readline == "3")
            {
                Console.Clear();
                goto Profile;

            Profile:
                Console.WriteLine("1) Change Username" + Environment.NewLine + "2) Change Profile Image" + Environment.NewLine + "3) Change Level" + Environment.NewLine + "4) Go Back");
                string readline3 = Console.ReadLine();
                if (readline3 == "1")
                {
                    Console.WriteLine("Current Username: " + File.ReadAllText("SaveData\\Profile\\username.txt"));
                    Console.WriteLine("New Username: ");
                    string newusername = Console.ReadLine();
                    File.WriteAllText("SaveData\\Profile\\username.txt", newusername);
                    Console.Clear();
                    Console.WriteLine("Success!");
                    goto Profile;
                }
                else if (readline3 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1) Upload Media Link" + Environment.NewLine + "2) Drag Image onto this window" + Environment.NewLine + "3) Go Back");
                    string readline4 = Console.ReadLine();
                    if (readline4 == "1")
                    {
                        Console.WriteLine("Paste Media Link: ");
                        string medialink = Console.ReadLine();
                        try
                        {
                            File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData(medialink));
                        }
                        catch (Exception ex4)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Media Link");
                            goto Profile;
                        }
                        Console.Clear();
                        Console.WriteLine("Success!");
                        goto Profile;
                    }
                    else if (readline4 == "2")
                    {
                        Console.WriteLine("Drag any image onto this window and press enter: ");
                        string imagedir = Console.ReadLine();
                        try
                        {
                            byte[] imagefile = File.ReadAllBytes(imagedir);
                            File.Replace(imagedir, "SaveData\\profileimage.png", "backupfilename.png");
                            File.WriteAllBytes(imagedir, imagefile);
                        }
                        catch (Exception ex4)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Image (Make sure its on the same drive as OpenRec)");
                            goto Profile;
                        }
                        Console.Clear();
                        Console.WriteLine("Success!");
                        goto Profile;
                    }
                    else if (readline4 == "3")
                    {
                        Console.Clear();
                        goto Start;
                    }
                }
                else if (readline3 == "3")
                {
                    Console.WriteLine("Current Level: " + File.ReadAllText("SaveData\\Profile\\level.txt"));
                    Console.WriteLine("New Level: ");
                    string newlevel = Console.ReadLine();
                    File.WriteAllText("SaveData\\Profile\\level.txt", newlevel);
                    Console.Clear();
                    Console.WriteLine("Success!");
                    goto Start;
                }
                else if (readline3 == "4")
                {
                    Console.Clear();
                    goto Start;
                }
            }
            
            if (readline == "4")
            {
                Console.WriteLine("Please select the version of RecRoom the server should host: (2017, 2018)");
                string readline2 = Console.ReadLine();
                if (readline2 == "2017")
                {
                    version = "2017";
                    Console.Clear();
                    Console.WriteLine("Version Selected: " + start.Program.version);
                    new APIServer();
                    new WebSocket();
                }
                else if (readline2 == "2018")
                {
                    version = "2018";
                    Console.Clear();
                    Console.WriteLine("Version Selected: " + start.Program.version);
                    new NameServer();
                    new ImageServer();
                    new APIServer();
                    new WebSocket();
                }
            }
        }
        public static string version = "";
        public static string appversion = "0.5.0";
        public static bool bannedflag = false;
    }

}
