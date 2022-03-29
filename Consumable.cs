using System;
using System.Collections.Generic;
using System.Text;

namespace api
{
    class Consumable
    {
		
		// Token: 0x040001E4 RID: 484
		public static List<Consumable.c00009f> f000026;

		// Token: 0x0200009F RID: 159
		public class c00009f
		{
			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000376 RID: 886
			// (set) Token: 0x06000377 RID: 887
			public long Id
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

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000378 RID: 888
			// (set) Token: 0x06000379 RID: 889
			public string ConsumableItemDesc
			{
				
				get
				{
					return this.f000002;
				}
				
				set
				{
					this.f000002 = value;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600037A RID: 890
			// (set) Token: 0x0600037B RID: 891
			public DateTime CreatedAt
			{
				
				get
				{
					return this.f00003a;
				}
				
				set
				{
					this.f00003a = value;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600037C RID: 892
			// (set) Token: 0x0600037D RID: 893
			public int Count
			{
				
				get
				{
					return this.f000004;
				}
				
				set
				{
					this.f000004 = value;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x0600037E RID: 894
			// (set) Token: 0x0600037F RID: 895
			public int InitialCount
			{
			
				get
				{
					return this.f000005;
				}
				
				set
				{
					this.f000005 = value;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000380 RID: 896
			// (set) Token: 0x06000381 RID: 897
			public int UnlockedLevel
			{
				
				get
				{
					return this.f000006;
				}
				
				set
				{
					this.f000006 = value;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000382 RID: 898
			// (set) Token: 0x06000383 RID: 899
			public bool IsActive
			{
				
				get
				{
					return this.f000016;
				}
				
				set
				{
					this.f000016 = value;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000384 RID: 900
			// (set) Token: 0x06000385 RID: 901
			public int? ActiveDurationMinutes
			{
				
				get
				{
					return this.f000081;
				}
				
				set
				{
					this.f000081 = value;
				}
			}

			// Token: 0x040001E6 RID: 486
			private long f00002c;

			// Token: 0x040001E7 RID: 487
			private string f000002;

			// Token: 0x040001E8 RID: 488
			private DateTime f00003a;

			// Token: 0x040001E9 RID: 489
			private int f000004;

			// Token: 0x040001EA RID: 490
			private int f000005;

			// Token: 0x040001EB RID: 491
			private int f000006;

			// Token: 0x040001EC RID: 492
			private bool f000016;

			// Token: 0x040001ED RID: 493
			private int? f000081;
		}
	}
}
