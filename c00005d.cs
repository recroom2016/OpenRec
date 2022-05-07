using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using server;

namespace vaultgamesesh
{
	// Token: 0x02000008 RID: 8
	internal sealed class c00005d
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002B94 File Offset: 0x00000D94
		public static Dictionary<string, c00005d.c000060> m00003a()
		{
			Dictionary<string, c00005d.c000060> dictionary = new Dictionary<string, c00005d.c000060>();
			string[] directories = Directory.GetDirectories(c000004.m000007());
			for (int i = 0; i < directories.Length; i++)
			{
				c00005d.c000060 c = JsonConvert.DeserializeObject<c00005d.c000060>(File.ReadAllText(directories[i] + "\\RoomDetails.json"));
				dictionary.Add(c.Room.Name, c);
			}
			return dictionary;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002BFC File Offset: 0x00000DFC
		public static List<c00005d.c000061> m000035()
		{
			List<c00005d.c000061> list = new List<c00005d.c000061>();
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000024)
			{
				list.Add(keyValuePair.Value.Room);
			}
			return list;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C6C File Offset: 0x00000E6C
		public static Dictionary<string, c00005d.c000060> m00003b()
		{
			Dictionary<string, c00005d.c000060> result;
			try
			{
				try
				{
					result = JsonConvert.DeserializeObject<Dictionary<string, c00005d.c000060>>(File.ReadAllText("GamesessionsV3Data.json"));
				}
				finally
				{
				}
			}
			catch
			{
				result = c00005d.f000050;
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public static c00005d.c000060 m000023(int p0)
		{
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000050)
			{
				bool flag = keyValuePair.Value.Room.RoomId == (ulong)((long)p0);
				bool flag2 = flag;
				if (flag2)
				{
					return keyValuePair.Value;
				}
			}
			return c00005d.f000050["DormRoom"];
		}

		// Token: 0x04000008 RID: 8
		public static Dictionary<string, c00005d.c000060> f000024 = new Dictionary<string, c00005d.c000060>
		{
			{
				"MakerRoom",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 24UL,
						Name = "MakerRoom",
						Description = "This room is a blank canvas. Make it into whatever you like!",
						CreatorPlayerId = 1UL,
						ImageName = string.Empty,
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 24UL,
							RoomSceneLocationId = "a75f7547-79eb-47c6-8986-6767abcb4f92",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Park",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 25UL,
						Name = "Park",
						Description = "A sprawling park with amphitheater, play fields, and a cave.",
						CreatorPlayerId = 782441001UL,
						ImageName = string.Empty,
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 25UL,
							RoomSceneLocationId = "0a864c86-5a71-4e18-8041-8124e4dc9d98",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Lounge",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 22UL,
						Name = "Lounge",
						Description = "A low-key lounge to chill with your friends. Great for private parties!",
						CreatorPlayerId = 782441001UL,
						ImageName = string.Empty,
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 22UL,
							RoomSceneLocationId = "a067557f-ca32-43e6-b6e5-daaec60b4f5a",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "recroomoriginal",
							Type = 2
						}
					}
				}
			},
			{
				"PerformanceHall",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 23UL,
						Name = "PerformanceHall",
						Description = "A theater for plays, music, comedy and other performances.",
						CreatorPlayerId = 1UL,
						ImageName = string.Empty,
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 23UL,
							RoomSceneLocationId = "9932f88f-3929-43a0-a012-a40b5128e346",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Hangar",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 18UL,
						Name = "Hangar",
						Description = "Teams battle each other and waves of robots.",
						CreatorPlayerId = 782441001UL,
						ImageName = "ActivityLaserTag.png",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 18UL,
							RoomSceneLocationId = "239e676c-f12f-489f-bf3a-d4c383d692c3",
							Name = "Hangar",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "pvp",
							Type = 0
						}
					}
				}
			}
		};

		// Token: 0x04000009 RID: 9
		public static Dictionary<string, c00005d.c000060> f000050 = new Dictionary<string, c00005d.c000060>
		{
			{
				"DormRoom",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 1UL,
						Name = "DormRoom",
						Description = "A private room.",
						ReleaseStatus = 2,
						ReplicationId = "DormRoom",
						CreatorPlayerId = APIServer.CachedPlayerID,
						ImageName = "DefaultRoomImage.jpg",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 0UL,
							RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
							Name = "dormroom2",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now,
							ReplicationId = "your mom still gae",
							SupportsJoinInProgress = true,
							ReleaseStatus = 2,
							UseAgeBasedMatchmaking = true,
							UseLevelBasedMatchmaking = true,
							UseRecRoyaleMatchmaking = false
						}
					},
					CoOwners = new List<int>(),
					InvitedCoOwners = new List<int>(),
					Hosts = new List<int>(),
					InvitedHosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"RecCenter",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 2UL,
						Name = "RecCenter",
						Description = "A social hub to meet and mingle with friends new and old.",
						CreatorPlayerId = APIServer.CachedPlayerID,
						ImageName = "22eefa3219f046fd9e2090814650ede3",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 2UL,
							RoomSceneLocationId = "cbad71af-0831-44d8-b8ef-69edafa841f6",
							Name = "reccenter",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(1)
					{
						126231667
					},
					Hosts = new List<int>(1)
					{
						126231667
					},
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"3DCharades",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 3UL,
						Name = "3DCharades",
						Description = "Take turns drawing, acting, and guessing funny phrases with your friends!",
						CreatorPlayerId = 782441001UL,
						ImageName = "a446d5808ed14401a27f53e631c31b93.png",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 3L,
							RoomId = 4UL,
							RoomSceneLocationId = "4078dfed-24bb-4db7-863f-578ba48d726b",
							Name = "charades",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"DiscGolfLake",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 4UL,
						Name = "DiscGolfLake",
						Description = "Throw your disc into the goal. Sounds easy, right?",
						CreatorPlayerId = 782441001UL,
						ImageName = "52cf6c3271894ecd95fb0c9b2d2209a7",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 4UL,
							RoomSceneLocationId = "f6f7256c-e438-4299-b99e-d20bef8cf7e0",
							Name = "Lake",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 4,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				"DiscGolfPropulsion",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 5UL,
						Name = "DiscGolfPropulsion",
						Description = "Throw your disc through hazards and around wind machines on this challenging course!",
						CreatorPlayerId = 782441001UL,
						ImageName = "fc9a1acc47514b64a30d199d5ccdeca9",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 5UL,
							RoomSceneLocationId = "d9378c9f-80bc-46fb-ad1e-1bed8a674f55",
							Name = "Propulsion",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				"Dodgeball",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 6UL,
						Name = "Dodgeball",
						Description = "Throw dodgeballs to knock out your friends in this gym classic!",
						CreatorPlayerId = 782441001UL,
						ImageName = "6d5c494668784816bbc41d9b870e5003",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 6UL,
							RoomSceneLocationId = "3d474b26-26f7-45e9-9a36-9b02847d5e6f",
							Name = "dodgeball",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				"Paddleball",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 7UL,
						Name = "Paddleball",
						Description = "A simple rally game between two players in a plexiglass tube with a zero-g ball.",
						CreatorPlayerId = 782441001UL,
						ImageName = "ffdca6ed8bd94631ac15e3e894acb6c6",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 7UL,
							RoomSceneLocationId = "d89f74fa-d51e-477a-a425-025a891dd499",
							Name = "paddleball",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				"Paintball",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 8UL,
						Name = "Paintball",
						Description = "Red and Blue teams splat each other in capture the flag and team battle.",
						CreatorPlayerId = 782441001UL,
						ImageName = "93a53ced93a04f658795a87f4a4aab85",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = true,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 8UL,
							RoomSceneLocationId = "e122fe98-e7db-49e8-a1b1-105424b6e1f0",
							Name = "River",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new c00005d.c00005f
						{
							RoomSceneId = 2L,
							RoomId = 9UL,
							RoomSceneLocationId = "a785267d-c579-42ea-be43-fec1992d1ca7",
							Name = "Homestead",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new c00005d.c00005f
						{
							RoomSceneId = 3L,
							RoomId = 10UL,
							RoomSceneLocationId = "ff4c6427-7079-4f59-b22a-69b089420827",
							Name = "Quarry",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new c00005d.c00005f
						{
							RoomSceneId = 4L,
							RoomId = 11UL,
							RoomSceneLocationId = "380d18b5-de9c-49f3-80f7-f4a95c1de161",
							Name = "Clearcut",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new c00005d.c00005f
						{
							RoomSceneId = 5L,
							RoomId = 12UL,
							RoomSceneLocationId = "58763055-2dfb-4814-80b8-16fac5c85709",
							Name = "Spillway",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "pvp",
							Type = 0
						}
					}
				}
			},
			{
				"GoldenTrophy",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 13UL,
						Name = "GoldenTrophy",
						Description = "The goblin king stole Coach's Golden Trophy. Team up and embark on an epic quest to recover it!",
						CreatorPlayerId = 782441001UL,
						ImageName = "38e9d0d4eff94556a0b106508249dcf9",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 13UL,
							RoomSceneLocationId = "91e16e35-f48f-4700-ab8a-a1b79e50e51b",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "quest",
							Type = 0
						}
					}
				}
			},
			{
				"TheRiseofJumbotron",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 14UL,
						Name = "TheRiseofJumbotron",
						Description = "Robot invaders threaten the galaxy! Team up with your friends and bring the laser heat!",
						CreatorPlayerId = 782441001UL,
						ImageName = "51296f28105b48178708e389b6daf057",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 14UL,
							RoomSceneLocationId = "acc06e66-c2d0-4361-b0cd-46246a4c455c",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "quest",
							Type = 0
						}
					}
				}
			},
			{
				"CrimsonCauldron",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 15UL,
						Name = "CrimsonCauldron",
						Description = "Can your band of adventurers brave the enchanted wilds, and lift the curse of the crimson cauldron?",
						CreatorPlayerId = 782441001UL,
						ImageName = "3ab82779dff94d11920ebf38df249395",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 15UL,
							RoomSceneLocationId = "949fa41f-4347-45c0-b7ac-489129174045",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "quest",
							Type = 0
						}
					}
				}
			},
			{
				"IsleOfLostSkulls",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 16UL,
						Name = "IsleOfLostSkulls",
						Description = "Can your pirate crew get to the Isle, defeat its fearsome guardian, and escape with the gold?",
						CreatorPlayerId = 782441001UL,
						ImageName = "45ad53aa002646d0ab3eb509b9f260ef",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 16UL,
							RoomSceneLocationId = "7e01cfe0-820a-406f-b1b3-0a5bf575235c",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "quest",
							Type = 0
						}
					}
				}
			},
			{
				"Soccer",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 17UL,
						Name = "Soccer",
						Description = "Teams of three run around slamming themselves into an over-sized soccer ball. Goal!",
						CreatorPlayerId = 782441001UL,
						ImageName = "51c6f5ac5e6f4777b573e7e43f8a85ea",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 17UL,
							RoomSceneLocationId = "6d5eea4b-f069-4ed0-9916-0e2f07df0d03",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				"LaserTag",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 18UL,
						Name = "LaserTag",
						Description = "Teams battle each other and waves of robots.",
						CreatorPlayerId = 782441001UL,
						ImageName = "c5a72193d6904811b2d0195a6deb3125",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 18UL,
							RoomSceneLocationId = "239e676c-f12f-489f-bf3a-d4c383d692c3",
							Name = "Hangar",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new c00005d.c00005f
						{
							RoomSceneId = 2L,
							RoomId = 19UL,
							RoomSceneLocationId = "9d6456ce-6264-48b4-808d-2d96b3d91038",
							Name = "CyberJunkCity",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "pvp",
							Type = 0
						}
					}
				}
			},
			{
				"RecRoyaleSquads",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 20UL,
						Name = "RecRoyaleSquads",
						Description = "Squads of three battle it out on Frontier Island. Last squad standing wins!",
						CreatorPlayerId = APIServer.CachedPlayerID,
						ImageName = "69fc525056014e39a435c4d2fdf2b887",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 0L,
							RoomId = 20UL,
							RoomSceneLocationId = "253fa009-6e65-4c90-91a1-7137a56a267f",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "pvp",
							Type = 0
						}
					}
				}
			},
			{
				"RecRoyaleSolos",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 21UL,
						Name = "RecRoyaleSolos",
						Description = "Battle it out on Frontier Island. Last person standing wins!",
						CreatorPlayerId = APIServer.CachedPlayerID,
						ImageName = "f9e112bb67fb430d979e5ad6c2c116d4",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 0L,
							RoomId = 21UL,
							RoomSceneLocationId = "b010171f-4875-4e89-baba-61e878cd41e1",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "pvp",
							Type = 0
						}
					}
				}
			},
			{
				"Lounge",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 22UL,
						Name = "Lounge",
						Description = "A low-key lounge to chill with your friends. Great for private parties!",
						CreatorPlayerId = APIServer.CachedPlayerID,
						ImageName = "3e8c2458f1e542ab8aa275e4083ee47a",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 0L,
							RoomId = 22UL,
							RoomSceneLocationId = "a067557f-ca32-43e6-b6e5-daaec60b4f5a",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Park",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 25UL,
						Name = "Park",
						Description = "A sprawling park with amphitheater, play fields, and a cave.",
						CreatorPlayerId = 782441001UL,
						ImageName = "79ee7af2532247f397867e48daa9d264.png",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 0L,
							RoomId = 25UL,
							RoomSceneLocationId = "0a864c86-5a71-4e18-8041-8124e4dc9d98",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"QuestForDraucula",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 27UL,
						Name = "QuestForDraucula",
						Description = "Embark on a quest to murder some goblins and skeletons, then jump through an empty doorway to the voidlands in this beta quest!",
						CreatorPlayerId = 782441001UL,
						ImageName = "d0df003353914adfaecdd23f428208b6",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 0L,
							RoomId = 27UL,
							RoomSceneLocationId = "49cb8993-a956-43e2-86f4-1318f279b22a",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Bowling",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 28UL,
						Name = "Bowling",
						Description = "shut up coffeeman this bowling description was so annoying",
						CreatorPlayerId = 782441001UL,
						ImageName = "4d143a3359e8483e8d48116ab6cacecb",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = 28UL,
							RoomSceneLocationId = "ae929543-9a07-41d5-8ee9-dbbee8c36800",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = string.Empty,
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "rro",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "sport",
							Type = 0
						}
					}
				}
			},
			{
				File.ReadAllText("SaveData\\Rooms\\Downloaded\\roomname.txt"),
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = Convert.ToUInt64(File.ReadAllText("SaveData\\Rooms\\Downloaded\\roomid.txt")),
						Name = File.ReadAllText("SaveData\\Rooms\\Downloaded\\roomname.txt"),
						Description = "OpenRec Downloaded Custom Room",
						CreatorPlayerId = Convert.ToUInt64(File.ReadAllText("SaveData\\Profile\\userid.txt")),
						ImageName = File.ReadAllText("SaveData\\Rooms\\Downloaded\\imagename.txt"),
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<c00005d.c00005f>
					{
						new c00005d.c00005f
						{
							RoomSceneId = 1L,
							RoomId = Convert.ToUInt64(File.ReadAllText("SaveData\\Rooms\\Downloaded\\roomid.txt")),
							RoomSceneLocationId = File.ReadAllText("SaveData\\Rooms\\Downloaded\\roomsceneid.txt"),
							Name = "Home",
							IsSandbox = true,
							DataBlobName = File.ReadAllText("SaveData\\Rooms\\Downloaded\\datablob.txt"),
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						}
					},
					CoOwners = new List<int>(),
					Hosts = new List<int>(),
					CheerCount = 1,
					FavoriteCount = 1,
					VisitCount = 1,
					Tags = new List<c00005d.c000063>
					{
						new c00005d.c000063
						{
							Tag = "custom",
							Type = 2
						},
						new c00005d.c000063
						{
							Tag = "",
							Type = 0
						}
					}
				}
			}
		};

		// Token: 0x0200003D RID: 61
		public enum enum05e
		{

		}

		// Token: 0x0200003E RID: 62
		public sealed class c00005f
		{
			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A800 File Offset: 0x00008A00
			// (set) Token: 0x06000188 RID: 392 RVA: 0x0000A818 File Offset: 0x00008A18
			public long RoomSceneId
			{
				[CompilerGenerated]
				get
				{
					return this.f00002c;
				}
				[CompilerGenerated]
				set
				{
					this.f00002c = value;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000189 RID: 393 RVA: 0x0000A824 File Offset: 0x00008A24
			// (set) Token: 0x0600018A RID: 394 RVA: 0x0000A83C File Offset: 0x00008A3C
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

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A848 File Offset: 0x00008A48
			// (set) Token: 0x0600018C RID: 396 RVA: 0x0000A860 File Offset: 0x00008A60
			public string RoomSceneLocationId
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

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600018D RID: 397 RVA: 0x0000A86C File Offset: 0x00008A6C
			// (set) Token: 0x0600018E RID: 398 RVA: 0x0000A884 File Offset: 0x00008A84
			public string Name
			{
				[CompilerGenerated]
				get
				{
					return this.f000035;
				}
				[CompilerGenerated]
				set
				{
					this.f000035 = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600018F RID: 399 RVA: 0x0000A890 File Offset: 0x00008A90
			// (set) Token: 0x06000190 RID: 400 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			public bool IsSandbox
			{
				[CompilerGenerated]
				get
				{
					return this.f000073;
				}
				[CompilerGenerated]
				set
				{
					this.f000073 = value;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000191 RID: 401 RVA: 0x0000A8B4 File Offset: 0x00008AB4
			// (set) Token: 0x06000192 RID: 402 RVA: 0x0000A8CC File Offset: 0x00008ACC
			public string DataBlobName
			{
				[CompilerGenerated]
				get
				{
					return this.f00000e;
				}
				[CompilerGenerated]
				set
				{
					this.f00000e = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000193 RID: 403 RVA: 0x0000A8D8 File Offset: 0x00008AD8
			// (set) Token: 0x06000194 RID: 404 RVA: 0x0000A8F0 File Offset: 0x00008AF0
			public int MaxPlayers
			{
				[CompilerGenerated]
				get
				{
					return this.f000007;
				}
				[CompilerGenerated]
				set
				{
					this.f000007 = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A8FC File Offset: 0x00008AFC
			// (set) Token: 0x06000196 RID: 406 RVA: 0x0000A914 File Offset: 0x00008B14
			public bool CanMatchmakeInto
			{
				[CompilerGenerated]
				get
				{
					return this.f000017;
				}
				[CompilerGenerated]
				set
				{
					this.f000017 = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000197 RID: 407 RVA: 0x0000A920 File Offset: 0x00008B20
			// (set) Token: 0x06000198 RID: 408 RVA: 0x0000A938 File Offset: 0x00008B38
			public DateTime DataModifiedAt
			{
				[CompilerGenerated]
				get
				{
					return this.f000074;
				}
				[CompilerGenerated]
				set
				{
					this.f000074 = value;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000199 RID: 409 RVA: 0x0000A942 File Offset: 0x00008B42
			// (set) Token: 0x0600019A RID: 410 RVA: 0x0000A94A File Offset: 0x00008B4A
			public string ReplicationId { get; set; }

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A953 File Offset: 0x00008B53
			// (set) Token: 0x0600019C RID: 412 RVA: 0x0000A95B File Offset: 0x00008B5B
			public bool UseLevelBasedMatchmaking { get; set; }

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600019D RID: 413 RVA: 0x0000A964 File Offset: 0x00008B64
			// (set) Token: 0x0600019E RID: 414 RVA: 0x0000A96C File Offset: 0x00008B6C
			public bool UseAgeBasedMatchmaking { get; set; }

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600019F RID: 415 RVA: 0x0000A975 File Offset: 0x00008B75
			// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000A97D File Offset: 0x00008B7D
			public bool UseRecRoyaleMatchmaking { get; set; }

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A986 File Offset: 0x00008B86
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000A98E File Offset: 0x00008B8E
			public int ReleaseStatus { get; set; }

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000A997 File Offset: 0x00008B97
			// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000A99F File Offset: 0x00008B9F
			public bool SupportsJoinInProgress { get; set; }

			// Token: 0x040000CF RID: 207
			private long f00002c;

			// Token: 0x040000D0 RID: 208
			private ulong f000023;

			// Token: 0x040000D1 RID: 209
			private string f000003;

			// Token: 0x040000D2 RID: 210
			private string f000035;

			// Token: 0x040000D3 RID: 211
			private bool f000073;

			// Token: 0x040000D4 RID: 212
			private string f00000e;

			// Token: 0x040000D5 RID: 213
			private int f000007;

			// Token: 0x040000D6 RID: 214
			private bool f000017;

			// Token: 0x040000D7 RID: 215
			private DateTime f000074;
		}

		// Token: 0x0200003F RID: 63
		public sealed class c000060
		{
			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000A9B4 File Offset: 0x00008BB4
			// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000A9CC File Offset: 0x00008BCC
			public c00005d.c000061 Room
			{
				[CompilerGenerated]
				get
				{
					return this.f00002d;
				}
				[CompilerGenerated]
				set
				{
					this.f00002d = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000A9D8 File Offset: 0x00008BD8
			// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000A9F0 File Offset: 0x00008BF0
			public List<c00005d.c00005f> Scenes
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

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A9FC File Offset: 0x00008BFC
			// (set) Token: 0x060001AB RID: 427 RVA: 0x0000AA14 File Offset: 0x00008C14
			public List<int> CoOwners
			{
				[CompilerGenerated]
				get
				{
					return this.f000034;
				}
				[CompilerGenerated]
				set
				{
					this.f000034 = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001AC RID: 428 RVA: 0x0000AA20 File Offset: 0x00008C20
			// (set) Token: 0x060001AD RID: 429 RVA: 0x0000AA38 File Offset: 0x00008C38
			public List<int> InvitedCoOwners
			{
				[CompilerGenerated]
				get
				{
					return this.f000034;
				}
				[CompilerGenerated]
				set
				{
					this.f000034 = value;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001AE RID: 430 RVA: 0x0000AA44 File Offset: 0x00008C44
			// (set) Token: 0x060001AF RID: 431 RVA: 0x0000AA5C File Offset: 0x00008C5C
			public List<int> Hosts
			{
				[CompilerGenerated]
				get
				{
					return this.f00002a;
				}
				[CompilerGenerated]
				set
				{
					this.f00002a = value;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000AA68 File Offset: 0x00008C68
			// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000AA80 File Offset: 0x00008C80
			public List<int> InvitedHosts
			{
				[CompilerGenerated]
				get
				{
					return this.f000034;
				}
				[CompilerGenerated]
				set
				{
					this.f000034 = value;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000AA8C File Offset: 0x00008C8C
			// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000AAA4 File Offset: 0x00008CA4
			public int CheerCount
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

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000AAB0 File Offset: 0x00008CB0
			// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000AAC8 File Offset: 0x00008CC8
			public int FavoriteCount
			{
				[CompilerGenerated]
				get
				{
					return this.f000006;
				}
				[CompilerGenerated]
				set
				{
					this.f000006 = value;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000AAD4 File Offset: 0x00008CD4
			// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000AAEC File Offset: 0x00008CEC
			public int VisitCount
			{
				[CompilerGenerated]
				get
				{
					return this.f000007;
				}
				[CompilerGenerated]
				set
				{
					this.f000007 = value;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000AAF8 File Offset: 0x00008CF8
			// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000AB10 File Offset: 0x00008D10
			public List<c00005d.c000063> Tags
			{
				[CompilerGenerated]
				get
				{
					return this.f000075;
				}
				[CompilerGenerated]
				set
				{
					this.f000075 = value;
				}
			}

			// Token: 0x040000D8 RID: 216
			private c00005d.c000061 f00002d;

			// Token: 0x040000D9 RID: 217
			private List<c00005d.c00005f> f000031;

			// Token: 0x040000DA RID: 218
			private List<int> f000034;

			// Token: 0x040000DB RID: 219
			private List<int> f00002a;

			// Token: 0x040000DC RID: 220
			private int f000005;

			// Token: 0x040000DD RID: 221
			private int f000006;

			// Token: 0x040000DE RID: 222
			private int f000007;

			// Token: 0x040000DF RID: 223
			private List<c00005d.c000063> f000075;
		}

		// Token: 0x02000040 RID: 64
		public sealed class c000061
		{
			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060001BB RID: 443 RVA: 0x0000AB24 File Offset: 0x00008D24
			// (set) Token: 0x060001BC RID: 444 RVA: 0x0000AB3C File Offset: 0x00008D3C
			public ulong RoomId
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

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060001BD RID: 445 RVA: 0x0000AB48 File Offset: 0x00008D48
			// (set) Token: 0x060001BE RID: 446 RVA: 0x0000AB60 File Offset: 0x00008D60
			public string Name
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

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060001BF RID: 447 RVA: 0x0000AB6C File Offset: 0x00008D6C
			// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000AB84 File Offset: 0x00008D84
			public string Description
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

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000AB90 File Offset: 0x00008D90
			// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000ABA8 File Offset: 0x00008DA8
			public ulong CreatorPlayerId
			{
				[CompilerGenerated]
				get
				{
					return this.f000076;
				}
				[CompilerGenerated]
				set
				{
					this.f000076 = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000ABB4 File Offset: 0x00008DB4
			// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000ABCC File Offset: 0x00008DCC
			public string ImageName
			{
				[CompilerGenerated]
				get
				{
					return this.f000036;
				}
				[CompilerGenerated]
				set
				{
					this.f000036 = value;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000ABD8 File Offset: 0x00008DD8
			// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000ABF0 File Offset: 0x00008DF0
			public int State
			{
				[CompilerGenerated]
				get
				{
					return this.f000006;
				}
				[CompilerGenerated]
				set
				{
					this.f000006 = value;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000ABFC File Offset: 0x00008DFC
			// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000AC14 File Offset: 0x00008E14
			public int Accessibility
			{
				[CompilerGenerated]
				get
				{
					return this.f000007;
				}
				[CompilerGenerated]
				set
				{
					this.f000007 = value;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000AC20 File Offset: 0x00008E20
			// (set) Token: 0x060001CA RID: 458 RVA: 0x0000AC38 File Offset: 0x00008E38
			public bool SupportsLevelVoting
			{
				[CompilerGenerated]
				get
				{
					return this.f000017;
				}
				[CompilerGenerated]
				set
				{
					this.f000017 = value;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060001CB RID: 459 RVA: 0x0000AC44 File Offset: 0x00008E44
			// (set) Token: 0x060001CC RID: 460 RVA: 0x0000AC5C File Offset: 0x00008E5C
			public bool IsAGRoom
			{
				[CompilerGenerated]
				get
				{
					return this.f000077;
				}
				[CompilerGenerated]
				set
				{
					this.f000077 = value;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060001CD RID: 461 RVA: 0x0000AC68 File Offset: 0x00008E68
			// (set) Token: 0x060001CE RID: 462 RVA: 0x0000AC80 File Offset: 0x00008E80
			public bool CloningAllowed
			{
				[CompilerGenerated]
				get
				{
					return this.f000018;
				}
				[CompilerGenerated]
				set
				{
					this.f000018 = value;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060001CF RID: 463 RVA: 0x0000AC8C File Offset: 0x00008E8C
			// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000ACA4 File Offset: 0x00008EA4
			public bool SupportsScreens
			{
				[CompilerGenerated]
				get
				{
					return this.f000019;
				}
				[CompilerGenerated]
				set
				{
					this.f000019 = value;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000ACB0 File Offset: 0x00008EB0
			// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000ACC8 File Offset: 0x00008EC8
			public bool SupportsWalkVR
			{
				[CompilerGenerated]
				get
				{
					return this.f00001a;
				}
				[CompilerGenerated]
				set
				{
					this.f00001a = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000ACD4 File Offset: 0x00008ED4
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public bool SupportsTeleportVR
			{
				[CompilerGenerated]
				get
				{
					return this.f00001b;
				}
				[CompilerGenerated]
				set
				{
					this.f00001b = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000ACF6 File Offset: 0x00008EF6
			// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000ACFE File Offset: 0x00008EFE
			public string ReplicationId { get; set; }

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000AD07 File Offset: 0x00008F07
			// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000AD0F File Offset: 0x00008F0F
			public int ReleaseStatus { get; set; }

			// Token: 0x040000E2 RID: 226
			private ulong f000001;

			// Token: 0x040000E3 RID: 227
			private string f000002;

			// Token: 0x040000E4 RID: 228
			private string f000003;

			// Token: 0x040000E5 RID: 229
			private ulong f000076;

			// Token: 0x040000E6 RID: 230
			private string f000036;

			// Token: 0x040000E7 RID: 231
			private int f000006;

			// Token: 0x040000E8 RID: 232
			private int f000007;

			// Token: 0x040000E9 RID: 233
			private bool f000017;

			// Token: 0x040000EA RID: 234
			private bool f000077;

			// Token: 0x040000EB RID: 235
			private bool f000018;

			// Token: 0x040000EC RID: 236
			private bool f000019;

			// Token: 0x040000ED RID: 237
			private bool f00001a;

			// Token: 0x040000EE RID: 238
			private bool f00001b;
		}

		// Token: 0x02000041 RID: 65
		public sealed class c000062
		{
			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060001DA RID: 474 RVA: 0x0000AD24 File Offset: 0x00008F24
			// (set) Token: 0x060001DB RID: 475 RVA: 0x0000AD3C File Offset: 0x00008F3C
			public string RoomName
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

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060001DC RID: 476 RVA: 0x0000AD48 File Offset: 0x00008F48
			// (set) Token: 0x060001DD RID: 477 RVA: 0x0000AD60 File Offset: 0x00008F60
			public long RoomId
			{
				[CompilerGenerated]
				get
				{
					return this.f00002e;
				}
				[CompilerGenerated]
				set
				{
					this.f00002e = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060001DE RID: 478 RVA: 0x0000AD6C File Offset: 0x00008F6C
			// (set) Token: 0x060001DF RID: 479 RVA: 0x0000AD84 File Offset: 0x00008F84
			public string ImageName
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

			// Token: 0x040000EF RID: 239
			private string f00000a;

			// Token: 0x040000F0 RID: 240
			private long f00002e;

			// Token: 0x040000F1 RID: 241
			private string f000003;
		}

		// Token: 0x02000042 RID: 66
		public sealed class c000063
		{
			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000AD98 File Offset: 0x00008F98
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000ADB0 File Offset: 0x00008FB0
			public string Tag
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

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000ADBC File Offset: 0x00008FBC
			// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000ADD4 File Offset: 0x00008FD4
			public int Type
			{
				[CompilerGenerated]
				get
				{
					return this.f00000b;
				}
				[CompilerGenerated]
				set
				{
					this.f00000b = value;
				}
			}

			// Token: 0x040000F2 RID: 242
			private string f00000a;

			// Token: 0x040000F3 RID: 243
			private int f00000b;
		}

		// Token: 0x02000043 RID: 67
		public enum enum064
		{

		}

		// Token: 0x02000044 RID: 68
		public enum enum065
		{

		}

		// Token: 0x02000045 RID: 69
		public enum enum066
		{

		}

		// Token: 0x02000046 RID: 70
		public enum enum067
		{

		}
	}
}
