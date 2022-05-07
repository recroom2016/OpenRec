using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using gamesesh;

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
						Console.WriteLine("[WSS] Game client sent presence update.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(12, GameSessions.StatusSessionInstance()));
					}
					if (text2 == "heartbeat2")
					{
						Console.WriteLine("[WSS] Heartbeat 2 sent by game client.");
						return JsonConvert.SerializeObject(Notification.Reponse.createResponse(4, GameSessions.StatusSessionInstance()));
					}
				}
				Console.WriteLine("[WSS] Unknown API call: " + text);
				result = "";
			}
			else
			{
				result = jsonData;
			}
			return result;
		}

		// Token: 0x0200002B RID: 43
		public enum ResponseResults
		{
			RelationshipChanged = 1,
			MessageReceived,
			MessageDeleted,
			PresenceHeartbeatResponse,
			SubscriptionListUpdated = 9,
			SubscriptionUpdateProfile = 11,
			SubscriptionUpdatePresence,
			SubscriptionUpdateGameSession,
			SubscriptionUpdateRoom = 15,
			ModerationQuitGame = 20,
			ModerationUpdateRequired,
			ModerationKick,
			ModerationKickAttemptFailed,
			ServerMaintenance = 25,
			GiftPackageReceived = 30,
			ProfileJuniorStatusUpdate = 40,
			RelationshipsInvalid = 50,
			StorefrontBalanceAdd = 60,
			ConsumableMappingAdded = 70,
			ConsumableMappingRemoved,
			PlayerEventCreated = 80,
			PlayerEventUpdated,
			PlayerEventDeleted,
			PlayerEventResponseChanged,
			PlayerEventResponseDeleted,
			PlayerEventStateChanged,
			ChatMessageReceived = 90
		}

		public class Reponse
		{
			public int Id { get; set; }

			public object Msg { get; set; }
			
			public static Notification.Reponse createResponse(int id, object msg)
			{
				return new Notification.Reponse
				{
					Id = id,
					Msg = msg
				};
			}

			public static Notification.Reponse createBannedResponse()
			{
				return new Notification.Reponse
				{
					Id = (int)ResponseResults.ModerationKick,
					Msg = new api.ModerationBlockDetails()
                    {
						ReportCategory = 1,
						Duration = int.MaxValue,
						GameSessionId = 100L,
						Message = "You have been banned. You are probably a little kid and are now whining at your VR headset. If you aren't a little kid, DM me to appeal."
					}
				};
			}
		}
	}
}
