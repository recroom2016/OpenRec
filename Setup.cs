using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace start
{
	class Setup
	{
		public static void setup()
		{
			//sets up all the important files so openrec doesnt crash like lame vaultserver xD
			Console.WriteLine("Setting up... (May take a minute to download everything.)");
			Directory.CreateDirectory("SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\App\\");
			Directory.CreateDirectory("SaveData\\Profile\\");
			if (!(File.Exists("SaveData\\avatar.txt")))
			{
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/avatar.txt"));
			}
			else if (File.ReadAllText("SaveData\\avatar.txt") == "")
            {
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/avatar.txt"));
			}
			if (!(File.Exists("SaveData\\avataritems.txt")))
			{
				File.WriteAllText("SaveData\\avataritems.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/avataritems.txt"));
			}
			if (!(File.Exists("SaveData\\equipment.txt")))
			{
				File.WriteAllText("SaveData\\equipment.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/equipment.txt"));
			}
			if (!(File.Exists("SaveData\\consumables.txt")))
			{
				File.WriteAllText("SaveData\\consumables.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/consumables.txt"));
			}
			if (!(File.Exists("SaveData\\gameconfigs.txt")))
			{
				File.WriteAllText("SaveData\\gameconfigs.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/gameconfigs.txt"));
			}
			if (!(File.Exists("SaveData\\storefronts2.txt")))
			{
				File.WriteAllText("SaveData\\storefronts2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/vaultButItsNewer/main/StoreFront2.json"));
			}
			if (!(File.Exists("SaveData\\Profile\\username.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\username.txt", "DefaultUsername");
			}
			if (!(File.Exists("SaveData\\Profile\\level.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\level.txt", "10");
			}
			if (!(File.Exists("SaveData\\Profile\\userid.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\userid.txt", "10000000");
			}
			if (!(File.Exists("SaveData\\myrooms.txt")))
			{
				File.WriteAllText("SaveData\\myrooms.txt", "[]");
			}
			if (!(File.Exists("SaveData\\settings.txt")))
			{
				File.WriteAllText("SaveData\\settings.txt", Newtonsoft.Json.JsonConvert.SerializeObject(api.Settings.CreateDefaultSettings()));
			}
			if (!(File.Exists("SaveData\\App\\privaterooms.txt")))
			{
				File.WriteAllText("SaveData\\App\\privaterooms.txt", "Disabled");
			}
			if (!(File.Exists("SaveData\\App\\showopenrecinfo.txt")))
			{
				File.WriteAllText("SaveData\\App\\showopenrecinfo.txt", "Enabled");
			}
			if (!(File.Exists("SaveData\\App\\facefeaturesadd.txt")))
			{
				File.WriteAllText("SaveData\\App\\facefeaturesadd.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Download/facefeaturesadd.txt"));
			}
			if (!(File.Exists("SaveData\\Images\\count.txt")))
			{
				File.WriteAllText("SaveData\\Images\\count.txt", "0");
			}
			if (!(File.Exists("SaveData\\profileimage.png")))
			{
				File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://github.com/OpenRecRoom/OpenRec/raw/main/profileimage.png"));
			}
			Console.WriteLine("Done!");
			Console.Clear();
		}
	}
}
