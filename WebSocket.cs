using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using server;
using start;
using System.Net;
using System.IO;

namespace ws
{
	// Token: 0x02000008 RID: 8
	internal class WebSocket
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0000418C File Offset: 0x0000238C
		public WebSocket()
		{
			WebSocketServer webSocketServer = new WebSocketServer(string.Format("ws://localhost:20161"));
			webSocketServer.AddWebSocketService<WebSocket.NotificationV2>("/api/notification/v2");
			webSocketServer.AddWebSocketService<WebSocket.NotificationV2>("/hub/v1");
			webSocketServer.Start();
			Console.WriteLine("[WebSocket.cs] has started.");
			Console.WriteLine("[WebSocket.cs] is listening.");
		}

		public class NotificationV2 : WebSocketBehavior
		{
			// Token: 0x06000013 RID: 19 RVA: 0x0000209D File Offset: 0x0000029D
			protected override void OnMessage(MessageEventArgs e)
			{
				Console.WriteLine("WebSocket.cs called for.");
				base.Send(Notification.ProcessRequest(e.Data));
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