using System;

namespace api2018
{
	// Token: 0x02000030 RID: 48
	public class Objective2018Entry
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000286C File Offset: 0x00000A6C
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002874 File Offset: 0x00000A74
		public int Index { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000287D File Offset: 0x00000A7D
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002885 File Offset: 0x00000A85
		public int Group { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000288E File Offset: 0x00000A8E
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00002896 File Offset: 0x00000A96
		public float Progress { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000289F File Offset: 0x00000A9F
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000028A7 File Offset: 0x00000AA7
		public float VisualProgress { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000028B0 File Offset: 0x00000AB0
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000028B8 File Offset: 0x00000AB8
		public bool IsCompleted { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000028C1 File Offset: 0x00000AC1
		// (set) Token: 0x0600012E RID: 302 RVA: 0x000028C9 File Offset: 0x00000AC9
		public bool IsRewarded { get; set; }
	}
}
