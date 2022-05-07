using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ws;

namespace vaultgamesesh
{
	// Token: 0x02000005 RID: 5
	public class Notification2018
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002A18 File Offset: 0x00000C18
		public static string ProcessRequest(string jsonData)
		{
			Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);
			bool flag = dictionary.ContainsKey("api");
			string result;
			if (flag)
			{
				string text = (string)dictionary["api"];
				string text2 = text;
				bool flag2 = text2 != null;
				if (flag2)
				{
					bool flag3 = text2 == "playerSubscriptions/v1/update";
					if (flag3)
					{
						Console.WriteLine("[18CWS] Game client sent presence update.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(12, c000020.m000027()));
					}
					bool flag4 = text2 == "heartbeat2";
					if (flag4)
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

		// Token: 0x02000038 RID: 56
		public enum ResponseResult
		{
			// Token: 0x040000A8 RID: 168
			RelationshipChanged = 1,
			// Token: 0x040000A9 RID: 169
			MessageReceived,
			// Token: 0x040000AA RID: 170
			MessageDeleted,
			// Token: 0x040000AB RID: 171
			PresenceHeartbeatResponse,
			// Token: 0x040000AC RID: 172
			SubscriptionListUpdated = 9,
			// Token: 0x040000AD RID: 173
			SubscriptionUpdateProfile = 11,
			// Token: 0x040000AE RID: 174
			SubscriptionUpdatePresence,
			// Token: 0x040000AF RID: 175
			SubscriptionUpdateGameSession,
			// Token: 0x040000B0 RID: 176
			SubscriptionUpdateRoom,
			// Token: 0x040000B1 RID: 177
			ModerationQuitGame = 20,
			// Token: 0x040000B2 RID: 178
			ModerationUpdateRequired,
			// Token: 0x040000B3 RID: 179
			ModerationKick,
			// Token: 0x040000B4 RID: 180
			ModerationKickAttemptFailed,
			// Token: 0x040000B5 RID: 181
			GiftPackageReceived = 30,
			// Token: 0x040000B6 RID: 182
			ProfileJuniorStatusUpdate = 40,
			// Token: 0x040000B7 RID: 183
			RelationshipsInvalid = 50,
			// Token: 0x040000B8 RID: 184
			StorefrontBalanceAdd = 60
		}

		// Token: 0x02000039 RID: 57
		public class Reponse
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A5EB File Offset: 0x000087EB
			// (set) Token: 0x06000168 RID: 360 RVA: 0x0000A5F3 File Offset: 0x000087F3
			public int Id { get; set; }

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000169 RID: 361 RVA: 0x0000A5FC File Offset: 0x000087FC
			// (set) Token: 0x0600016A RID: 362 RVA: 0x0000A604 File Offset: 0x00008804
			public object Msg { get; set; }

			// Token: 0x0600016B RID: 363 RVA: 0x0000A610 File Offset: 0x00008810
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
