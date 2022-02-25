using System;
using System.Collections.Generic;

namespace rooms2018
{
	// Token: 0x0200002B RID: 43
	internal class RoomsList
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000053F8 File Offset: 0x000035F8
		public static RoomsList.FeaturedRoomData getFeaturedRooms
		{
			get
			{
				List<Rooms.RoomPlayPage> list = new List<Rooms.RoomPlayPage>();
				foreach (KeyValuePair<string, Rooms.RoomDetail> keyValuePair in Rooms.RecRoomOriginalRooms)
				{
					Rooms.RoomPlayPage item = new Rooms.RoomPlayPage
					{
						RoomName = keyValuePair.Value.Room.Name,
						RoomId = keyValuePair.Value.Room.RoomId,
						ImageName = "93a53ced93a04f658795a87f4a4aab85"
					};
					list.Add(item);
				}
				return new RoomsList.FeaturedRoomData
				{
					Name = "Rec Room Originals",
					FeaturedRooms = list
				};
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000054BC File Offset: 0x000036BC
		public static List<Rooms.cRoom> HotRooms
		{
			get
			{
				List<Rooms.cRoom> list = new List<Rooms.cRoom>();
				foreach (KeyValuePair<string, Rooms.RoomDetail> keyValuePair in Rooms.RecRoomOriginalRooms)
				{
					list.Add(keyValuePair.Value.Room);
				}
				return list;
			}
		}

		// Token: 0x0200002C RID: 44
		public class FeaturedRoomData
		{
			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00002762 File Offset: 0x00000962
			// (set) Token: 0x060000FC RID: 252 RVA: 0x0000276A File Offset: 0x0000096A
			public string Name { get; set; }

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060000FD RID: 253 RVA: 0x00002773 File Offset: 0x00000973
			// (set) Token: 0x060000FE RID: 254 RVA: 0x0000277B File Offset: 0x0000097B
			public List<Rooms.RoomPlayPage> FeaturedRooms { get; set; }
		}
	}
}
