using System;
using System.Collections.Generic;

namespace api2018
{
	// Token: 0x0200002F RID: 47
	public class Objective2018
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000284A File Offset: 0x00000A4A
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002852 File Offset: 0x00000A52
		public List<Objective2018Entry> Objectives { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000285B File Offset: 0x00000A5B
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002863 File Offset: 0x00000A63
		public List<Objective2018Group> ObjectiveGroups { get; set; }

		// Token: 0x06000122 RID: 290 RVA: 0x00004FF0 File Offset: 0x000031F0
		public Objective2018()
		{
			this.Objectives = new List<Objective2018Entry>
			{
				new Objective2018Entry
				{
					Index = 2,
					Group = 0,
					Progress = 0f,
					VisualProgress = 0f,
					IsCompleted = false,
					IsRewarded = false
				},
				new Objective2018Entry
				{
					Index = 1,
					Group = 0,
					Progress = 0f,
					VisualProgress = 0f,
					IsCompleted = false,
					IsRewarded = false
				},
				new Objective2018Entry
				{
					Index = 0,
					Group = 0,
					Progress = 0f,
					VisualProgress = 0f,
					IsCompleted = false,
					IsRewarded = false
				}
			};
			this.ObjectiveGroups = new List<Objective2018Group>
			{
				new Objective2018Group
				{
					Group = 0,
					IsCompleted = false,
					ClearedAt = "2021-04-18T01:59:14.8642558Z"
				}
			};
		}
	}
}
