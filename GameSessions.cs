using System;
using Newtonsoft.Json;
using api;
using server;
using System.IO;
namespace gamesesh

{
	// Token: 0x02000020 RID: 32
	public class GameSessions
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00004C08 File Offset: 0x00002E08
		public static string JoinRandom(string jsonData)
		{
			long? creatorid = 1243409L;
			long gamesessionid = long.Parse(start.Program.version + "1");
			Console.WriteLine("OpenRec GameSession Room");
			GameSessions.JoinRandomRequest joinRandomRequest = JsonConvert.DeserializeObject<GameSessions.JoinRandomRequest>(jsonData);
			if (File.ReadAllText("SaveData\\App\\privaterooms.txt") == "Enabled")
			{
				gamesessionid = new Random().Next(0, 99);
			}
			if (start.Program.version == "2017")
            {
				creatorid = (long?)APIServer.CachedPlayerID;
			}
			if (start.Program.bannedflag == true)
			{
				gamesessionid = 100L;
			}
			Config.localGameSession = new GameSessions.SessionInstance
			{
				GameSessionId = gamesessionid,
				RegionId = "us",
				RoomId = joinRandomRequest.ActivityLevelIds[0],
				RecRoomId = null,
				EventId = null,
				CreatorPlayerId = creatorid,
				Name = "OpenRec Room",
				ActivityLevelId = joinRandomRequest.ActivityLevelIds[0],
				Private = false,
				Sandbox = false,
				SupportsScreens = true,
				SupportsVR = true,
				GameInProgress = false,
				MaxCapacity = 20,
				IsFull = false
			};
			
			return JsonConvert.SerializeObject(new GameSessions.JoinResult
			{
				Result = 0,
				GameSession = Config.localGameSession
			});
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000254B File Offset: 0x0000074B
		public static string StatusSession()
		{
			return JsonConvert.SerializeObject(new GameSessions.PlayerStatus
			{
				PlayerId = Convert.ToUInt64(File.ReadAllText("SaveData\\Profile\\userid.txt")),
				IsOnline = true,
				InScreenMode = false,
				GameSession = Config.localGameSession
			});
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004D24 File Offset: 0x00002F24
		public static string Create(string jsonData)
		{
			long gamesessionid = 20161L;
			Console.WriteLine("OpenRec GameSession Custom Room");
			if (File.ReadAllText("SaveData\\App\\privaterooms.txt") == "Enabled")
			{
				gamesessionid = new Random().Next(0, 99);
			}
			if (start.Program.bannedflag == true)
			{
				gamesessionid = 100L;
			}
			GameSessions.CreateRequest createRequest = JsonConvert.DeserializeObject<GameSessions.CreateRequest>(jsonData);
			Config.localGameSession = new GameSessions.SessionInstance
			{
				GameSessionId = gamesessionid,
				RegionId = "us",
				RoomId = createRequest.ActivityLevelId,
				RecRoomId = null,
				EventId = null,
				CreatorPlayerId = (long?)APIServer.CachedPlayerID,
				Name = "OpenRec Custom Room",
				ActivityLevelId = createRequest.ActivityLevelId,
				Private = false,
				Sandbox = true,
				SupportsScreens = true,
				SupportsVR = true,
				GameInProgress = false,
				MaxCapacity = 20,
				IsFull = false
			};
			return JsonConvert.SerializeObject(new GameSessions.JoinResult
			{
				Result = 0,
				GameSession = Config.localGameSession
			});
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000257B File Offset: 0x0000077B
		public static GameSessions.PlayerStatus StatusSessionInstance()
		{
			return new GameSessions.PlayerStatus
			{
				PlayerId = Convert.ToUInt64(File.ReadAllText("SaveData\\Profile\\userid.txt")),
				IsOnline = true,
				InScreenMode = false,
				GameSession = Config.localGameSession
			};
		}

		// Token: 0x02000021 RID: 33
		public enum JoinResultIDs
		{
			// Token: 0x0400005E RID: 94
			Success,
			// Token: 0x0400005F RID: 95
			NoSuchGame,
			// Token: 0x04000060 RID: 96
			PlayerNotOnline,
			// Token: 0x04000061 RID: 97
			InsufficientSpace,
			// Token: 0x04000062 RID: 98
			EventNotStarted,
			// Token: 0x04000063 RID: 99
			EventAlreadyFinished,
			// Token: 0x04000064 RID: 100
			EventCreatorNotReady,
			// Token: 0x04000065 RID: 101
			BlockedFromRoom,
			// Token: 0x04000066 RID: 102
			ProfileLocked,
			// Token: 0x04000067 RID: 103
			NoBirthday,
			// Token: 0x04000068 RID: 104
			MarkedForDelete,
			// Token: 0x04000069 RID: 105
			JuniorNotAllowed,
			// Token: 0x0400006A RID: 106
			Banned,
			// Token: 0x0400006B RID: 107
			NoSuchRoom = 20,
			// Token: 0x0400006C RID: 108
			RoomCreatorNotReady,
			// Token: 0x0400006D RID: 109
			RoomIsNotActive,
			// Token: 0x0400006E RID: 110
			RoomBlockedByCreator,
			// Token: 0x0400006F RID: 111
			RoomBlockingCreator,
			// Token: 0x04000070 RID: 112
			RoomIsPrivate
		}

		// Token: 0x02000022 RID: 34
		public class PlayerStatus
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x000025A6 File Offset: 0x000007A6
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x000025AE File Offset: 0x000007AE
			public ulong PlayerId { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x000025B7 File Offset: 0x000007B7
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x000025BF File Offset: 0x000007BF
			public bool IsOnline { get; set; }

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x000025C8 File Offset: 0x000007C8
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x000025D0 File Offset: 0x000007D0
			public bool InScreenMode { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x000025D9 File Offset: 0x000007D9
			// (set) Token: 0x060000CA RID: 202 RVA: 0x000025E1 File Offset: 0x000007E1
			public GameSessions.SessionInstance GameSession { get; set; }
		}

		// Token: 0x02000023 RID: 35
		public class SessionInstance
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000CC RID: 204 RVA: 0x000025EA File Offset: 0x000007EA
			// (set) Token: 0x060000CD RID: 205 RVA: 0x000025F2 File Offset: 0x000007F2
			public long GameSessionId { get; set; }

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000CE RID: 206 RVA: 0x000025FB File Offset: 0x000007FB
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00002603 File Offset: 0x00000803
			public string RegionId { get; set; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000260C File Offset: 0x0000080C
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002614 File Offset: 0x00000814
			public string RoomId { get; set; }

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000261D File Offset: 0x0000081D
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002625 File Offset: 0x00000825
			public long? EventId { get; set; }

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000262E File Offset: 0x0000082E
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002636 File Offset: 0x00000836
			public long? RecRoomId { get; set; }

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000263F File Offset: 0x0000083F
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002647 File Offset: 0x00000847
			public long? CreatorPlayerId { get; set; }

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002650 File Offset: 0x00000850
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002658 File Offset: 0x00000858
			public string Name { get; set; }

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000DA RID: 218 RVA: 0x00002661 File Offset: 0x00000861
			// (set) Token: 0x060000DB RID: 219 RVA: 0x00002669 File Offset: 0x00000869
			public string ActivityLevelId { get; set; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000DC RID: 220 RVA: 0x00002672 File Offset: 0x00000872
			// (set) Token: 0x060000DD RID: 221 RVA: 0x0000267A File Offset: 0x0000087A
			public bool Private { get; set; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000DE RID: 222 RVA: 0x00002683 File Offset: 0x00000883
			// (set) Token: 0x060000DF RID: 223 RVA: 0x0000268B File Offset: 0x0000088B
			public bool Sandbox { get; set; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002694 File Offset: 0x00000894
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000269C File Offset: 0x0000089C
			public bool SupportsVR { get; set; }

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x000026A5 File Offset: 0x000008A5
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x000026AD File Offset: 0x000008AD
			public bool SupportsScreens { get; set; }

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000026B6 File Offset: 0x000008B6
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x000026BE File Offset: 0x000008BE
			public bool GameInProgress { get; set; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000026C7 File Offset: 0x000008C7
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x000026CF File Offset: 0x000008CF
			public int MaxCapacity { get; set; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x000026D8 File Offset: 0x000008D8
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x000026E0 File Offset: 0x000008E0
			public bool IsFull { get; set; }
		}

		// Token: 0x02000024 RID: 36
		public class JoinRandomRequest
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060000EB RID: 235 RVA: 0x000026E9 File Offset: 0x000008E9
			// (set) Token: 0x060000EC RID: 236 RVA: 0x000026F1 File Offset: 0x000008F1
			public string[] ActivityLevelIds { get; set; }

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060000ED RID: 237 RVA: 0x000026FA File Offset: 0x000008FA
			// (set) Token: 0x060000EE RID: 238 RVA: 0x00002702 File Offset: 0x00000902
			public ulong[] ExpectedPlayerIds { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000EF RID: 239 RVA: 0x0000270B File Offset: 0x0000090B
			// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002713 File Offset: 0x00000913
			public GameSessions.RegionPing[] RegionPings { get; set; }
		}

		public class JoinRoomRequest2
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002345 File Offset: 0x00000545
			// (set) Token: 0x06000061 RID: 97 RVA: 0x0000234D File Offset: 0x0000054D
			public ulong[] ExpectedPlayerIds { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00002356 File Offset: 0x00000556
			// (set) Token: 0x06000063 RID: 99 RVA: 0x0000235E File Offset: 0x0000055E
			public GameSessions.RegionPing[] RegionPings { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002367 File Offset: 0x00000567
			// (set) Token: 0x06000065 RID: 101 RVA: 0x0000236F File Offset: 0x0000056F
			public string[] RoomTags { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002378 File Offset: 0x00000578
			// (set) Token: 0x06000067 RID: 103 RVA: 0x00002380 File Offset: 0x00000580
			public string RoomName { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00002389 File Offset: 0x00000589
			// (set) Token: 0x06000069 RID: 105 RVA: 0x00002391 File Offset: 0x00000591
			public string SceneName { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600006A RID: 106 RVA: 0x0000239A File Offset: 0x0000059A
			// (set) Token: 0x0600006B RID: 107 RVA: 0x000023A2 File Offset: 0x000005A2
			public int AdditionalPlayerJoinMode { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600006C RID: 108 RVA: 0x000023AB File Offset: 0x000005AB
			// (set) Token: 0x0600006D RID: 109 RVA: 0x000023B3 File Offset: 0x000005B3
			public bool Private { get; set; }
		}
		// Token: 0x02000025 RID: 37

		// Token: 0x02000025 RID: 37
		public class CreateRequest
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000271C File Offset: 0x0000091C
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002724 File Offset: 0x00000924
			public string ActivityLevelId { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000272D File Offset: 0x0000092D
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002735 File Offset: 0x00000935
			public ulong[] ExpectedPlayerIds { get; set; }

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000273E File Offset: 0x0000093E
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002746 File Offset: 0x00000946
			public GameSessions.RegionPing[] RegionPings { get; set; }

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000274F File Offset: 0x0000094F
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002757 File Offset: 0x00000957
			public bool IsSandbox { get; set; }
		}

		// Token: 0x02000026 RID: 38
		public class RegionPing
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00002760 File Offset: 0x00000960
			// (set) Token: 0x060000FC RID: 252 RVA: 0x00002768 File Offset: 0x00000968
			public string Region { get; set; }

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060000FD RID: 253 RVA: 0x00002771 File Offset: 0x00000971
			// (set) Token: 0x060000FE RID: 254 RVA: 0x00002779 File Offset: 0x00000979
			public int Ping { get; set; }
		}

		// Token: 0x02000027 RID: 39
		private class JoinResult
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000100 RID: 256 RVA: 0x00002782 File Offset: 0x00000982
			// (set) Token: 0x06000101 RID: 257 RVA: 0x0000278A File Offset: 0x0000098A
			public int Result { get; set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000102 RID: 258 RVA: 0x00002793 File Offset: 0x00000993
			// (set) Token: 0x06000103 RID: 259 RVA: 0x0000279B File Offset: 0x0000099B
			public GameSessions.SessionInstance GameSession { get; set; }
		}
	}
}
