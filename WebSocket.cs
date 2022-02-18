using System;
using WebSocketSharp;
using WebSocketSharp.Server;

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
			Console.WriteLine("WebSocket.cs has started.");
			Console.WriteLine("WebSocket.cs is listening.");
		}

		// Token: 0x02000009 RID: 9
		public class NotificationV2 : WebSocketBehavior
		{
			// Token: 0x06000013 RID: 19 RVA: 0x0000209D File Offset: 0x0000029D
			protected override void OnMessage(MessageEventArgs e)
			{
				Console.WriteLine("WebSocket.cs called for.");
				base.Send(Notification.ProcessRequest(e.Data));
			}
		}
	}
}