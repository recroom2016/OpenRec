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
				//2 different servers for 2 different stages of the game, the apis change so much idk anymore
				this.listener.Prefixes.Add("http://localhost:" + start.Program.version + "/");
				if (start.Program.version == "2016")
				{
					for (; ; )
					{
						this.listener.Start();
						Console.WriteLine("APIServer.cs is listening.");
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
						if (Url.StartsWith("players/v1/"))
						{
							s = BracketResponse;
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
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(200);
						outputStream.Close();
						this.listener.Stop();
					}
				}
				if (start.Program.version == "2017")
				{
					for (; ; )
					{
						this.listener.Start();
						Console.WriteLine("APIServer.cs is listening.");
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
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(200);
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
							s = File.ReadAllText("SaveData\\avataritems.txt");
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
							s = BracketResponse; //JsonConvert.SerializeObject(c000099.m00000a(text));
						}
						if (Url.StartsWith("!rooms/v2/saveData"))
						{
							string text26 = "5GDNL91ZY43PXN2YJENTBL";
							string path = c000004.m000007() + c000041.f000043.Room.Name;
							File.WriteAllBytes(string.Concat(new string[]
							{
							c000004.m000007(),
							c000041.f000043.Room.Name,
							"\\room\\",
							text26,
							".room"
							}), m00005d(list.ToArray(), "data.dat"));
							c000041.f000043.Scenes[0].DataBlobName = text26 + ".room";
							c000041.f000043.Scenes[0].DataModifiedAt = DateTime.Now;
							File.WriteAllText(c000004.m000007() + c000041.f000043.Room.Name + "\\RoomDetails.json", JsonConvert.SerializeObject(c000041.f000043));
							s = JsonConvert.SerializeObject(c00005d.m000035());
						}
						if (Url == "presence/v3/heartbeat")
						{
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
						if (Url == "rooms/v4/details/29")
						{
							s = File.ReadAllText("SaveData\\Rooms\\Downloaded\\RoomDetails.json");
							Thread.Sleep(100);
						}
						else if (Url.StartsWith("rooms/v4/details"))
						{
							s = JsonConvert.SerializeObject(c00005d.m000023(Convert.ToInt32(Url.Remove(0, 17))));
						}
						Console.WriteLine("API Response: " + s);
						bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(50);
						outputStream.Close();
						this.listener.Stop();
						
					}
				}
			}
			catch (Exception ex4)
			{
				Console.WriteLine(ex4);
				File.WriteAllText("crashdump.txt", Convert.ToString(ex4));
			}
		}
		public static ulong CachedPlayerID = 1;
		public static ulong CachedPlatformID = 10000;
		public static int CachedVersionMonth = 01;

		public static string BlankResponse = "";
		public static string BracketResponse = "[]";

		public static string PlayerEventsResponse = "{\"Created\":[],\"Responses\":[]}";
		public static string VersionCheckResponse = "{\"ValidVersion\":true}";
		public static string ModerationBlockDetails = "{\"ReportCategory\":0,\"Duration\":0,\"GameSessionId\":0,\"Message\":\"\"}";
		public static string ImagesV2Named = "[{\"FriendlyImageName\":\"DormRoomBucket\",\"ImageName\":\"OpenRec\",\"StartTime\":\"2021-12-27T21:27:38.1880175-08:00\",\"EndTime\":\"2043-12-27T21:27:38.1880399-08:00\"}";
		public static string ChallengesV1GetCurrent = "{\"Success\":true,\"Message\":\"OpenRec\"}";
		public static string ChecklistV1Current = "[{\"Order\":0,\"Objective\":3000,\"Count\":3,\"CreditAmount\":100},{\"Order\":1,\"Objective\":3001,\"Count\":3,\"CreditAmount\":100},{\"Order\":2,\"Objective\":3002,\"Count\":3,\"CreditAmount\":100}]";

		public static string Banned = "{\"ReportCategory\":1,\"Duration\":10000000000000000,\"GameSessionId\":100,\"Message\":\"You have been banned. You are probably a little kid and are now whining at your VR headset. If you aren't a little kid, DM me to appeal.\"}";
		private HttpListener listener = new HttpListener(); 




		private static byte[] m00005d(byte[] p0, string p1)
		{
			BinaryReader binaryReader = new BinaryReader(new MemoryStream(p0));
			try
			{
				while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
				{
					bool flag = true;
					bool flag2 = false;
					APIServer.c0000a7 c0000a = new APIServer.c0000a7();
					while (flag)
					{
						List<byte> list = new List<byte>();
						bool flag3 = true;
						while (flag3)
						{
							byte b = binaryReader.ReadByte();
							if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
							{
								if (b == 13)
								{
									binaryReader.ReadByte();
									flag3 = false;
								}
								else
								{
									list.Add(b);
								}
							}
							else
							{
								flag3 = false;
							}
						}
						string @string = Encoding.ASCII.GetString(list.ToArray());
						Console.WriteLine(@string);
						if (@string.StartsWith("Content-Length: "))
						{
							string s = @string.Remove(0, 16);
							c0000a.m000017(int.Parse(s));
						}
						if (@string.Contains(p1))
						{
							Console.WriteLine("Has file");
							flag2 = true;
						}
						if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
						{
							if (binaryReader.ReadByte() == 13)
							{
								flag = false;
								binaryReader.ReadByte();
							}
							else
							{
								binaryReader.BaseStream.Position -= 1L;
							}
						}
						else
						{
							flag = false;
						}
					}
					if (flag2)
					{
						List<byte> list2 = new List<byte>();
						for (; ; )
						{
							if (binaryReader.ReadByte() == 13)
							{
								if (binaryReader.ReadByte() == 10)
								{
									if (binaryReader.ReadByte() == 45)
									{
										break;
									}
									binaryReader.BaseStream.Position -= 3L;
								}
								else
								{
									binaryReader.BaseStream.Position -= 2L;
								}
							}
							else
							{
								binaryReader.BaseStream.Position -= 1L;
							}
							byte item = binaryReader.ReadByte();
							list2.Add(item);
						}
						return list2.ToArray();
					}
					if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
					{
						binaryReader.ReadBytes(c0000a.m000016());
					}
				}
			}
			finally
			{
				((IDisposable)binaryReader).Dispose();
			}
			return null;
		}

		public sealed class c0000a7
		{
			public string m000001()
			{
				return this.f00000a;
			}
			public void m000034(string p0)
			{
				this.f00000a = p0;
			}
			public string m000005()
			{
				return this.f000002;
			}
			public void m00003f(string p0)
			{
				this.f000002 = p0;
			}
			public int m000016()
			{
				return this.f000020;
			}
			public void m000017(int p0)
			{
				this.f000020 = p0;
			}
			public byte[] m000061()
			{
				return this.f000084;
			}
			public void m000062(byte[] p0)
			{
				this.f000084 = p0;
			}
			private string f00000a;
			private string f000002;
			private int f000020;
			private byte[] f000084;
		}
	}
}
