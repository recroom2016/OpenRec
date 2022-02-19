using System;

namespace api2018

{
	// Token: 0x02000031 RID: 49
	public class Objective2018Group
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000028D2 File Offset: 0x00000AD2
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000028DA File Offset: 0x00000ADA
		public int Group { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000028E3 File Offset: 0x00000AE3
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000028EB File Offset: 0x00000AEB
		public bool IsCompleted { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000028F4 File Offset: 0x00000AF4
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000028FC File Offset: 0x00000AFC
		public string ClearedAt { get; set; }
	}
}
