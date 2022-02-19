using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using gamesessions2018;

namespace ws
{
	// Token: 0x0200002A RID: 42
	public class Notification
	{
		// Token: 0x0600010B RID: 267
		public static string ProcessRequest(string jsonData)
		{
			Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
			string result;
			if (dictionary.ContainsKey("api"))
			{
				string text = (string)dictionary["api"];
				string text2 = text;
				if (text2 != null)
				{
					if (text2 == "playerSubscriptions/v1/update")
					{
						Console.WriteLine("WebSocket.cs game client sent presence update.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(12, GameSessions.StatusSessionInstance()));
					}
					if (text2 == "heartbeat2")
					{
						Console.WriteLine("WebSocket.cs heartbeat 2 sent by game client.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(4, GameSessions.StatusSessionInstance()));
					}
				}
				Console.WriteLine("WebSocket.cs unknown API call: " + text);
				result = "";
			}
			else
			{
				result = jsonData;
			}
			return result;
		}

		// Token: 0x0200002B RID: 43
		public enum ResponseResult
		{
			// Token: 0x04000092 RID: 146
			RelationshipChanged = 1,
			// Token: 0x04000093 RID: 147
			MessageReceived,
			// Token: 0x04000094 RID: 148
			MessageDeleted,
			// Token: 0x04000095 RID: 149
			PresenceHeartbeatResponse,
			// Token: 0x04000096 RID: 150
			SubscriptionListUpdated = 9,
			// Token: 0x04000097 RID: 151
			SubscriptionUpdateProfile = 11,
			// Token: 0x04000098 RID: 152
			SubscriptionUpdatePresence,
			// Token: 0x04000099 RID: 153
			SubscriptionUpdateGameSession,
			// Token: 0x0400009A RID: 154
			SubscriptionUpdateRoom,
			// Token: 0x0400009B RID: 155
			ModerationQuitGame = 20,
			// Token: 0x0400009C RID: 156
			ModerationUpdateRequired,
			// Token: 0x0400009D RID: 157
			ModerationKick,
			// Token: 0x0400009E RID: 158
			ModerationKickAttemptFailed,
			// Token: 0x0400009F RID: 159
			GiftPackageReceived = 30,
			// Token: 0x040000A0 RID: 160
			ProfileJuniorStatusUpdate = 40,
			// Token: 0x040000A1 RID: 161
			RelationshipsInvalid = 50,
			// Token: 0x040000A2 RID: 162
			StorefrontBalanceAdd = 60
		}

		// Token: 0x0200002C RID: 44
		public class Reponse
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600010D RID: 269
			// (set) Token: 0x0600010E RID: 270
			public int Id { get; set; }

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600010F RID: 271
			// (set) Token: 0x06000110 RID: 272
			public object Msg { get; set; }

			// Token: 0x06000111 RID: 273
			public static Notification.Reponse createResponse(int id, object msg)
			{
				return new Notification.Reponse
				{
					Id = id,
					Msg = msg
				};
			}
		}
	}
}
