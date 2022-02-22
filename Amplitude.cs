using System;
using Newtonsoft.Json;

namespace api
{
	// Token: 0x0200005A RID: 90
	internal class Amplitude
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000342D File Offset: 0x0000162D
		public static string amplitude()
		{
			return JsonConvert.SerializeObject(new Amplitude
			{
				AmplitudeKey = "NoKeyProvided"
			});
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00003444 File Offset: 0x00001644
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000344C File Offset: 0x0000164C
		public string AmplitudeKey { get; set; }
	}
}
