using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace api
{
    class Config
    {
        public static void setup()
        {
            Console.WriteLine("Setting up...");
            Directory.CreateDirectory("SaveData\\Profile\\");
            if (!(File.Exists("SaveData\\avatar.txt")))
            {
                File.Create("SaveData\\avatar.txt");
            }
            if (!(File.Exists("SaveData\\Profile\\username.txt")))
            {
                File.WriteAllText("SaveData\\Profile\\username.txt", "DefaultUsername");
            }
            if (!(File.Exists("SaveData\\profileimage.png")))
            {
                File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://github.com/OpenRecRoom/OpenRec/raw/main/profileimage.png"));
            }
            Console.WriteLine("Done!");
            Console.Clear();
        }
        public static gamesesh.GameSessions.SessionInstance localGameSession;
        public static Objective[][] dailyObjectives = new Objective[][]
        {
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            }
        };

    }
}
