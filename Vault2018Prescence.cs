using System;
using System.Runtime.CompilerServices;
using server;
using System.IO;

namespace vaultgamesesh
{
	// Token: 0x02000004 RID: 4
	internal sealed class c000020
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000225C File Offset: 0x0000045C
		public static c000020.c000022 m000027()
		{
			bool flag = c000041.f000013 == null;
			bool flag2 = flag;
			c000041.c000044 gameSession;
			if (flag2)
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

		// Token: 0x02000026 RID: 38
		public enum enum021
		{

		}

		// Token: 0x02000027 RID: 39
		public sealed class c000022
		{
			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000CE RID: 206 RVA: 0x0000B1F8 File Offset: 0x000093F8
			// (set) Token: 0x060000CF RID: 207 RVA: 0x0000B210 File Offset: 0x00009410
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

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000B21C File Offset: 0x0000941C
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000B234 File Offset: 0x00009434
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

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000B240 File Offset: 0x00009440
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000B258 File Offset: 0x00009458
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

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000B264 File Offset: 0x00009464
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000B27C File Offset: 0x0000947C
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

			// Token: 0x04000071 RID: 113
			private ulong f000001;

			// Token: 0x04000072 RID: 114
			private bool f000037;

			// Token: 0x04000073 RID: 115
			private int f000020;

			// Token: 0x04000074 RID: 116
			private c000041.c000044 f000038;
		}
	}
}