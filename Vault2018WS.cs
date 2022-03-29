using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using System.Net;
using System.IO;

namespace vaultgamesesh
{
	// Token: 0x02000018 RID: 24
	internal class Late2018WebSock
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00006EB0 File Offset: 0x000050B0
		public Late2018WebSock()
		{
			this.WebSock.AddWebSocketService<Late2018WebSock.NotificationWS>("/api/notification/v2");
			this.WebSock.AddWebSocketService<Late2018WebSock.HubWS>("/hub/v1");
			this.WebSock.Start();
			Console.WriteLine("[LateWebSocket.cs] has started.");
			Console.WriteLine("[LateWebSocket.cs] is listening.");
		}

		// Token: 0x04000047 RID: 71
		public WebSocketServer WebSock = new WebSocketServer("ws://localhost:20161/");

		// Token: 0x0200004A RID: 74
		public class HubWS : WebSocketBehavior
		{
			// Token: 0x060001EA RID: 490 RVA: 0x0000C215 File Offset: 0x0000A415
			protected override void OnMessage(MessageEventArgs e)
			{
				Console.WriteLine("LateWebSocket.cs Hub Requested.");
				base.Send(JsonConvert.SerializeObject(new Late2018WebSock.Hub()));
			}
		}

		// Token: 0x0200004B RID: 75
		public class Hub : WebSocketBehavior
		{
			// Token: 0x060001EC RID: 492 RVA: 0x0000C240 File Offset: 0x0000A440
			public Hub()
			{
				this.accessToken = "AccessDeezNuts";
				this.SupportedTransports = new List<string>();
				this.negotiateVersion = 0;
				this.url = new Uri(string.Format("http://localhost:{0}/", "2018"));
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060001ED RID: 493 RVA: 0x0000C290 File Offset: 0x0000A490
			// (set) Token: 0x060001EE RID: 494 RVA: 0x0000C298 File Offset: 0x0000A498
			public Uri url { get; set; }

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000C2A1 File Offset: 0x0000A4A1
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000C2A9 File Offset: 0x0000A4A9
			public string accessToken { get; set; }

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000C2B2 File Offset: 0x0000A4B2
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000C2BA File Offset: 0x0000A4BA
			public List<string> SupportedTransports { get; set; }

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000C2CB File Offset: 0x0000A4CB
			public int negotiateVersion { get; set; }
		}

		// Token: 0x0200004C RID: 76
		public class NotificationWS : WebSocketBehavior
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
			protected override void OnMessage(MessageEventArgs p0)
			{
				Console.WriteLine("LateWebSocket.csNotif Requested.");
				bool flag = p0.Data == null;
				bool flag2 = flag;
				if (flag2)
				{
					base.Send(string.Empty);
				}
				else
				{
					base.Send(Notification2018.ProcessRequest(p0.Data));
				}
				if (new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/banned.txt").Contains(File.ReadAllText("SaveData\\Profile\\userid.txt")))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("You are banned. Using this version of OpenRec will not work, please download OpenRec 0.4.2 or prior.");
					Console.ForegroundColor = ConsoleColor.Green;
					start.Program.bannedflag = true;
				}
			}
		}
	}
}
