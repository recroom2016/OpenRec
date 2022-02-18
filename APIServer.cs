using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using api;
using api2018;

namespace server
{

	internal class APIServer
	{
		
		public APIServer()
		{
			try
			{
				Console.WriteLine("APIServer.cs has started.");
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
							Console.WriteLine("API Requested: " + rawUrl);
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
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(400);
						outputStream.Close();
						this.listener.Stop();
					}
				}
				else if (start.Program.version == "2017")
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
							Console.WriteLine("API Requested: " + rawUrl);
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
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
						response.ContentLength64 = (long)bytes.Length;
						Stream outputStream = response.OutputStream;
						outputStream.Write(bytes, 0, bytes.Length);
						Thread.Sleep(400);
						outputStream.Close();
						this.listener.Stop();
					}
				}
				else if (start.Program.version == "2018")
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
						if (!(Url == ""))
						{
							Console.WriteLine("API Requested: " + Url);
						}
						else
						{
							Console.WriteLine("API Requested: " + rawUrl);
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
						}
						if (Url == "platformlogin/v1/logincached")
                        {
							s = logincached.loginCache(CachedPlayerID, CachedPlatformID);
                        }
						if (Url == "relationships/v1/bulkignoreplatformusers")
						{
							s = BlankResponse;
						}
						if (Url == "config/v1/amplitude")
						{
							s = Amplitude.amplitude();
						}
						if (Url == "images/v2/named")
                        {
							s = BlankResponse;
                        }
						if (Url == "PlayerReporting/v1/moderationBlockDetails")
                        {
							s = ModerationBlockDetails;
                        }
						Console.WriteLine("API Response: " + s);
						byte[] bytes = Encoding.UTF8.GetBytes(s);
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
            }
        }

        public static ulong CachedPlayerID = 1;
		public static ulong CachedPlatformID = 10000;
		public static string VersionCheckResponse = "{\"ValidVersion\":true}";
		public static string BlankResponse = "[]";
		public static string ModerationBlockDetails = "{\"ReportCategory\":0,\"Duration\":0,\"GameSessionId\":0,\"Message\":\"\"}";
		public static string ImagesV2Named = "[{\"FriendlyImageName\":\"DormRoomBucket\",\"ImageName\":\"OpenRec\",\"StartTime\":\"2021-12-27T21:27:38.1880175-08:00\",\"EndTime\":\"2043-12-27T21:27:38.1880399-08:00\"}";
		
		private HttpListener listener = new HttpListener();
	}
}
