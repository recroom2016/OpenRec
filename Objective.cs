using System;

namespace api

{
	// Token: 0x02000018 RID: 24
	public class Objective
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002314 File Offset: 0x00000514
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000231C File Offset: 0x0000051C
		public int type { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002325 File Offset: 0x00000525
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000232D File Offset: 0x0000052D
		public int score { get; set; }
	}
}