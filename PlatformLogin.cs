using System;
using Newtonsoft.Json;

namespace api2017
{
	// Token: 0x02000032 RID: 50
	internal class PlatformLogin
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002905 File Offset: 0x00000B05
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000290D File Offset: 0x00000B0D
		public string Token { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002916 File Offset: 0x00000B16
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000291E File Offset: 0x00000B1E
		public ulong PlayerId { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002927 File Offset: 0x00000B27
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000292F File Offset: 0x00000B2F
		public string Error { get; set; }

		// Token: 0x0600013D RID: 317 RVA: 0x00005114 File Offset: 0x00003314
		public static string v4(ulong userid)
		{
			PlatformLogin value = new PlatformLogin
			{
				Token = "j3923mHJG032jew",
				PlayerId = userid,
				Error = ""
			};
			return JsonConvert.SerializeObject(value);
		}
	}
}
