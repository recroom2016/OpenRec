using System;

namespace api
{
	// Token: 0x02000017 RID: 23
	public class LevelProgressionEntry
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000022F2 File Offset: 0x000004F2
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022FA File Offset: 0x000004FA
		public int Level { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002303 File Offset: 0x00000503
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000230B File Offset: 0x0000050B
		public int RequiredXp { get; set; }
	}
}
