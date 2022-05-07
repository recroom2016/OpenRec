using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace vaultgamesesh
{
	// Token: 0x02000007 RID: 7
	internal sealed class c000020
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002B20 File Offset: 0x00000D20
		public static c000020.c000022 m000027()
		{
			bool flag = c000041.f000013 == null;
			bool flag2 = flag;
			bool flag3 = flag2;
			c000041.c000044 gameSession;
			if (flag3)
			{
				gameSession = c000041.m00002f();
			}
			else
			{
				gameSession = c000041.f000013;
			}
			return new c000020.c000022
			{
				PlayerId = Convert.ToUInt64(File.ReadAllText("SaveData\\Profile\\userid.txt")),
				IsOnline = true,
				PlayerType = 2,
				GameSession = gameSession
			};
		}

	
		// Token: 0x0200003C RID: 60
		public sealed class c000022
		{
			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600017E RID: 382 RVA: 0x0000A768 File Offset: 0x00008968
			// (set) Token: 0x0600017F RID: 383 RVA: 0x0000A780 File Offset: 0x00008980
			public ulong PlayerId
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

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000180 RID: 384 RVA: 0x0000A78C File Offset: 0x0000898C
			// (set) Token: 0x06000181 RID: 385 RVA: 0x0000A7A4 File Offset: 0x000089A4
			public bool IsOnline
			{
				[CompilerGenerated]
				get
				{
					return this.f000037;
				}
				[CompilerGenerated]
				set
				{
					this.f000037 = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000182 RID: 386 RVA: 0x0000A7B0 File Offset: 0x000089B0
			// (set) Token: 0x06000183 RID: 387 RVA: 0x0000A7C8 File Offset: 0x000089C8
			public int PlayerType
			{
				[CompilerGenerated]
				get
				{
					return this.f000020;
				}
				[CompilerGenerated]
				set
				{
					this.f000020 = value;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000184 RID: 388 RVA: 0x0000A7D4 File Offset: 0x000089D4
			// (set) Token: 0x06000185 RID: 389 RVA: 0x0000A7EC File Offset: 0x000089EC
			public c000041.c000044 GameSession
			{
				[CompilerGenerated]
				get
				{
					return this.f000038;
				}
				[CompilerGenerated]
				set
				{
					this.f000038 = value;
				}
			}

			// Token: 0x040000C4 RID: 196
			private ulong f000001;

			// Token: 0x040000C5 RID: 197
			private bool f000037;

			// Token: 0x040000C6 RID: 198
			private int f000020;

			// Token: 0x040000C7 RID: 199
			private c000041.c000044 f000038;
		}
	}
}
