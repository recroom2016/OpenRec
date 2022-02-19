using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace api2018
{
	// Token: 0x0200001F RID: 31
	internal class Events
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000024DC File Offset: 0x000006DC
		public long EventId { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000024E5 File Offset: 0x000006E5
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000024ED File Offset: 0x000006ED
		public string Name { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000024F6 File Offset: 0x000006F6
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000024FE File Offset: 0x000006FE
		public string Description { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002507 File Offset: 0x00000707
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000250F File Offset: 0x0000070F
		public DateTime StartTime { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002518 File Offset: 0x00000718
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002520 File Offset: 0x00000720
		public DateTime EndTime { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002529 File Offset: 0x00000729
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002531 File Offset: 0x00000731
		public string PosterImageName { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000253A File Offset: 0x0000073A
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002542 File Offset: 0x00000742
		public long CreatorPlayerId { get; set; }

		// Token: 0x060000BC RID: 188 RVA: 0x00004BE8 File Offset: 0x00002DE8
		public static string list()
		{
			List<Events> value = new List<Events>();
			return JsonConvert.SerializeObject(value);
		}
	}
}
