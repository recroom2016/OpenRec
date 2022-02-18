using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ws
{
	// Token: 0x02000029 RID: 41
	public class Notification
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00004EF4 File Offset: 0x000030F4
		public static string ProcessRequest(string jsonData)
		{ 
			string result;
			{
				result = jsonData;
			}
			return result;
		}

		// Token: 0x0200002A RID: 42
		public enum ResponseResult
		{
			// Token: 0x04000091 RID: 145
			RelationshipChanged = 1,
			// Token: 0x04000092 RID: 146
			MessageReceived,
			// Token: 0x04000093 RID: 147
			MessageDeleted,
			// Token: 0x04000094 RID: 148
			PresenceHeartbeatResponse,
			// Token: 0x04000095 RID: 149
			SubscriptionListUpdated = 9,
			// Token: 0x04000096 RID: 150
			SubscriptionUpdateProfile = 11,
			// Token: 0x04000097 RID: 151
			SubscriptionUpdatePresence,
			// Token: 0x04000098 RID: 152
			SubscriptionUpdateGameSession,
			// Token: 0x04000099 RID: 153
			SubscriptionUpdateRoom,
			// Token: 0x0400009A RID: 154
			ModerationQuitGame = 20,
			// Token: 0x0400009B RID: 155
			ModerationUpdateRequired,
			// Token: 0x0400009C RID: 156
			ModerationKick,
			// Token: 0x0400009D RID: 157
			ModerationKickAttemptFailed,
			// Token: 0x0400009E RID: 158
			GiftPackageReceived = 30,
			// Token: 0x0400009F RID: 159
			ProfileJuniorStatusUpdate = 40,
			// Token: 0x040000A0 RID: 160
			RelationshipsInvalid = 50,
			// Token: 0x040000A1 RID: 161
			StorefrontBalanceAdd = 60
		}

		// Token: 0x0200002B RID: 43
		public class Reponse
		{
			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000106 RID: 262 RVA: 0x000027DA File Offset: 0x000009DA
			// (set) Token: 0x06000107 RID: 263 RVA: 0x000027E2 File Offset: 0x000009E2
			public int Id { get; set; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000108 RID: 264 RVA: 0x000027EB File Offset: 0x000009EB
			// (set) Token: 0x06000109 RID: 265 RVA: 0x000027F3 File Offset: 0x000009F3
			public object Msg { get; set; }

			// Token: 0x0600010A RID: 266 RVA: 0x00004FC0 File Offset: 0x000031C0
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
