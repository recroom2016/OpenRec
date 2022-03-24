using System;
using System.Runtime.CompilerServices;

namespace vaultgamesesh
{ 
	// Token: 0x02000007 RID: 7
	internal sealed class c00006b
	{
		// Token: 0x02000035 RID: 53
		public sealed class c00006c
		{
			// Token: 0x17000077 RID: 119
			// (get) Token: 0x0600015A RID: 346 RVA: 0x0000BAD8 File Offset: 0x00009CD8
			// (set) Token: 0x0600015B RID: 347 RVA: 0x0000BAF0 File Offset: 0x00009CF0
			public ulong[] ExpectedPlayerIds
			{
				[CompilerGenerated]
				get
				{
					return this.f000001;
				}
				[CompilerGenerated]
				set
				{
					this.f000001 = value;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x0600015C RID: 348 RVA: 0x0000BAFC File Offset: 0x00009CFC
			// (set) Token: 0x0600015D RID: 349 RVA: 0x0000BB14 File Offset: 0x00009D14
			public c00006b.c00006d[] RegionPings
			{
				[CompilerGenerated]
				get
				{
					return this.f00004f;
				}
				[CompilerGenerated]
				set
				{
					this.f00004f = value;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600015E RID: 350 RVA: 0x0000BB20 File Offset: 0x00009D20
			// (set) Token: 0x0600015F RID: 351 RVA: 0x0000BB38 File Offset: 0x00009D38
			public string[] RoomTags
			{
				[CompilerGenerated]
				get
				{
					return this.f000003;
				}
				[CompilerGenerated]
				set
				{
					this.f000003 = value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000160 RID: 352 RVA: 0x0000BB44 File Offset: 0x00009D44
			// (set) Token: 0x06000161 RID: 353 RVA: 0x0000BB5C File Offset: 0x00009D5C
			public string RoomName
			{
				[CompilerGenerated]
				get
				{
					return this.f000035;
				}
				[CompilerGenerated]
				set
				{
					this.f000035 = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000162 RID: 354 RVA: 0x0000BB68 File Offset: 0x00009D68
			// (set) Token: 0x06000163 RID: 355 RVA: 0x0000BB80 File Offset: 0x00009D80
			public string SceneName
			{
				[CompilerGenerated]
				get
				{
					return this.f000036;
				}
				[CompilerGenerated]
				set
				{
					this.f000036 = value;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000164 RID: 356 RVA: 0x0000BB8C File Offset: 0x00009D8C
			// (set) Token: 0x06000165 RID: 357 RVA: 0x0000BBA4 File Offset: 0x00009DA4
			public int AdditionalPlayerJoinMode
			{
				[CompilerGenerated]
				get
				{
					return this.f000006;
				}
				[CompilerGenerated]
				set
				{
					this.f000006 = value;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000166 RID: 358 RVA: 0x0000BBB0 File Offset: 0x00009DB0
			// (set) Token: 0x06000167 RID: 359 RVA: 0x0000BBC8 File Offset: 0x00009DC8
			public bool Private
			{
				[CompilerGenerated]
				get
				{
					return this.f000016;
				}
				[CompilerGenerated]
				set
				{
					this.f000016 = value;
				}
			}

			// Token: 0x040000B8 RID: 184
			private ulong[] f000001;

			// Token: 0x040000B9 RID: 185
			private c00006b.c00006d[] f00004f;

			// Token: 0x040000BA RID: 186
			private string[] f000003;

			// Token: 0x040000BB RID: 187
			private string f000035;

			// Token: 0x040000BC RID: 188
			private string f000036;

			// Token: 0x040000BD RID: 189
			private int f000006;

			// Token: 0x040000BE RID: 190
			private bool f000016;
		}

		// Token: 0x02000036 RID: 54
		public sealed class c00006d
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000169 RID: 361 RVA: 0x0000BBDC File Offset: 0x00009DDC
			// (set) Token: 0x0600016A RID: 362 RVA: 0x0000BBF4 File Offset: 0x00009DF4
			public string Region
			{
				[CompilerGenerated]
				get
				{
					return this.f00000a;
				}
				[CompilerGenerated]
				set
				{
					this.f00000a = value;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600016B RID: 363 RVA: 0x0000BC00 File Offset: 0x00009E00
			// (set) Token: 0x0600016C RID: 364 RVA: 0x0000BC18 File Offset: 0x00009E18
			public int Ping
			{
				[CompilerGenerated]
				get
				{
					return this.f00000b;
				}
				[CompilerGenerated]
				set
				{
					this.f00000b = value;
				}
			}

			// Token: 0x040000BF RID: 191
			private string f00000a;

			// Token: 0x040000C0 RID: 192
			private int f00000b;
		}
	}
}
