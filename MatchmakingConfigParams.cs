using System;

namespace api
{
	// Token: 0x02000015 RID: 21
	internal class MatchmakingConfigParams
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000229D File Offset: 0x0000049D
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022A5 File Offset: 0x000004A5
		public float PreferFullRoomsFrequency { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000022AE File Offset: 0x000004AE
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000022B6 File Offset: 0x000004B6
		public float PreferEmptyRoomsFrequency { get; set; }
	}
}
