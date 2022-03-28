using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using vaultgamesesh;

namespace vaultgamesesh
{

	internal sealed class c000099
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000B134 File Offset: 0x00009334
		public static c000099.c00009c m00002f()
		{
			List<c00005d.c000062> list = new List<c00005d.c000062>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000050)
			{
				c00005d.c000062 item = new c00005d.c000062
				{
					RoomName = keyValuePair.Value.Room.Name,
					RoomId = (long)((int)keyValuePair.Value.Room.RoomId),
					ImageName = keyValuePair.Value.Room.ImageName
				};
				list.Add(item);
			}
			return new c000099.c00009c
			{
				Name = "Check Out All The Rooms Today!",
				FeaturedRooms = list
			};
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B204 File Offset: 0x00009404
		public static List<c00005d.c000061> m000009()
		{
			List<c00005d.c000061> list = new List<c00005d.c000061>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.m00003b())
			{
				list.Add(keyValuePair.Value.Room);
			}
			return list;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B268 File Offset: 0x00009468
		public static List<c00005d.c000061> m000035()
		{
			List<c00005d.c000061> list = new List<c00005d.c000061>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000024)
			{
				list.Add(keyValuePair.Value.Room);
			}
			return list;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000B2CC File Offset: 0x000094CC
		public static List<c00005d.c000061> m000055()
		{
			List<c00005d.c000061> list = new List<c00005d.c000061>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.m00003a())
			{
				list.Add(keyValuePair.Value.Room);
			}
			return list;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000B330 File Offset: 0x00009530
		public static List<c00005d.c000061> m000056(string p0)
		{
			string[] array = p0.Split(new char[]
			{
				' '
			});
			List<c00005d.c000061> list = new List<c00005d.c000061>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.m00003b())
			{
				c00005d.c000060 value = keyValuePair.Value;
				bool flag = true;
				foreach (string text in array)
				{
					if (flag)
					{
						if (text.StartsWith("#"))
						{
							bool flag2 = false;
							foreach (c00005d.c000063 c in value.Tags)
							{
								if ("#" + c.Tag.ToLower() == text.ToLower())
								{
									flag2 = true;
								}
							}
							if (!flag2)
							{
								flag = false;
							}
						}
						else if (!value.Room.Name.ToLower().Contains(text.ToLower()))
						{
							flag = false;
						}
					}
				}
				if (flag)
				{
					list.Add(value.Room);
				}
			}
			return list;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B488 File Offset: 0x00009688
		public static c00005d.c000060 m000057(ulong p0)
		{
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000024)
			{
				if (keyValuePair.Value.Room.RoomId == p0)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B4F8 File Offset: 0x000096F8
		public static c000099.c00009b m00000a(string p0)
		{
			c000099.c00009b c00009b = new c000099.c00009b();
			c000099.c00009a c00009a = JsonConvert.DeserializeObject<c000099.c00009a>(p0);
			c00005d.c000060 c = c000099.m000057(c00009a.RoomId);
			if (c == null)
			{
				c00009b.Result = (c000099.enum09d)2;
				c00009b.RoomDetails = new c00005d.c000060();
			}
			else
			{
				c00009b.Result = (c000099.enum09d)0;
				c00009b.RoomDetails = c;
				c00009b.RoomDetails.Room.Name = c00009a.Name;
				ulong roomId = (ulong)((long)new Random().Next(100, 9999999));
				c00009b.RoomDetails.Room.RoomId = roomId;
				c00009b.RoomDetails.Room.IsAGRoom = false;
				c00009b.RoomDetails.Scenes[0].IsSandbox = true;
				c00009b.RoomDetails.Scenes[0].RoomId = roomId;
				c00009b.RoomDetails.Scenes[0].DataBlobName = string.Empty;
				c00009b.RoomDetails.Scenes[0].DataModifiedAt = DateTime.Now;
				c00009b.RoomDetails.Room.CreatorPlayerId = server.APIServer.CachedPlayerID;
			}
			c00005d.m00003a().Add(c00009a.Name, c);
			string text = c000004.m000007() + c00009b.RoomDetails.Room.Name;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text + "\\RoomDetails.json", JsonConvert.SerializeObject(c00009b.RoomDetails));
			return c00009b;
		}

		// Token: 0x0200009A RID: 154
		public sealed class c00009a
		{
			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0000373A File Offset: 0x0000193A
			// (set) Token: 0x06000361 RID: 865 RVA: 0x00003742 File Offset: 0x00001942
			public string Name
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

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000374B File Offset: 0x0000194B
			// (set) Token: 0x06000363 RID: 867 RVA: 0x00003753 File Offset: 0x00001953
			public ulong RoomId
			{
				[CompilerGenerated]
				get
				{
					return this.f000023;
				}
				[CompilerGenerated]
				set
				{
					this.f000023 = value;
				}
			}

			// Token: 0x040001DD RID: 477
			private string f00000a;

			// Token: 0x040001DE RID: 478
			private ulong f000023;
		}

		// Token: 0x0200009B RID: 155
		public sealed class c00009b
		{
			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000365 RID: 869 RVA: 0x0000375C File Offset: 0x0000195C
			// (set) Token: 0x06000366 RID: 870 RVA: 0x00003764 File Offset: 0x00001964
			public c000099.enum09d Result
			{
				[CompilerGenerated]
				get
				{
					return this.f000042;
				}
				[CompilerGenerated]
				set
				{
					this.f000042 = value;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000367 RID: 871 RVA: 0x0000376D File Offset: 0x0000196D
			// (set) Token: 0x06000368 RID: 872 RVA: 0x00003775 File Offset: 0x00001975
			public c00005d.c000060 RoomDetails
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

			// Token: 0x040001DF RID: 479
			private c000099.enum09d f000042;

			// Token: 0x040001E0 RID: 480
			private c00005d.c000060 f00004f;
		}

		// Token: 0x0200009C RID: 156
		public sealed class c00009c
		{
			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000377E File Offset: 0x0000197E
			// (set) Token: 0x0600036B RID: 875 RVA: 0x00003786 File Offset: 0x00001986
			public string Name
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

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000378F File Offset: 0x0000198F
			// (set) Token: 0x0600036D RID: 877 RVA: 0x00003797 File Offset: 0x00001997
			public List<c00005d.c000062> FeaturedRooms
			{
				[CompilerGenerated]
				get
				{
					return this.f000031;
				}
				[CompilerGenerated]
				set
				{
					this.f000031 = value;
				}
			}

			// Token: 0x040001E1 RID: 481
			private string f00000a;

			// Token: 0x040001E2 RID: 482
			private List<c00005d.c000062> f000031;
		}

		// Token: 0x0200009D RID: 157
		public enum enum09d
		{

		}
	}
}