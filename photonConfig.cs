using System;

namespace api
{
	// Token: 0x02000016 RID: 22
	public class photonConfig
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000022BF File Offset: 0x000004BF
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000022C7 File Offset: 0x000004C7
		public string CloudRegion { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000022D8 File Offset: 0x000004D8
		public bool CrcCheckEnabled { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000022E1 File Offset: 0x000004E1
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000022E9 File Offset: 0x000004E9
		public bool EnableServerTracingAfterDisconnect { get; set; }
	}
}