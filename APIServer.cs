using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using api;
using api2018;
using api2017;
using Newtonsoft.Json;
using vaultgamesesh;
using System.Collections.Generic;

namespace server
{
	internal class APIServer
	{
		public APIServer()
		{
			try
			{
				Console.WriteLine("[APIServer.cs] has started.");
				new Thread(new ThreadStart(this.StartListen)).Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
			}
		}
		private void StartListen()
		{
			try
			{
				//2 different servers for 3 different stages of the game, the apis change so much idk anymore
				this.listener.Prefixes.Add("http://localhost:" + start.Program.version + "/");
				if (start.Program.version == "2016")
				{
					for (; ; )
					{
						this.listener.Start();
						Console.WriteLine("[APIServer.cs] is listening.");
						HttpListenerContext context = this.listener.GetContext();
						HttpListenerRequest request = context.Request;
						HttpListenerResponse response = context.Response;
						string rawUrl = request.RawUrl;
						string Url = "";
						bool image = false;
						byte[] imagebyte = null;
						if (rawUrl.StartsWith("/api/"))
						{
							Url = rawUrl.Remove(0, 5);
						}
						string text;
						string s = "";
						using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
						{
							text = streamReader.ReadToEnd();
						}
						if (!(Url == ""))
						{
							Console.WriteLine("API Requested: " + Url);
						}
						else
						{
							Console.WriteLine("API Requested (rawUrl): " + rawUrl);
						}
						if (!(Url == "images/v2/profile"))
						{
							Console.WriteLine("API Data: " + text);
						}
						if (Url.StartsWith("versioncheck"))
						{
							s = VersionCheckResponse;
						}
						if (Url == ("config/v2"))
						{
							s = Config2.GetDebugConfig();
						}
						if (Url == "notification/v2")
						{
							s = "[]";
						}
						if (Url == "PlayerReporting/v1/moderationBlockDetails")
						{
							s = ModerationBlockDetails;
							if (start.Program.bannedflag == true)
							{
								s = Banned;
							}
						}
						if (Url == "config/v1/amplitude")
						{
							s = Amplitude.amplitude();
						}
						if (Url == "players/v1/getorcreate")
						{
							s = getorcreate.GetOrCreate((ulong.Parse(text.Remove(0, 32).Remove(7, text.Length - 39))));
						}
						if (Url.StartsWith("images/v1/profile/"))
						{
							image = true;
							imagebyte = File.ReadAllBytes("SaveData\\profileimage.png");
						}
						if (Url == "avatar/v2")
						{
							s = File.ReadAllText("SaveData\\avatar.txt");
						}
						if (Url == "avatar/v2/set")
						{
							//for later 2018 builds compatibility
							if (!(text.Contains("FaceFeatures")))
							{
								string postdatacache = text;
								text = postdatacache.Remove(postdatacache.Length - 1, 1) + File.ReadAllText("SaveData\\App\\facefeaturesadd.txt");
							}
							File.WriteAllText("SaveData\\avatar.txt", text);
						}
						if (Url == "messages/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "relationships/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "settings/v2/")
						{
							s = File.ReadAllText("SaveData\\settings.txt");
						}
						if (Url == "settings/v2/set")
						{
							Settings.SetPlayerSettings(text);
						}
						if (Url == "avatar/v3/items")
						{
							s = File.ReadAllText("SaveData\\avataritems.txt");
						}
						if (Url == "avatar/v2/gifts")
						{
							s = BracketResponse;
						}
						if (Url == "events/v3/list")
						{
							s = Events.list();
						}
						if (Url == "playerevents/v1/all")
						{
							s = PlayerEventsResponse;
						}
						if (Url == "activities/charades/v1/words")
						{
							s = Activities.Charades.words();
						}
						if (Url == "images/v2/profile/") //disabled with a / at the end
                        {
							s = BracketResponse;
							int NewLength = text.Length - 50;
							File.WriteAllBytes("SaveData\\profileimage.png", Encoding.UTF8.GetBytes(text.Remove(0, 50).Remove(NewLength - 48, 48)));
                        }
						Console.WriteLine("API Response: " + s);
						byte[] bytes = null;
						if (image == true)
						{
							bytes = imagebyte;
						}
						else
						{
							bytes = Encoding.UTF8.GetBytes(s);
						}
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(20);
						outputStream.Close();
						this.listener.Stop();
					}
				}
				if (start.Program.version == "2017")
				{
					for (; ; )
					{
						this.listener.Start();
						Console.WriteLine("[APIServer.cs] is listening.");
						HttpListenerContext context = this.listener.GetContext();
						HttpListenerRequest request = context.Request;
						HttpListenerResponse response = context.Response;
						string rawUrl = request.RawUrl;
						string Url = "";
						if (rawUrl.StartsWith("/api/"))
						{
							Url = rawUrl.Remove(0, 5);
						}
						string text;
						string s = "";
						using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
						{
							text = streamReader.ReadToEnd();
						}
						if (!(Url == ""))
						{
							Console.WriteLine("API Requested: " + Url);
						}
						else
						{
							Console.WriteLine("API Requested (rawUrl): " + rawUrl);
						}
						Console.WriteLine("API Data: " + text);
						if (Url.StartsWith("versioncheck"))
						{
							s = VersionCheckResponse;
						}
						if (Url == ("config/v2"))
						{
							s = Config2.GetDebugConfig();
						}
						if (Url == "platformlogin/v1/profiles")
						{
							s = getorcreate.GetOrCreateArray((ulong.Parse(text.Remove(0, 32))));
							CachedPlayerID = ulong.Parse(text.Remove(0, 32));
							CachedPlatformID = ulong.Parse(text.Remove(0, 22));
							File.WriteAllText("SaveData\\Profile\\userid.txt", Convert.ToString(CachedPlayerID));
							if (new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/banned.txt").Contains(File.ReadAllText("SaveData\\Profile\\userid.txt")))
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("You are banned. Using this version of OpenRec will not work, please download OpenRec 0.4.2 or prior.");
								Console.ForegroundColor = ConsoleColor.Green;
								start.Program.bannedflag = true;
							}
						}
						if (Url == "platformlogin/v6")
						{
							s = PlatformLogin.v4(CachedPlayerID);
						}
						if (Url == "PlayerReporting/v1/moderationBlockDetails")
						{
							s = ModerationBlockDetails;
							if (start.Program.bannedflag == true)
							{
								s = Banned;
							}
						}
						if (Url == "config/v1/amplitude")
						{
							s = Amplitude.amplitude();
						}
						if (Url.StartsWith("players/v1/"))
						{
							s = getorcreate.GetOrCreate(CachedPlayerID);
						}
						if (Url == "players/v1/list")
                        {
							s = BracketResponse;
                        }
						if (Url == "avatar/v2")
						{
							s = File.ReadAllText("SaveData\\avatar.txt");
						}
						if (Url == "avatar/v2/saved")
                        {
							s = BracketResponse;
                        }
						if (Url == "avatar/v2/set")
						{
							//for later 2018 builds compatibility
							if (!(text.Contains("FaceFeatures")))
							{
								string postdatacache = text;
								text = postdatacache.Remove(postdatacache.Length - 1, 1) + File.ReadAllText("SaveData\\App\\facefeaturesadd.txt");
							}
							File.WriteAllText("SaveData\\avatar.txt", text);
						}
						if (Url == "messages/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "relationships/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "settings/v2/")
						{
							s = File.ReadAllText("SaveData\\settings.txt");
						}
						if (Url == "settings/v2/set")
						{
							Settings.SetPlayerSettings(text);
						}
						if (Url == "avatar/v3/items")
						{
							s = File.ReadAllText("SaveData\\avataritems.txt");
						}
						if (Url == "equipment/v1/getUnlocked")
						{
							s = File.ReadAllText("SaveData\\equipment.txt");
						}
						if (Url == "avatar/v2/gifts")
						{
							s = BracketResponse;
						}
						if (Url == "events/v3/list")
						{
							s = Events.list();
						}
						if (Url == "playerevents/v1/all")
						{
							s = PlayerEventsResponse;
						}
						if (Url == "activities/charades/v1/words")
						{
							s = Activities.Charades.words();
						}
						if (Url == "gamesessions/v2/joinrandom")
						{
							s = gamesesh.GameSessions.JoinRandom(text);
						}
						if (Url == "gamesessions/v2/create")
						{
							s = gamesesh.GameSessions.Create(text);
						}
						if (rawUrl == "//api/sanitize/v1/isPure")
						{
							s = "{\"IsPure\":true}";
						}
						if (Url == "images/v3/profile")
                        {
							s = BracketResponse;
							int NewLength = text.Length - 50;
							File.WriteAllBytes("SaveData\\profileimage.png", Encoding.UTF8.GetBytes(text.Remove(0, 50).Remove(NewLength - 48, 48)));
						}
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(20);
						outputStream.Close();
						this.listener.Stop();
					}
				}
				else if (start.Program.version == "2018")
				{
					for (; ; )
					{
						this.listener.Start();
						Console.WriteLine("[APIServer.cs] is listening.");
						HttpListenerContext context = this.listener.GetContext();
						HttpListenerRequest request = context.Request;
						HttpListenerResponse response = context.Response;
						List<byte> list = new List<byte>();
						string rawUrl = request.RawUrl;
						string Url = "";
						byte[] bytes = null;
						string signature = request.Headers.Get("X-RNSIG");
						if (rawUrl.StartsWith("/api/"))
						{
							Url = rawUrl.Remove(0, 5);
						}
						if (!(Url == ""))
						{
							Console.WriteLine("API Requested: " + Url);
						}
						else
						{
							Console.WriteLine("API Requested (rawUrl): " + rawUrl);
						}
						string text;
						string s = "";
						using (StreamReader streamReader = new StreamReader(request.InputStream, request.ContentEncoding))
						{
							text = streamReader.ReadToEnd();
						}
						Console.WriteLine("API Data: " + text);
						if (Url.StartsWith("versioncheck"))
						{
							if (Url.Contains("201809"))
							{
								CachedVersionMonth = 09;
							}
							else
							{
								CachedVersionMonth = 05;
							}
							s = VersionCheckResponse;
						}
						if (Url == ("config/v2"))
						{
							s = Config2.GetDebugConfig();
						}
						if (Url == "platformlogin/v1/getcachedlogins")
						{
							s = getcachedlogins.GetDebugLogin(ulong.Parse(text.Remove(0, 32)), ulong.Parse(text.Remove(0, 22)));
							CachedPlayerID = ulong.Parse(text.Remove(0, 32));
							CachedPlatformID = ulong.Parse(text.Remove(0, 22));
							File.WriteAllText("SaveData\\Profile\\userid.txt", Convert.ToString(CachedPlayerID));
							if (new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/banned.txt").Contains(File.ReadAllText("SaveData\\Profile\\userid.txt")))
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("You are banned. Using this version of OpenRec will not work, please download OpenRec 0.4.2 or prior.");
								Console.ForegroundColor = ConsoleColor.Green;
								start.Program.bannedflag = true;
							}
						}
						if (Url == "platformlogin/v1/loginaccount")
						{
							s = logincached.loginCache(CachedPlayerID, CachedPlatformID);
						}
						if (Url == "platformlogin/v1/createaccount")
						{
							s = logincached.loginCache(CachedPlayerID, CachedPlatformID);
						}
						if (Url == "platformlogin/v1/logincached")
						{
							s = logincached.loginCache(CachedPlayerID, CachedPlatformID);
						}
						if (Url == "relationships/v1/bulkignoreplatformusers")
						{
							s = BlankResponse;
						}
						if (Url == "players/v1/list")
						{
							s = BracketResponse;
						}
						if (Url == "config/v1/amplitude")
						{
							s = Amplitude.amplitude();
						}
						if (Url == "images/v2/named")
						{
							s = ImagesV2Named;
						}
						if (Url == "PlayerReporting/v1/moderationBlockDetails")
						{
							s = ModerationBlockDetails;
							if (start.Program.bannedflag == true)
							{
								s = Banned;
							}
						}
						if (Url == "//api/chat/v2/myChats?mode=0&count=50")
						{
							s = BracketResponse;
						}
						if (Url == "messages/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "relationships/v2/get")
						{
							s = BracketResponse;
						}
						if (Url == "gameconfigs/v1/all")
						{
							s = File.ReadAllText("SaveData\\gameconfigs.txt");
						}
						if (Url.StartsWith("storefronts/v3/giftdropstore"))
						{
							if (CachedVersionMonth == 09)
							{
								s = BracketResponse;
							}
							else
							{
								s = BracketResponse;
							}
						}
						if (Url.StartsWith("storefronts/v3/balance/"))
						{
							s = BracketResponse;
						}
						if (Url == "avatar/v2")
						{
							s = File.ReadAllText("SaveData\\avatar.txt");
						}
						if (Url == "avatar/v2/saved")
						{
							s = BracketResponse;
						}
						if (Url == "avatar/v2/set")
						{
							//for later 2018 builds compatibility
							if (!(text.Contains("FaceFeatures")))
							{
								string postdatacache = text;
								text = postdatacache.Remove(postdatacache.Length - 1, 1) + File.ReadAllText("SaveData\\App\\facefeaturesadd.txt");
							}
							File.WriteAllText("SaveData\\avatar.txt", text);
						}
						if (Url == "settings/v2/")
						{
							s = File.ReadAllText("SaveData\\settings.txt");
						}
						if (Url == "settings/v2/set")
						{
							Settings.SetPlayerSettings(text);
						}
						if (rawUrl == "//api/chat/v2/myChats?mode=0&count=50")
						{
							s = BracketResponse;
						}
						if (Url == "playersubscriptions/v1/my")
						{
							s = BracketResponse;
						}
						if (Url == "avatar/v3/items")
						{
							if (CachedVersionMonth == 09)
							{
								s = File.ReadAllText("SaveData\\avataritems2.txt");
							}
							else
							{
								s = File.ReadAllText("SaveData\\avataritems2.txt");
							}
						}
						if (Url == "equipment/v1/getUnlocked")
						{
							s = File.ReadAllText("SaveData\\equipment.txt");
						}
						if (Url == "avatar/v1/saved")
						{
							s = BracketResponse;
						}
						if (Url == "consumables/v1/getUnlocked")
						{
							if (CachedVersionMonth == 09)
							{
								s = BracketResponse;
							}
							else
							{
								s = File.ReadAllText("SaveData\\consumables.txt");
							}
						}
						if (Url == "avatar/v2/gifts")
						{
							s = BracketResponse;
						}
						if (Url == "storefronts/v2/2")
						{
							s = BlankResponse;
						}
						if (Url == "storefronts/v1/allGiftDrops/2")
						{
							s = BracketResponse;
						}
						if (Url == "objectives/v1/myprogress")
						{
							s = JsonConvert.SerializeObject(new Objective2018());
						}
						if (Url == "rooms/v1/myrooms")
						{
							s = File.ReadAllText("SaveData\\myrooms.txt");
						}
						if (Url == "rooms/v2/myrooms")
						{
							s = BracketResponse;
						}
						if (Url == "rooms/v2/baserooms")
						{
							s = File.ReadAllText("SaveData\\baserooms.txt");
						}
						if (Url == "rooms/v1/mybookmarkedrooms")
						{
							s = BracketResponse;
						}
						if (Url == "rooms/v1/myRecent?skip=0&take=10")
						{
							s = BracketResponse;
						}
						if (Url == "events/v3/list")
						{
							s = Events.list();
						}
						if (Url == "playerevents/v1/all")
						{
							s = PlayerEventsResponse;
						}
						if (Url == "activities/charades/v1/words")
						{
							s = Activities.Charades.words();
						}
						if (Url == "gamesessions/v2/joinrandom")
						{
							s = gamesesh.GameSessions.JoinRandom(text);
						}
						if (Url == "gamesessions/v2/create")
						{
							s = gamesesh.GameSessions.Create(text);
						}
						if (Url == "gamesessions/v3/joinroom")
						{
							s = JsonConvert.SerializeObject(c000041.m000030(text));
						}
						if (rawUrl == "//api/sanitize/v1/isPure")
						{
							s = "{\"IsPure\":true}";
						}
						if (Url == "avatar/v3/saved")
						{
							s = BracketResponse;
						}
						if (Url == "checklist/v1/current")
						{
							s = ChecklistV1Current;
						}
						if (Url == "presence/v1/setplayertype")
						{
							s = BracketResponse;
						}
						if (Url == "challenge/v1/getCurrent")
						{
							s = ChallengesV1GetCurrent;
						}
						if (Url == "rooms/v1/featuredRoomGroup")
						{
							s = BracketResponse;
						}
						if (Url == "rooms/v1/clone")
						{
							s = JsonConvert.SerializeObject(c000099.m00000a(text));
						}
						if (Url.StartsWith("rooms/v2/saveData"))
						{
							//string text26 = "5GDNL91ZY43PXN2YJENTBL";
							//string path = c000004.m000007() + c000041.f000043.Room.Name;
							//File.WriteAllBytes(string.Concat(new string[]
							//{
							//c000004.m000007(),
							//c000041.f000043.Room.Name,
							//"\\room\\",
							//text26,
							//".room"
							//}), m00005d(list.ToArray(), "data.dat"));
							//c000041.f000043.Scenes[0].DataBlobName = text26 + ".room";
							//c000041.f000043.Scenes[0].DataModifiedAt = DateTime.Now;
							//File.WriteAllText(c000004.m000007() + c000041.f000043.Room.Name + "\\RoomDetails.json", JsonConvert.SerializeObject(c000041.f000043));
							//s = JsonConvert.SerializeObject(c00005d.m000035());
						}
						if (Url == "presence/v3/heartbeat")
						{
							if (new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/banned.txt").Contains(File.ReadAllText("SaveData\\Profile\\userid.txt")))
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("You are banned. Using this version of OpenRec will not work, please download OpenRec 0.4.2 or prior.");
								Console.ForegroundColor = ConsoleColor.Green;
								start.Program.bannedflag = true;
								Late2018WebSock.instance.Broadcast(ws.Notification.Reponse.createBannedResponse());
							}
							s = JsonConvert.SerializeObject(Notification2018.Reponse.createResponse(4, c000020.m000027()));
						}
						if (Url == "rooms/v1/featuredRoomGroup")
						{
							s = new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/dormslideshow.txt");
						}
						if (Url.StartsWith("rooms/v1/hot"))
						{
							s = new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/hotrooms.txt");
						}
						if (Url.StartsWith("rooms/v2/instancedetails"))
						{
							s = BracketResponse;
						}
						if (Url.StartsWith("rooms/v2/search?value="))
						{
							CustomRooms.RoomGet(Url.Remove(0, 22));
						}
						if (Url == "rooms/v4/details/29")
						{
							s = File.ReadAllText("SaveData\\Rooms\\Downloaded\\RoomDetails.json");
							Thread.Sleep(100);
						}
						else if (Url.StartsWith("rooms/v4/details"))
						{
							s = JsonConvert.SerializeObject(c00005d.m000023(Convert.ToInt32(Url.Remove(0, 17))));
						}
						if (Url == "images/v1/slideshow")
						{
							s = new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/rcslideshow.txt");
						}
						Console.WriteLine("API Response: " + s);
						bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(400);
						outputStream.Close();
						this.listener.Stop();

					}
				}
			}
			catch (Exception ex4)
			{
				Console.WriteLine(ex4);
				File.WriteAllText("crashdump.txt", Convert.ToString(ex4));
				this.listener.Close();
				new APIServer();
			}
		}
		public static ulong CachedPlayerID = ulong.Parse(File.ReadAllText("SaveData\\Profile\\userid.txt"));
		public static ulong CachedPlatformID = 10000;
		public static int CachedVersionMonth = 01;

		public static string BlankResponse = "";
		public static string BracketResponse = "[]";

		public static string PlayerEventsResponse = "{\"Created\":[],\"Responses\":[]}";
		public static string VersionCheckResponse2 = "{\"VersionStatus\":0}";
		public static string VersionCheckResponse = "{\"ValidVersion\":true}";
		public static string ModerationBlockDetails = "{\"ReportCategory\":0,\"Duration\":0,\"GameSessionId\":0,\"Message\":\"\"}";
		public static string ImagesV2Named = "[{\"FriendlyImageName\":\"DormRoomBucket\",\"ImageName\":\"DormRoomBucket\",\"StartTime\":\"2021-12-27T21:27:38.1880175-08:00\",\"EndTime\":\"2025-12-27T21:27:38.1880399-08:00\"}";
		public static string ChallengesV1GetCurrent = "{\"Success\":true,\"Message\":\"OpenRec\"}";
		public static string ChecklistV1Current = "[{\"Order\":0,\"Objective\":3000,\"Count\":3,\"CreditAmount\":100},{\"Order\":1,\"Objective\":3001,\"Count\":3,\"CreditAmount\":100},{\"Order\":2,\"Objective\":3002,\"Count\":3,\"CreditAmount\":100}]";

		public static string Banned = "{\"ReportCategory\":1,\"Duration\":10000000000000000,\"GameSessionId\":100,\"Message\":\"You have been banned. You are probably a little kid and are now whining at your VR headset. If you aren't a little kid, DM me to appeal.\"}";

		private HttpListener listener = new HttpListener(); 
	}
}
