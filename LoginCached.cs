using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace api2018
{
	// Token: 0x02000078 RID: 120
	public class logincached
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00003A6C File Offset: 0x00001C6C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003A74 File Offset: 0x00001C74
		public string Error { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00003A7D File Offset: 0x00001C7D
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00003A85 File Offset: 0x00001C85
		public getcachedlogins Player { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00003A8E File Offset: 0x00001C8E
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003A96 File Offset: 0x00001C96
		public string Token { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00003A9F File Offset: 0x00001C9F
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003AA7 File Offset: 0x00001CA7
		public bool FirstLoginOfTheDay { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00003AB0 File Offset: 0x00001CB0
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public ulong AnalyticsSessionId { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00003AC1 File Offset: 0x00001CC1
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003AC9 File Offset: 0x00001CC9
		public bool CanUseScreenMode { get; set; }

		// Token: 0x0600036A RID: 874 RVA: 0x00009044 File Offset: 0x00007244
		public static string loginCache(ulong userid, ulong platformid)
		{
			int level = int.Parse(File.ReadAllText("SaveData\\Profile\\level.txt"));
			string name = File.ReadAllText("SaveData\\Profile\\username.txt");
			return JsonConvert.SerializeObject(new logincached
			{
				Error = "",
				Player = new getcachedlogins
				{
					Id = userid,
					Username = name,
					DisplayName = name,
					XP = 9999,
					Level = level,
					RegistrationStatus = 2,
					Developer = true,
					CanReceiveInvites = false,
					ProfileImageName = name,
					JuniorProfile = false,
					ForceJuniorImages = false,
					PendingJunior = false,
					HasBirthday = true,
					AvoidJuniors = true,
					PlayerReputation = new mPlayerReputation
					{
						Noteriety = 0,
						CheerCredit = 20,
						CheerGeneral = 10,
						CheerHelpful = 10,
						CheerGreatHost = 10,
						CheerSportsman = 10,
						CheerCreative = 10,
						SubscriberCount = 0,
						SubscribedCount = 0,
						SelectedCheer = 0
					},
					PlatformIds = new List<mPlatformID>
					{
						new mPlatformID
						{
							Platform = 0,
							PlatformId = platformid
						}
					}
				},
				Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOjEsImV4cCI6MTYxOTI4NzQ2MSwidmVycyI6IjIwMTcxMTE3X0VBIn0.-GqtcqPwAzr9ZJioTiz5v0Kl4HMMjH8hFMtVzQtRN5c",
				FirstLoginOfTheDay = true,
				AnalyticsSessionId = 392394UL,
				CanUseScreenMode = true
			}); 
		}
	}
}
