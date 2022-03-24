using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace vaultgamesesh
{
	// Token: 0x02000008 RID: 8
	public sealed class c000079
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00004F14 File Offset: 0x00003114
		public static List<c000079.c00007a> m000009()
		{
			return c000079.f000031;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004F2B File Offset: 0x0000312B
		public static void m000036(List<c000079.c00007a> p0)
		{
			c000079.f000031 = p0;
		}

		// Token: 0x04000010 RID: 16
		private static List<c000079.c00007a> f000031;

		// Token: 0x02000037 RID: 55
		public sealed class c00007a
		{
			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600016E RID: 366 RVA: 0x0000BC2C File Offset: 0x00009E2C
			// (set) Token: 0x0600016F RID: 367 RVA: 0x0000BC44 File Offset: 0x00009E44
			public ulong Id
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

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x06000170 RID: 368 RVA: 0x0000BC50 File Offset: 0x00009E50
			// (set) Token: 0x06000171 RID: 369 RVA: 0x0000BC68 File Offset: 0x00009E68
			public string DisplayName
			{
				[CompilerGenerated]
				get
				{
					return this.f000002;
				}
				[CompilerGenerated]
				set
				{
					this.f000002 = value;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000172 RID: 370 RVA: 0x0000BC74 File Offset: 0x00009E74
			// (set) Token: 0x06000173 RID: 371 RVA: 0x0000BC8C File Offset: 0x00009E8C
			public string Username
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

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000174 RID: 372 RVA: 0x0000BC98 File Offset: 0x00009E98
			// (set) Token: 0x06000175 RID: 373 RVA: 0x0000BCB0 File Offset: 0x00009EB0
			public int Level
			{
				[CompilerGenerated]
				get
				{
					return this.f000004;
				}
				[CompilerGenerated]
				set
				{
					this.f000004 = value;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000176 RID: 374 RVA: 0x0000BCBC File Offset: 0x00009EBC
			// (set) Token: 0x06000177 RID: 375 RVA: 0x0000BCD4 File Offset: 0x00009ED4
			public int XP
			{
				[CompilerGenerated]
				get
				{
					return this.f000005;
				}
				[CompilerGenerated]
				set
				{
					this.f000005 = value;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000178 RID: 376 RVA: 0x0000BCE0 File Offset: 0x00009EE0
			// (set) Token: 0x06000179 RID: 377 RVA: 0x0000BCF8 File Offset: 0x00009EF8
			public bool Developer
			{
				[CompilerGenerated]
				get
				{
					return this.f000039;
				}
				[CompilerGenerated]
				set
				{
					this.f000039 = value;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600017A RID: 378 RVA: 0x0000BD04 File Offset: 0x00009F04
			// (set) Token: 0x0600017B RID: 379 RVA: 0x0000BD1C File Offset: 0x00009F1C
			public bool IsBooster
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

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600017C RID: 380 RVA: 0x0000BD28 File Offset: 0x00009F28
			// (set) Token: 0x0600017D RID: 381 RVA: 0x0000BD40 File Offset: 0x00009F40
			public int BootMultiplier
			{
				[CompilerGenerated]
				get
				{
					return this.f000008;
				}
				[CompilerGenerated]
				set
				{
					this.f000008 = value;
				}
			}

			// Token: 0x040000C1 RID: 193
			private ulong f000001;

			// Token: 0x040000C2 RID: 194
			private string f000002;

			// Token: 0x040000C3 RID: 195
			private string f000003;

			// Token: 0x040000C4 RID: 196
			private int f000004;

			// Token: 0x040000C5 RID: 197
			private int f000005;

			// Token: 0x040000C6 RID: 198
			private bool f000039;

			// Token: 0x040000C7 RID: 199
			private bool f000016;

			// Token: 0x040000C8 RID: 200
			private int f000008;
		}
	}
}