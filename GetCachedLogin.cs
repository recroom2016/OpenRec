using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using api2018;
using System.IO;

namespace api2018
{
	// Token: 0x02000076 RID: 118
	public class getcachedlogins
	{
		// Token: 0x0600033C RID: 828 RVA: 0x00008F30 File Offset: 0x00007130
		public static string GetDebugLogin(ulong userid, ulong platformid)
		{
			int level = int.Parse(File.ReadAllText("SaveData\\Profile\\level.txt"));
			string name = File.ReadAllText("SaveData\\Profile\\username.txt");
			return JsonConvert.SerializeObject(new List<getcachedlogins>
			{
				new getcachedlogins
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
				}
				
			});
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000395C File Offset: 0x00001B5C
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003964 File Offset: 0x00001B64
		public ulong Id { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000396D File Offset: 0x00001B6D
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00003975 File Offset: 0x00001B75
		public string Username { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000397E File Offset: 0x00001B7E
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00003986 File Offset: 0x00001B86
		public string DisplayName { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000398F File Offset: 0x00001B8F
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003997 File Offset: 0x00001B97
		public int XP { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000039A0 File Offset: 0x00001BA0
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000039A8 File Offset: 0x00001BA8
		public int Level { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000039B1 File Offset: 0x00001BB1
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000039B9 File Offset: 0x00001BB9
		public int RegistrationStatus { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000039C2 File Offset: 0x00001BC2
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000039CA File Offset: 0x00001BCA
		public bool Developer { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000039D3 File Offset: 0x00001BD3
		// (set) Token: 0x0600034C RID: 844 RVA: 0x000039DB File Offset: 0x00001BDB
		public bool CanReceiveInvites { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000039E4 File Offset: 0x00001BE4
		// (set) Token: 0x0600034E RID: 846 RVA: 0x000039EC File Offset: 0x00001BEC
		public string ProfileImageName { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600034F RID: 847 RVA: 0x000039F5 File Offset: 0x00001BF5
		// (set) Token: 0x06000350 RID: 848 RVA: 0x000039FD File Offset: 0x00001BFD
		public bool JuniorProfile { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00003A06 File Offset: 0x00001C06
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003A0E File Offset: 0x00001C0E
		public bool ForceJuniorImages { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00003A17 File Offset: 0x00001C17
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003A1F File Offset: 0x00001C1F
		public bool PendingJunior { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00003A28 File Offset: 0x00001C28
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003A30 File Offset: 0x00001C30
		public bool HasBirthday { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00003A39 File Offset: 0x00001C39
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003A41 File Offset: 0x00001C41
		public bool AvoidJuniors { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00003A4A File Offset: 0x00001C4A
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00003A52 File Offset: 0x00001C52
		public mPlayerReputation PlayerReputation { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00003A5B File Offset: 0x00001C5B
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003A63 File Offset: 0x00001C63
		public List<mPlatformID> PlatformIds { get; set; }
	}
}
