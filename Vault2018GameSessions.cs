using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace vaultgamesesh
{
	// Token: 0x02000005 RID: 5
	internal sealed class c000041
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000022C0 File Offset: 0x000004C0
		public static c000041.c000044 m00002f()
		{
			return new c000041.c000044
			{
				GameSessionId = 20181L,
				PhotonRegionId = "us",
				PhotonRoomId = "1",
				Name = "DormRoom",
				RoomId = 1L,
				RoomSceneId = 1L,
				RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
				IsSandbox = false,
				DataBlobName = string.Empty,
				PlayerEventId = null,
				Private = false,
				GameInProgress = false,
				MaxCapacity = 20,
				IsFull = false
			};
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002370 File Offset: 0x00000570
		public static c000041.c000042 m000030(string p0)
		{
			c00006b.c00006c c00006c = JsonConvert.DeserializeObject<c00006b.c00006c>(p0);
			Console.WriteLine("[BackEnd] Room Name: " + c00006c.RoomName);
			Thread.Sleep(1);
			Console.WriteLine("[BackEnd] Scene Name: " + c00006c.SceneName);
			bool flag = c00005d.m00003b().ContainsKey(c00006c.RoomName);
			if (flag)
			{
				c000041.f000043 = c00005d.m00003b()[c00006c.RoomName];
			}
			else
			{
				bool flag2 = c00005d.m00003a().ContainsKey(c00006c.RoomName);
				if (flag2)
				{
					c000041.f000043 = c00005d.m00003a()[c00006c.RoomName];
				}
				else
				{
					c000041.f000043 = c00005d.f000050["DormRoom"];
				}
			}
			int num = 0;
			for (int i = 0; i < c000041.f000043.Scenes.Count<c00005d.c00005f>(); i++)
			{
				bool flag3 = c000041.f000043.Scenes[i].Name == c00006c.SceneName;
				if (flag3)
				{
					num = i;
				}
			}
			string text = string.Format("{0}", c000041.f000043.Scenes[num].RoomId);
			bool flag4 = c000041.f000013 != null && text + c000004.f000003 == c000041.f000013.PhotonRoomId;
			if (flag4)
			{
				text += "Instance2";
			}
			text += c000004.f000003;
			bool @private = c00006c.Private;
            if (@private)
            {
                text += string.Format("Pri{0}", server.APIServer.CachedPlayerID);
            }
			long gameseshid = 20181L;
			if (start.Program.bannedflag == true)
			{
				gameseshid = 100L;
				text += "BANNED";
			}
			
			c000041.f000013 = new c000041.c000044
			{
				GameSessionId = gameseshid,
				PhotonRegionId = "us",
				PhotonRoomId = text,
				Name = c000041.f000043.Room.Name,
				RoomId = (long)c000041.f000043.Room.RoomId,
				RoomSceneId = (long)(num + 1),
				RoomSceneLocationId = c000041.f000043.Scenes[num].RoomSceneLocationId,
				IsSandbox = c000041.f000043.Scenes[num].IsSandbox,
				DataBlobName = c000041.f000043.Scenes[num].DataBlobName,
				PlayerEventId = null,
				Private = c00006c.Private,
				GameInProgress = false,
				MaxCapacity = 20,
				IsFull = false
			};
			c000041.c000042 c = new c000041.c000042();
			c.Result = 0;
			c.GameSession = c000041.f000013;
			c.RoomDetails = c000041.f000043;
			Console.WriteLine(JsonConvert.SerializeObject(c));
			return c;
		}

		// Token: 0x0400000B RID: 11
		public static c00005d.c000060 f000043;

		// Token: 0x0400000C RID: 12
		public static c000041.c000044 f000013;

		// Token: 0x02000028 RID: 40
		public sealed class c000042
		{
			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000B290 File Offset: 0x00009490
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000B2A8 File Offset: 0x000094A8
			public int Result
			{
				[CompilerGenerated]
				get
				{
					return this.f00001f;
				}
				[CompilerGenerated]
				set
				{
					this.f00001f = value;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000B2B4 File Offset: 0x000094B4
			// (set) Token: 0x060000DA RID: 218 RVA: 0x0000B2CC File Offset: 0x000094CC
			public c000041.c000044 GameSession
			{
				[CompilerGenerated]
				get
				{
					return this.f000013;
				}
				[CompilerGenerated]
				set
				{
					this.f000013 = value;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000DB RID: 219 RVA: 0x0000B2D8 File Offset: 0x000094D8
			// (set) Token: 0x060000DC RID: 220 RVA: 0x0000B2F0 File Offset: 0x000094F0
			public c00005d.c000060 RoomDetails
			{
				[CompilerGenerated]
				get
				{
					return this.f000045;
				}
				[CompilerGenerated]
				set
				{
					this.f000045 = value;
				}
			}

			// Token: 0x04000075 RID: 117
			private int f00001f;

			// Token: 0x04000076 RID: 118
			private c000041.c000044 f000013;

			// Token: 0x04000077 RID: 119
			private c00005d.c000060 f000045;
		}

		// Token: 0x02000029 RID: 41
		public enum enum043
		{

		}

		// Token: 0x0200002A RID: 42
		public sealed class c000044
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000DE RID: 222 RVA: 0x0000B304 File Offset: 0x00009504
			// (set) Token: 0x060000DF RID: 223 RVA: 0x0000B31C File Offset: 0x0000951C
			public long GameSessionId
			{

				get
				{
					return this.f00002c;
				}

				set
				{
					this.f00002c = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000B326 File Offset: 0x00009526
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000B32E File Offset: 0x0000952E
			public string PhotonRegionId { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000B338 File Offset: 0x00009538
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000B350 File Offset: 0x00009550
			public string PhotonRoomId
			{

				get
				{
					return this.f000003;
				}

				set
				{
					this.f000003 = value;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000B35C File Offset: 0x0000955C
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000B374 File Offset: 0x00009574
			public string Name
			{

				get
				{
					return this.f000035;
				}

				set
				{
					this.f000035 = value;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000B380 File Offset: 0x00009580
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000B398 File Offset: 0x00009598
			public long RoomId
			{

				get
				{
					return this.f00000d;
				}

				set
				{
					this.f00000d = value;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000B3A4 File Offset: 0x000095A4
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000B3BC File Offset: 0x000095BC
			public long RoomSceneId
			{

				get
				{
					return this.f000046;
				}

				set
				{
					this.f000046 = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000EA RID: 234 RVA: 0x0000B3C8 File Offset: 0x000095C8
			// (set) Token: 0x060000EB RID: 235 RVA: 0x0000B3E0 File Offset: 0x000095E0
			public string RoomSceneLocationId
			{

				get
				{
					return this.f00000f;
				}

				set
				{
					this.f00000f = value;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000EC RID: 236 RVA: 0x0000B3EC File Offset: 0x000095EC
			// (set) Token: 0x060000ED RID: 237 RVA: 0x0000B404 File Offset: 0x00009604
			public bool IsSandbox
			{

				get
				{
					return this.f000017;
				}

				set
				{
					this.f000017 = value;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000EE RID: 238 RVA: 0x0000B410 File Offset: 0x00009610
			// (set) Token: 0x060000EF RID: 239 RVA: 0x0000B428 File Offset: 0x00009628
			public string DataBlobName
			{

				get
				{
					return this.f000009;
				}

				set
				{
					this.f000009 = value;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000B434 File Offset: 0x00009634
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000B44C File Offset: 0x0000964C
			public long? PlayerEventId
			{

				get
				{
					return this.f000047;
				}

				set
				{
					this.f000047 = value;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000B458 File Offset: 0x00009658
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000B470 File Offset: 0x00009670
			public bool Private
			{

				get
				{
					return this.f000019;
				}

				set
				{
					this.f000019 = value;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000B47C File Offset: 0x0000967C
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000B494 File Offset: 0x00009694
			public bool GameInProgress
			{

				get
				{
					return this.f00001a;
				}

				set
				{
					this.f00001a = value;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000B4A0 File Offset: 0x000096A0
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000B4B8 File Offset: 0x000096B8
			public int MaxCapacity
			{

				get
				{
					return this.f000048;
				}

				set
				{
					this.f000048 = value;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000B4C4 File Offset: 0x000096C4
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000B4DC File Offset: 0x000096DC
			public bool IsFull
			{

				get
				{
					return this.f00001c;
				}

				set
				{
					this.f00001c = value;
				}
			}

			// Token: 0x0400007A RID: 122
			private long f00002c;

			// Token: 0x0400007B RID: 123
			private string f000002;

			// Token: 0x0400007C RID: 124
			private string f000003;

			// Token: 0x0400007D RID: 125
			private string f000035;

			// Token: 0x0400007E RID: 126
			private long f00000d;

			// Token: 0x0400007F RID: 127
			private long f000046;

			// Token: 0x04000080 RID: 128
			private string f00000f;

			// Token: 0x04000081 RID: 129
			private bool f000017;

			// Token: 0x04000082 RID: 130
			private string f000009;

			// Token: 0x04000083 RID: 131
			private long? f000047;

			// Token: 0x04000084 RID: 132
			private bool f000019;

			// Token: 0x04000085 RID: 133
			private bool f00001a;

			// Token: 0x04000086 RID: 134
			private int f000048;

			// Token: 0x04000087 RID: 135
			private bool f00001c;
		}
	}
}
