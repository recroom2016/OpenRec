using System;
using System.IO;
using Newtonsoft.Json;

namespace api2017
{
	// Token: 0x0200003A RID: 58
	internal class getorcreate
	{
		public static string GetOrCreate(ulong userid)
		{
			int level = int.Parse(File.ReadAllText("SaveData\\Profile\\level.txt"));
			string name = File.ReadAllText("SaveData\\Profile\\username.txt");
			return JsonConvert.SerializeObject(new Profiles
			{
				Id = userid,
				Username = name,
				DisplayName = name,
				XP = 48,
				Level = level,
				Reputation = 0,
				Verified = true,
				Developer = true,
				HasEmail = true,
				CanReceiveInvites = false,
				ProfileImageName = name,
				HasBirthday = true
			});
		}
		// Token: 0x06000197 RID: 407 RVA: 0x0000550C File Offset: 0x0000370C
		public static string GetOrCreateArray(ulong userid)
		{
			int level = int.Parse(File.ReadAllText("SaveData\\Profile\\level.txt"));
			string name = File.ReadAllText("SaveData\\Profile\\username.txt");
			return JsonConvert.SerializeObject(new Profiles[]
			{
				new Profiles
				{
					Id = userid,
					Username = name,
					DisplayName = name,
					XP = 48,
					Level = level,
					Reputation = 0,
					Verified = true,
					Developer = true,
					HasEmail = true,
					CanReceiveInvites = false,
					ProfileImageName = name,
					JuniorProfile = false,
					ForceJuniorImages = false,
					HasBirthday = true
				}
				
			});
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002BBE File Offset: 0x00000DBE
		
	}
}
