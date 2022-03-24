using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ws;

namespace vaultgamesesh
{
	// Token: 0x0200000B RID: 11
	public class Notification2018
	{
		// Token: 0x06000025 RID: 37
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
						Console.WriteLine("[18CWS] Game client sent presence update.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(12, c000020.m000027()));
					}
					if (text2 == "heartbeat2")
					{
						Console.WriteLine("[18CWS] Heartbeat 2 sent by game client.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(4, c000020.m000027()));
					}
				}
				Console.WriteLine("[18CWS] Unknown CWS call: " + text);
				result = "";
			}
			else
			{
				result = jsonData;
			}
			return result;
		}

		// Token: 0x0200003B RID: 59
		public enum ResponseResult
		{
			// Token: 0x040000DF RID: 223
			RelationshipChanged = 1,
			// Token: 0x040000E0 RID: 224
			MessageReceived,
			// Token: 0x040000E1 RID: 225
			MessageDeleted,
			// Token: 0x040000E2 RID: 226
			PresenceHeartbeatResponse,
			// Token: 0x040000E3 RID: 227
			SubscriptionListUpdated = 9,
			// Token: 0x040000E4 RID: 228
			SubscriptionUpdateProfile = 11,
			// Token: 0x040000E5 RID: 229
			SubscriptionUpdatePresence,
			// Token: 0x040000E6 RID: 230
			SubscriptionUpdateGameSession,
			// Token: 0x040000E7 RID: 231
			SubscriptionUpdateRoom,
			// Token: 0x040000E8 RID: 232
			ModerationQuitGame = 20,
			// Token: 0x040000E9 RID: 233
			ModerationUpdateRequired,
			// Token: 0x040000EA RID: 234
			ModerationKick,
			// Token: 0x040000EB RID: 235
			ModerationKickAttemptFailed,
			// Token: 0x040000EC RID: 236
			GiftPackageReceived = 30,
			// Token: 0x040000ED RID: 237
			ProfileJuniorStatusUpdate = 40,
			// Token: 0x040000EE RID: 238
			RelationshipsInvalid = 50,
			// Token: 0x040000EF RID: 239
			StorefrontBalanceAdd = 60
		}

		// Token: 0x0200003C RID: 60
		public class Reponse
		{
			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000185 RID: 389
			// (set) Token: 0x06000186 RID: 390
			public int Id { get; set; }

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000187 RID: 391
			// (set) Token: 0x06000188 RID: 392
			public object Msg { get; set; }

			// Token: 0x06000189 RID: 393
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
