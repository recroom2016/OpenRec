using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using api;

namespace api
{
	// Token: 0x02000013 RID: 19
	internal class Config2
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002215 File Offset: 0x00000415
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000221D File Offset: 0x0000041D
		public string MessageOfTheDay { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002226 File Offset: 0x00000426
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000222E File Offset: 0x0000042E
		public string CdnBaseUri { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002237 File Offset: 0x00000437
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000223F File Offset: 0x0000043F
		public List<LevelProgressionEntry> LevelProgressionMaps { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002248 File Offset: 0x00000448
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002250 File Offset: 0x00000450
		public MatchmakingConfigParams MatchmakingParams { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002259 File Offset: 0x00000459
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002261 File Offset: 0x00000461
		public Objective[][] DailyObjectives { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000226A File Offset: 0x0000046A
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002272 File Offset: 0x00000472
		public List<ConfigTableEntry> ConfigTable { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000227B File Offset: 0x0000047B
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002283 File Offset: 0x00000483
		public photonConfig PhotonConfig { get; set; }

		// Token: 0x0600005E RID: 94 RVA: 0x00005450 File Offset: 0x00003650
		public static string GetDebugConfig()
		{
			
			return JsonConvert.SerializeObject(new Config2
			{
				MessageOfTheDay = new WebClient().DownloadString("https://raw.githubusercontent.com/recroom2016/OpenRec/master/Update/motd.txt"),
				CdnBaseUri = "http://localhost:20182/",
				LevelProgressionMaps = new List<LevelProgressionEntry>
				{
					new LevelProgressionEntry
					{
						Level = 0,
						RequiredXp = 1
					},
					new LevelProgressionEntry
					{
						Level = 1,
						RequiredXp = 2
					},
					new LevelProgressionEntry
					{
						Level = 2,
						RequiredXp = 3
					},
					new LevelProgressionEntry
					{
						Level = 3,
						RequiredXp = 4
					},
					new LevelProgressionEntry
					{
						Level = 4,
						RequiredXp = 5
					},
					new LevelProgressionEntry
					{
						Level = 5,
						RequiredXp = 6
					},
					new LevelProgressionEntry
					{
						Level = 6,
						RequiredXp = 7
					},
					new LevelProgressionEntry
					{
						Level = 7,
						RequiredXp = 8
					},
					new LevelProgressionEntry
					{
						Level = 8,
						RequiredXp = 9
					},
					new LevelProgressionEntry
					{
						Level = 9,
						RequiredXp = 10
					},
					new LevelProgressionEntry
					{
						Level = 10,
						RequiredXp = 11
					},
					new LevelProgressionEntry
					{
						Level = 11,
						RequiredXp = 12
					},
					new LevelProgressionEntry
					{
						Level = 12,
						RequiredXp = 13
					},
					new LevelProgressionEntry
					{
						Level = 13,
						RequiredXp = 14
					},
					new LevelProgressionEntry
					{
						Level = 14,
						RequiredXp = 15
					},
					new LevelProgressionEntry
					{
						Level = 15,
						RequiredXp = 16
					},
					new LevelProgressionEntry
					{
						Level = 16,
						RequiredXp = 17
					},
					new LevelProgressionEntry
					{
						Level = 17,
						RequiredXp = 18
					},
					new LevelProgressionEntry
					{
						Level = 18,
						RequiredXp = 19
					},
					new LevelProgressionEntry
					{
						Level = 19,
						RequiredXp = 20
					},
					new LevelProgressionEntry
					{
						Level = 20,
						RequiredXp = 21
					}
				},
				MatchmakingParams = new MatchmakingConfigParams
				{
					PreferEmptyRoomsFrequency = 0f,
					PreferFullRoomsFrequency = 1f
				},
				DailyObjectives = Config.dailyObjectives,
				ConfigTable = new List<ConfigTableEntry>
				{
					new ConfigTableEntry
					{
						Key = "Gift.DropChance",
						Value = 0.5f.ToString()
					},
					new ConfigTableEntry
					{
						Key = "Gift.XP",
						Value = 0.5f.ToString()
					}
				},
				PhotonConfig = new photonConfig
				{
					CloudRegion = "us",
					CrcCheckEnabled = false,
					EnableServerTracingAfterDisconnect = false
				}
			});
		}
	}
}
