using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using start;

namespace server
{
	// Token: 0x02000050 RID: 80
	internal class NameServer
	{
		
		// Token: 0x06000227 RID: 551 RVA: 0x00006D1C File Offset: 0x00004F1C
		public NameServer()
		{
			try
			{
				Console.WriteLine("[NameServer.cs] has started.");
				new Thread(new ThreadStart(this.StartListen)).Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine("An Exception Occurred while Listening :" + ex.ToString());
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00006D84 File Offset: 0x00004F84
		private void StartListen()
		{
			//nameserver is ONLY for 2018
			this.listener.Prefixes.Add("http://localhost:20181/");
			for (; ; )
			{
				this.listener.Start();
				Console.WriteLine("[NameServer.cs] is listening.");
				HttpListenerContext context = this.listener.GetContext();
				HttpListenerRequest request = context.Request;
				HttpListenerResponse response = context.Response;
				string rawUrl = request.RawUrl;
				string s = "";
				if (Program.version == "2019") 
                {
					NSData2 data2 = new NSData2()
					{
						API = "http://localhost:2018",
						Notifications = "http://localhost:20161",
						Images = "http://localhost:20182"
					};
					s = JsonConvert.SerializeObject(data2);
				}
				else
                {
					NSData data = new NSData()
					{
						API = "http://localhost:2018",
						Notifications = "http://localhost:20161",
						Images = "http://localhost:20182"
					};
					s = JsonConvert.SerializeObject(data);
				}
				Console.WriteLine("API Response: " + s);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				response.ContentLength64 = (long)bytes.Length;
				Stream outputStream = response.OutputStream;
				outputStream.Write(bytes, 0, bytes.Length);
				Thread.Sleep(1);
				outputStream.Close();
				this.listener.Stop();
			}
		}

		public static string VersionCheckResponse = "{\"ValidVersion\":true}";

		public static string BlankResponse = "";

		public class NSData
        {
			public string API { get; set; }
			public string Notifications { get; set; }
			public string Images { get; set; }
		}

		public class NSData2
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002256 File Offset: 0x00000456
			// (set) Token: 0x06000041 RID: 65 RVA: 0x0000225E File Offset: 0x0000045E
			public string Auth { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00002267 File Offset: 0x00000467
			// (set) Token: 0x06000043 RID: 67 RVA: 0x0000226F File Offset: 0x0000046F
			public string API { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002278 File Offset: 0x00000478
			// (set) Token: 0x06000045 RID: 69 RVA: 0x00002280 File Offset: 0x00000480
			public string WWW { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002289 File Offset: 0x00000489
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00002291 File Offset: 0x00000491
			public string Notifications { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000048 RID: 72 RVA: 0x0000229A File Offset: 0x0000049A
			// (set) Token: 0x06000049 RID: 73 RVA: 0x000022A2 File Offset: 0x000004A2
			public string Images { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600004A RID: 74 RVA: 0x000022AB File Offset: 0x000004AB
			// (set) Token: 0x0600004B RID: 75 RVA: 0x000022B3 File Offset: 0x000004B3
			public string Commerce { get; set; }
		}
		// Token: 0x04000192 RID: 402
		private HttpListener listener = new HttpListener();
	}
}
