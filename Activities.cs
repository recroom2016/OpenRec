using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace api
{
	// Token: 0x0200000B RID: 11
	internal class Activities
	{
		// Token: 0x0200000C RID: 12
		public class Charades
		{
			// Token: 0x0600001D RID: 29 RVA: 0x0000410C File Offset: 0x0000230C
			public static string words()
			{
				List<Activities.Charades.word> value = new List<Activities.Charades.word>
				{
                    new Activities.Charades.word
                    {
                        EN_US = "talking ben",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "lemon",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "grape",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "roblox",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "tree",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "cloud",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "iphone",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "your house",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "spaghetti",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "lean",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "bitcoin",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "nft",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "grass",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "recroom2016",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "joker",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "fortnite",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "woman",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "spiderman",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "vr",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "among us",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "coach",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "coach with a gun",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "funny fish",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "skinwalker",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "christmas tree",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "ur mom",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "stick of ram",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "big mac",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "ninetndo switch",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "crescendo",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "boxing",
                        Difficulty = 0
                    },
                    new Activities.Charades.word
                    {
                        EN_US = "angry birds",
                        Difficulty = 0
                    }
                };
				return JsonConvert.SerializeObject(value);
			}

			// Token: 0x0200000D RID: 13
			public class word
			{
				// Token: 0x17000004 RID: 4
				// (get) Token: 0x0600001F RID: 31 RVA: 0x000020DC File Offset: 0x000002DC
				// (set) Token: 0x06000020 RID: 32 RVA: 0x000020E4 File Offset: 0x000002E4
				public string EN_US { get; set; }

				// Token: 0x17000005 RID: 5
				// (get) Token: 0x06000021 RID: 33 RVA: 0x000020ED File Offset: 0x000002ED
				// (set) Token: 0x06000022 RID: 34 RVA: 0x000020F5 File Offset: 0x000002F5
				public int Difficulty { get; set; }
			}
		}
	}
}
