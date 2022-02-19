using System;
using System.Collections.Generic;

namespace storefront2018
{
	// Token: 0x0200003E RID: 62
	internal class StoreFronts
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00005ACC File Offset: 0x00003CCC
		public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
		{
			int num = (day - start.DayOfWeek + 7) % 7;
			return start.AddDays((double)num);
		}

		// Token: 0x0200003F RID: 63
		public enum GiftContext
		{
			// Token: 0x040000F1 RID: 241
			None = -1,
			// Token: 0x040000F2 RID: 242
			Default,
			// Token: 0x040000F3 RID: 243
			First_Activity,
			// Token: 0x040000F4 RID: 244
			Game_Drop,
			// Token: 0x040000F5 RID: 245
			All_Daily_Challenges_Complete,
			// Token: 0x040000F6 RID: 246
			All_Weekly_Challenge_Complete,
			// Token: 0x040000F7 RID: 247
			Daily_Challenge_Complete,
			// Token: 0x040000F8 RID: 248
			Weekly_Challenge_Complete,
			// Token: 0x040000F9 RID: 249
			Unassigned_Equipment = 10,
			// Token: 0x040000FA RID: 250
			Unassigned_Avatar,
			// Token: 0x040000FB RID: 251
			Unassigned_Consumable,
			// Token: 0x040000FC RID: 252
			Reacquisition = 20,
			// Token: 0x040000FD RID: 253
			Membership,
			// Token: 0x040000FE RID: 254
			NUX_TokensAndDressUp = 30,
			// Token: 0x040000FF RID: 255
			NUX_Experiment1,
			// Token: 0x04000100 RID: 256
			NUX_Experiment2,
			// Token: 0x04000101 RID: 257
			NUX_Experiment3,
			// Token: 0x04000102 RID: 258
			NUX_Experiment4,
			// Token: 0x04000103 RID: 259
			NUX_Experiment5,
			// Token: 0x04000104 RID: 260
			LevelUp = 100,
			// Token: 0x04000105 RID: 261
			LevelUp_2 = 102,
			// Token: 0x04000106 RID: 262
			LevelUp_3,
			// Token: 0x04000107 RID: 263
			LevelUp_4,
			// Token: 0x04000108 RID: 264
			LevelUp_5,
			// Token: 0x04000109 RID: 265
			LevelUp_6,
			// Token: 0x0400010A RID: 266
			LevelUp_7,
			// Token: 0x0400010B RID: 267
			LevelUp_8,
			// Token: 0x0400010C RID: 268
			LevelUp_9,
			// Token: 0x0400010D RID: 269
			LevelUp_10,
			// Token: 0x0400010E RID: 270
			LevelUp_11,
			// Token: 0x0400010F RID: 271
			LevelUp_12,
			// Token: 0x04000110 RID: 272
			LevelUp_13,
			// Token: 0x04000111 RID: 273
			LevelUp_14,
			// Token: 0x04000112 RID: 274
			LevelUp_15,
			// Token: 0x04000113 RID: 275
			LevelUp_16,
			// Token: 0x04000114 RID: 276
			LevelUp_17,
			// Token: 0x04000115 RID: 277
			LevelUp_18,
			// Token: 0x04000116 RID: 278
			LevelUp_19,
			// Token: 0x04000117 RID: 279
			LevelUp_20,
			// Token: 0x04000118 RID: 280
			LevelUp_21,
			// Token: 0x04000119 RID: 281
			LevelUp_22,
			// Token: 0x0400011A RID: 282
			LevelUp_23,
			// Token: 0x0400011B RID: 283
			LevelUp_24,
			// Token: 0x0400011C RID: 284
			LevelUp_25,
			// Token: 0x0400011D RID: 285
			LevelUp_26,
			// Token: 0x0400011E RID: 286
			LevelUp_27,
			// Token: 0x0400011F RID: 287
			LevelUp_28,
			// Token: 0x04000120 RID: 288
			LevelUp_29,
			// Token: 0x04000121 RID: 289
			LevelUp_30,
			// Token: 0x04000122 RID: 290
			Event_RawData = 1000,
			// Token: 0x04000123 RID: 291
			SFVRCC_Promo,
			// Token: 0x04000124 RID: 292
			HelixxVR_Promo,
			// Token: 0x04000125 RID: 293
			Paintball_ClearCut = 2000,
			// Token: 0x04000126 RID: 294
			Paintball_Homestead,
			// Token: 0x04000127 RID: 295
			Paintball_Quarry,
			// Token: 0x04000128 RID: 296
			Paintball_River,
			// Token: 0x04000129 RID: 297
			Paintball_Dam,
			// Token: 0x0400012A RID: 298
			Discgolf_Propulsion = 3000,
			// Token: 0x0400012B RID: 299
			Discgolf_Lake,
			// Token: 0x0400012C RID: 300
			Discgolf_Mode_CoopCatch = 3500,
			// Token: 0x0400012D RID: 301
			Quest_Goblin_A = 4000,
			// Token: 0x0400012E RID: 302
			Quest_Goblin_B,
			// Token: 0x0400012F RID: 303
			Quest_Goblin_C,
			// Token: 0x04000130 RID: 304
			Quest_Goblin_S,
			// Token: 0x04000131 RID: 305
			Quest_Goblin_Consumable,
			// Token: 0x04000132 RID: 306
			Quest_Cauldron_A = 4010,
			// Token: 0x04000133 RID: 307
			Quest_Cauldron_B,
			// Token: 0x04000134 RID: 308
			Quest_Cauldron_C,
			// Token: 0x04000135 RID: 309
			Quest_Cauldron_S,
			// Token: 0x04000136 RID: 310
			Quest_Cauldron_Consumable,
			// Token: 0x04000137 RID: 311
			Quest_Pirate1_A = 4100,
			// Token: 0x04000138 RID: 312
			Quest_Pirate1_B,
			// Token: 0x04000139 RID: 313
			Quest_Pirate1_C,
			// Token: 0x0400013A RID: 314
			Quest_Pirate1_S,
			// Token: 0x0400013B RID: 315
			Quest_Pirate1_X,
			// Token: 0x0400013C RID: 316
			Quest_Pirate1_Consumable,
			// Token: 0x0400013D RID: 317
			Quest_SciFi_A = 4500,
			// Token: 0x0400013E RID: 318
			Quest_SciFi_B,
			// Token: 0x0400013F RID: 319
			Quest_SciFi_C,
			// Token: 0x04000140 RID: 320
			Quest_SciFi_S,
			// Token: 0x04000141 RID: 321
			Quest_scifi_Consumable,
			// Token: 0x04000142 RID: 322
			Charades = 5000,
			// Token: 0x04000143 RID: 323
			Soccer = 6000,
			// Token: 0x04000144 RID: 324
			Paddleball = 7000,
			// Token: 0x04000145 RID: 325
			Dodgeball = 8000,
			// Token: 0x04000146 RID: 326
			Lasertag = 9000,
			// Token: 0x04000147 RID: 327
			Store_LaserTag = 100000,
			// Token: 0x04000148 RID: 328
			Store_RecCenter = 100010,
			// Token: 0x04000149 RID: 329
			Consumable = 110000,
			// Token: 0x0400014A RID: 330
			Token = 110100,
			// Token: 0x0400014B RID: 331
			Punchcard_Challenge_Complete = 110200,
			// Token: 0x0400014C RID: 332
			All_Punchcard_Challenges_Complete
		}

		// Token: 0x02000040 RID: 64
		public enum GiftTypes
		{
			// Token: 0x0400014E RID: 334
			GiftDrop,
			// Token: 0x0400014F RID: 335
			SeasonTier,
			// Token: 0x04000150 RID: 336
			SeasonEliteUpgrade
		}

		// Token: 0x02000041 RID: 65
		public enum CurrencyTypes
		{
			// Token: 0x04000152 RID: 338
			Invalid,
			// Token: 0x04000153 RID: 339
			LaserTagTickets,
			// Token: 0x04000154 RID: 340
			RecCenterTokens,
			// Token: 0x04000155 RID: 341
			LostSkullsGold = 100,
			// Token: 0x04000156 RID: 342
			RecRoyale_Season1 = 200
		}

		// Token: 0x02000042 RID: 66
		public enum StoreFrontTypes
		{
			// Token: 0x04000158 RID: 344
			None,
			// Token: 0x04000159 RID: 345
			LaserTag,
			// Token: 0x0400015A RID: 346
			RecCenter,
			// Token: 0x0400015B RID: 347
			Watch,
			// Token: 0x0400015C RID: 348
			Quest_LostSkulls = 100,
			// Token: 0x0400015D RID: 349
			RecRoyale = 200
		}

		// Token: 0x02000043 RID: 67
		public enum ItemRarity
		{
			// Token: 0x0400015F RID: 351
			None = -1,
			// Token: 0x04000160 RID: 352
			Common,
			// Token: 0x04000161 RID: 353
			Uncommon = 10,
			// Token: 0x04000162 RID: 354
			Rare = 20,
			// Token: 0x04000163 RID: 355
			Epic = 30,
			// Token: 0x04000164 RID: 356
			Legendary = 50
		}

		// Token: 0x02000044 RID: 68
		public class AllGiftDrop
		{
		}

		// Token: 0x02000045 RID: 69
		public class GiftDropStore
		{
			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002D01 File Offset: 0x00000F01
			// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002D09 File Offset: 0x00000F09
			public int StorefrontType { get; set; }

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060001CA RID: 458 RVA: 0x00002D12 File Offset: 0x00000F12
			// (set) Token: 0x060001CB RID: 459 RVA: 0x00002D1A File Offset: 0x00000F1A
			public DateTime NextUpdate { get; set; }

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00002D23 File Offset: 0x00000F23
			// (set) Token: 0x060001CD RID: 461 RVA: 0x00002D2B File Offset: 0x00000F2B
			public List<StoreFronts.StoreItem> StoreItems { get; set; }

			// Token: 0x060001CE RID: 462 RVA: 0x00005AF8 File Offset: 0x00003CF8
			public GiftDropStore()
			{
				this.StorefrontType = 2;
				this.NextUpdate = StoreFronts.GetNextWeekday(DateTime.Now, DayOfWeek.Wednesday);
				this.StoreItems = new List<StoreFronts.StoreItem>
				{
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 0,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 30000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 0,
								FriendlyName = "Saija Helmet",
								Tooltip = "",
								AvatarItemDesc = "274cb9b2-2f59-47ea-9a8d-a5b656d148c6,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 1,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 35000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 1,
								FriendlyName = "Saija Shirt",
								Tooltip = "",
								AvatarItemDesc = "2c679f89-c76e-4cfb-94e9-448c8fd44d55,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 2,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 10000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 2,
								FriendlyName = "Saija Gloves",
								Tooltip = "",
								AvatarItemDesc = "50c9c6f8-2963-4ef3-95d5-e999a898269f,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 0,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 15000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 0,
								FriendlyName = "Bishop Hair",
								Tooltip = "",
								AvatarItemDesc = "b861e5f3-fc6d-43b3-9861-c1b45cb493a8,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 4,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 20000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 4,
								FriendlyName = "Bishop Shirt",
								Tooltip = "",
								AvatarItemDesc = "6930ce13-4be4-4ab9-9817-667bd261ffc3,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 5,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 20000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 5,
								FriendlyName = "Bishop Gloves",
								Tooltip = "",
								AvatarItemDesc = "abc25091-ed5f-4c72-9364-fffeef1bc239,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 0,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 30000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 0,
								FriendlyName = "Saija Helmet",
								Tooltip = "",
								AvatarItemDesc = "274cb9b2-2f59-47ea-9a8d-a5b656d148c6,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 1,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 35000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 1,
								FriendlyName = "Saija Shirt",
								Tooltip = "",
								AvatarItemDesc = "2c679f89-c76e-4cfb-94e9-448c8fd44d55,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 2,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 10000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 2,
								FriendlyName = "Saija Gloves",
								Tooltip = "",
								AvatarItemDesc = "50c9c6f8-2963-4ef3-95d5-e999a898269f,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 0,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 15000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 0,
								FriendlyName = "Bishop Hair",
								Tooltip = "",
								AvatarItemDesc = "b861e5f3-fc6d-43b3-9861-c1b45cb493a8,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 4,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 20000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 4,
								FriendlyName = "Bishop Shirt",
								Tooltip = "",
								AvatarItemDesc = "6930ce13-4be4-4ab9-9817-667bd261ffc3,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					},
					new StoreFronts.StoreItem
					{
						PurchasableItemId = 5,
						Type = 0,
						IsFeatured = false,
						Prices = new List<StoreFronts.ItemPrice>
						{
							new StoreFronts.ItemPrice
							{
								CurrencyType = 2,
								Price = 20000
							}
						},
						GiftDrops = new List<StoreFronts.GiftDrop>
						{
							new StoreFronts.GiftDrop
							{
								GiftDropId = 5,
								FriendlyName = "Bishop Gloves",
								Tooltip = "",
								AvatarItemDesc = "abc25091-ed5f-4c72-9364-fffeef1bc239,,,",
								ConsumableItemDesc = "",
								EquipmentPrefabName = "",
								EquipmentModificationGuid = "",
								Rarity = 50,
								IsQuery = false,
								Unique = false,
								Level = 50,
								Context = 100010
							}
						}
					}
				};
			}
		}

		// Token: 0x02000046 RID: 70
		public class StoreItem
		{
			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00002D34 File Offset: 0x00000F34
			// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D3C File Offset: 0x00000F3C
			public int PurchasableItemId { get; set; }

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002D45 File Offset: 0x00000F45
			// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D4D File Offset: 0x00000F4D
			public int Type { get; set; }

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002D56 File Offset: 0x00000F56
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D5E File Offset: 0x00000F5E
			public bool IsFeatured { get; set; }

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002D67 File Offset: 0x00000F67
			// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002D6F File Offset: 0x00000F6F
			public List<StoreFronts.ItemPrice> Prices { get; set; }

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002D78 File Offset: 0x00000F78
			// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D80 File Offset: 0x00000F80
			public List<StoreFronts.GiftDrop> GiftDrops { get; set; }
		}

		// Token: 0x02000047 RID: 71
		public class GiftDrop
		{
			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00002D89 File Offset: 0x00000F89
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002D91 File Offset: 0x00000F91
			public int GiftDropId { get; set; }

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00002D9A File Offset: 0x00000F9A
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00002DA2 File Offset: 0x00000FA2
			public string FriendlyName { get; set; }

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00002DAB File Offset: 0x00000FAB
			// (set) Token: 0x060001DF RID: 479 RVA: 0x00002DB3 File Offset: 0x00000FB3
			public string Tooltip { get; set; }

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002DBC File Offset: 0x00000FBC
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002DC4 File Offset: 0x00000FC4
			public string AvatarItemDesc { get; set; }

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002DCD File Offset: 0x00000FCD
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002DD5 File Offset: 0x00000FD5
			public string ConsumableItemDesc { get; set; }

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002DDE File Offset: 0x00000FDE
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002DE6 File Offset: 0x00000FE6
			public string EquipmentPrefabName { get; set; }

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002DEF File Offset: 0x00000FEF
			// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002DF7 File Offset: 0x00000FF7
			public string EquipmentModificationGuid { get; set; }

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002E00 File Offset: 0x00001000
			// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002E08 File Offset: 0x00001008
			public int Rarity { get; set; }

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060001EA RID: 490 RVA: 0x00002E11 File Offset: 0x00001011
			// (set) Token: 0x060001EB RID: 491 RVA: 0x00002E19 File Offset: 0x00001019
			public bool IsQuery { get; set; }

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060001EC RID: 492 RVA: 0x00002E22 File Offset: 0x00001022
			// (set) Token: 0x060001ED RID: 493 RVA: 0x00002E2A File Offset: 0x0000102A
			public bool Unique { get; set; }

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060001EE RID: 494 RVA: 0x00002E33 File Offset: 0x00001033
			// (set) Token: 0x060001EF RID: 495 RVA: 0x00002E3B File Offset: 0x0000103B
			public int Level { get; set; }

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002E44 File Offset: 0x00001044
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002E4C File Offset: 0x0000104C
			public int Context { get; set; }
		}

		// Token: 0x02000048 RID: 72
		public class ItemPrice
		{
			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002E55 File Offset: 0x00001055
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002E5D File Offset: 0x0000105D
			public int CurrencyType { get; set; }

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002E66 File Offset: 0x00001066
			// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002E6E File Offset: 0x0000106E
			public int Price { get; set; }
		}
	}
}
