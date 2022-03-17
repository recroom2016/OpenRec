using System;
using Newtonsoft.Json;

namespace api2018
{
	// Token: 0x02000081 RID: 129
	public class Sanitize
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0000C51C File Offset: 0x0000A71C
		public static Sanitize.SanitizeRequestDTO SanitizeChatRequest(string chatMessage)
		{
			Sanitize.SanitizePostDTO sanitizePostDTO = JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(chatMessage);
			return new Sanitize.SanitizeRequestDTO
			{
				StringValue = sanitizePostDTO.Value
			};
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C51C File Offset: 0x0000A71C
		public static Sanitize.SanitizeRequestDTO SanitizeRequest(string chatMessage)
		{
			Sanitize.SanitizePostDTO sanitizePostDTO = JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(chatMessage);
			return new Sanitize.SanitizeRequestDTO
			{
				StringValue = sanitizePostDTO.Value
			};
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C544 File Offset: 0x0000A744
		public static string SanitizeChatMessageRequest(string postData, string signature)
		{
			Sanitize.SanitizePostDTO sanitizePostDTO = JsonConvert.DeserializeObject<Sanitize.SanitizePostDTO>(postData);
			return "\"" + sanitizePostDTO.Value + "\"";
		}

		// Token: 0x02000082 RID: 130
		public class SanitizePostDTO
		{
			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060003A1 RID: 929 RVA: 0x000039AA File Offset: 0x00001BAA
			// (set) Token: 0x060003A2 RID: 930 RVA: 0x000039B2 File Offset: 0x00001BB2
			public string Value { get; set; }

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060003A3 RID: 931 RVA: 0x000039BB File Offset: 0x00001BBB
			// (set) Token: 0x060003A4 RID: 932 RVA: 0x000039C3 File Offset: 0x00001BC3
			public int ReplacementChar { get; set; }
		}

		// Token: 0x02000083 RID: 131
		public class SanitizeRequestDTO
		{
			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x000039CC File Offset: 0x00001BCC
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x000039D4 File Offset: 0x00001BD4
			public string StringValue { get; set; }
		}

		// Token: 0x02000084 RID: 132
		public class SanitizeStringRequest
		{
			// Token: 0x060003A9 RID: 937 RVA: 0x000039DD File Offset: 0x00001BDD
			public SanitizeStringRequest(string text)
			{
				this.value = text;
			}

			// Token: 0x040002E6 RID: 742
			public string value;
		}
	}
}
