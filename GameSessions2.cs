using System;
using System.Linq;
using Newtonsoft.Json;
using rooms2018;
using System.IO;

namespace gamesessions2018
{
	// Token: 0x0200000F RID: 15
	internal class GameSessions2
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000048F0 File Offset: 0x00002AF0
		public static GameSessions2.JoinResult JoinRoom(string postData)
		{

			GameSessions.JoinRoomRequest2 joinRoomRequest = JsonConvert.DeserializeObject<GameSessions.JoinRoomRequest2>(postData);
			bool flag = Rooms.RecRoomOriginalRooms.ContainsKey(joinRoomRequest.RoomName);
			if (flag)
			{
				GameSessions2.currentRoom = Rooms.RecRoomOriginalRooms[joinRoomRequest.RoomName];
			}
			else
			{
				GameSessions2.currentRoom = Rooms.RecRoomOriginalRooms["DormRoom"];
			}
			int num = 0;
			for (int i = 0; i < GameSessions2.currentRoom.Scenes.Count<Rooms.Scene>(); i++)
			{
				bool flag2 = GameSessions2.currentRoom.Scenes[i].Name == joinRoomRequest.SceneName;
				if (flag2)
				{
					num = i;
				}
			}
			long gamesessionid = 2018L;
			bool sandboxmode = false;
			if (File.ReadAllText("SaveData\\App\\sandbox.txt") == "Enabled")
			{
				sandboxmode = true;
			}
			if (File.ReadAllText("SaveData\\App\\privaterooms.txt") == "Enabled")
			{
				gamesessionid = new Random().Next(0, 100);
			}
			GameSessions2.currentSession = new GameSessions2.SessionData
			{
				GameSessionId = gamesessionid,
				PhotonRegionId = "us",
				PhotonRoomId = GameSessions2.currentRoom.Room.RoomId.ToString(),
				Name = GameSessions2.currentRoom.Room.Name,
				RoomId = GameSessions2.currentRoom.Room.RoomId,
				RoomSceneId = (long)(num + 1),
				RoomSceneLocationId = GameSessions2.currentRoom.Scenes[num].RoomSceneLocationId,
				IsSandbox = sandboxmode,
				DataBlobName = "",
				PlayerEventId = null,
				Private = false,
				GameInProgress = false,
				MaxCapacity = 20,
				IsFull = false
			};
			return new GameSessions2.JoinResult
			{
				Result = 0,
				GameSession = GameSessions2.currentSession,
				RoomDetails = GameSessions2.currentRoom
			};
		}

		// Token: 0x04000019 RID: 25
		public static Rooms.RoomDetail currentRoom;

		// Token: 0x0400001A RID: 26
		public static GameSessions2.SessionData placeholderSession = new GameSessions2.SessionData
		{
			GameSessionId = 1L,
			PhotonRegionId = "us",
			PhotonRoomId = "1",
			Name = "Dorm Room",
			RoomId = 1L,
			RoomSceneId = 1L,
			RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
			IsSandbox = false,
			DataBlobName = "",
			PlayerEventId = null,
			Private = false,
			GameInProgress = false,
			MaxCapacity = 20,
			IsFull = false
		};

		// Token: 0x0400001B RID: 27
		public static GameSessions2.SessionData currentSession;

		// Token: 0x02000010 RID: 16
		public class JoinResult
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000036 RID: 54 RVA: 0x00002202 File Offset: 0x00000402
			// (set) Token: 0x06000037 RID: 55 RVA: 0x0000220A File Offset: 0x0000040A
			public int Result { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00002213 File Offset: 0x00000413
			// (set) Token: 0x06000039 RID: 57 RVA: 0x0000221B File Offset: 0x0000041B
			public GameSessions2.SessionData GameSession { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002224 File Offset: 0x00000424
			// (set) Token: 0x0600003B RID: 59 RVA: 0x0000222C File Offset: 0x0000042C
			public Rooms.RoomDetail RoomDetails { get; set; }
		}

		// Token: 0x02000011 RID: 17
		public class SessionData
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00002235 File Offset: 0x00000435
			// (set) Token: 0x0600003E RID: 62 RVA: 0x0000223D File Offset: 0x0000043D
			public long GameSessionId { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002246 File Offset: 0x00000446
			// (set) Token: 0x06000040 RID: 64 RVA: 0x0000224E File Offset: 0x0000044E
			public string PhotonRegionId { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00002257 File Offset: 0x00000457
			// (set) Token: 0x06000042 RID: 66 RVA: 0x0000225F File Offset: 0x0000045F
			public string PhotonRoomId { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00002268 File Offset: 0x00000468
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00002270 File Offset: 0x00000470
			public string Name { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00002279 File Offset: 0x00000479
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00002281 File Offset: 0x00000481
			public long RoomId { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000047 RID: 71 RVA: 0x0000228A File Offset: 0x0000048A
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00002292 File Offset: 0x00000492
			public long RoomSceneId { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000049 RID: 73 RVA: 0x0000229B File Offset: 0x0000049B
			// (set) Token: 0x0600004A RID: 74 RVA: 0x000022A3 File Offset: 0x000004A3
			public string RoomSceneLocationId { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600004B RID: 75 RVA: 0x000022AC File Offset: 0x000004AC
			// (set) Token: 0x0600004C RID: 76 RVA: 0x000022B4 File Offset: 0x000004B4
			public bool IsSandbox { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600004D RID: 77 RVA: 0x000022BD File Offset: 0x000004BD
			// (set) Token: 0x0600004E RID: 78 RVA: 0x000022C5 File Offset: 0x000004C5
			public string DataBlobName { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600004F RID: 79 RVA: 0x000022CE File Offset: 0x000004CE
			// (set) Token: 0x06000050 RID: 80 RVA: 0x000022D6 File Offset: 0x000004D6
			public long? PlayerEventId { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000051 RID: 81 RVA: 0x000022DF File Offset: 0x000004DF
			// (set) Token: 0x06000052 RID: 82 RVA: 0x000022E7 File Offset: 0x000004E7
			public bool Private { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000053 RID: 83 RVA: 0x000022F0 File Offset: 0x000004F0
			// (set) Token: 0x06000054 RID: 84 RVA: 0x000022F8 File Offset: 0x000004F8
			public bool GameInProgress { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00002301 File Offset: 0x00000501
			// (set) Token: 0x06000056 RID: 86 RVA: 0x00002309 File Offset: 0x00000509
			public int MaxCapacity { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002312 File Offset: 0x00000512
			// (set) Token: 0x06000058 RID: 88 RVA: 0x0000231A File Offset: 0x0000051A
			public bool IsFull { get; set; }
		}

		// Token: 0x02000012 RID: 18
		public enum JoinResultIDs
		{
			// Token: 0x0400002E RID: 46
			Success,
			// Token: 0x0400002F RID: 47
			NoSuchGame,
			// Token: 0x04000030 RID: 48
			PlayerNotOnline,
			// Token: 0x04000031 RID: 49
			InsufficientSpace,
			// Token: 0x04000032 RID: 50
			EventNotStarted,
			// Token: 0x04000033 RID: 51
			EventAlreadyFinished,
			// Token: 0x04000034 RID: 52
			EventCreatorNotReady,
			// Token: 0x04000035 RID: 53
			BlockedFromRoom,
			// Token: 0x04000036 RID: 54
			ProfileLocked,
			// Token: 0x04000037 RID: 55
			NoBirthday,
			// Token: 0x04000038 RID: 56
			MarkedForDelete,
			// Token: 0x04000039 RID: 57
			JuniorNotAllowed,
			// Token: 0x0400003A RID: 58
			Banned,
			// Token: 0x0400003B RID: 59
			NoSuchRoom = 20,
			// Token: 0x0400003C RID: 60
			RoomCreatorNotReady,
			// Token: 0x0400003D RID: 61
			RoomIsNotActive,
			// Token: 0x0400003E RID: 62
			RoomBlockedByCreator,
			// Token: 0x0400003F RID: 63
			RoomBlockingCreator,
			// Token: 0x04000040 RID: 64
			RoomIsPrivate
		}
	}
}
