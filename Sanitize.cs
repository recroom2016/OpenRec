using System;
using Newtonsoft.Json;

namespace api
{
	// Token: 0x02000081 RID: 129
	public class Sanitize
	{
		public static Sanitize.m001 GetSanitize()
        {
			return new m001
			{
				IsPure = true
			};
        }
		
		public sealed class m001
        {
			public bool IsPure { get; set; }
		}
		
	}
}
