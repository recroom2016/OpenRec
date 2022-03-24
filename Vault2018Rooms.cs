using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using server;
using Newtonsoft.Json;

namespace vaultgamesesh
{
	// Token: 0x02000006 RID: 6
	internal sealed class c00005d
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000264C File Offset: 0x0000084C
		public static Dictionary<string, c00005d.c000060> m00003a()
		{
			Dictionary<string, c00005d.c000060> result = new Dictionary<string, c00005d.c000060>();
			string[] directories = Directory.GetDirectories(c000004.m000007());
			for (int i = 0; i < directories.Length; i++)
			{
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002688 File Offset: 0x00000888
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

		// Token: 0x06000013 RID: 19 RVA: 0x000026E8 File Offset: 0x000008E8
		public static c00005d.c000060 m000023(int p0)
		{
			foreach (KeyValuePair<string, c00005d.c000060> keyValuePair in c00005d.f000050)
			{
				bool flag = keyValuePair.Value.Room.RoomId == (ulong)((long)p0);
				if (flag)
				{
					return keyValuePair.Value;
				}
			}
			return c00005d.f000050["DormRoom"];
		}

		// Token: 0x0400000D RID: 13
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

		// Token: 0x0400000E RID: 14
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
						ImageName = "Dorm.png",
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
						ImageName = "RecCenter.png",
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
						ImageName = "ActivityCharades.png",
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
						ImageName = "DiscGolfLake.png",
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
						ImageName = "DiscGolfPropulsion.png",
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
						ImageName = "Dodgeball.png",
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
						ImageName = "ActivityPaddleball.png",
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
						ImageName = "Paintball.png",
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
						ImageName = "Golden.png",
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
						ImageName = "Jumbo.png",
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
						ImageName = "Crimson.png",
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
						ImageName = "Isle.png",
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
						ImageName = "Soccer.png",
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
						ImageName = "LaserTag.png",
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
						ImageName = "ActivityRecRoyale.png",
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
						ImageName = "RecRoyale.png",
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
						ImageName = "Lounge.png",
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
							Tag = "recroomoriginal",
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
						ImageName = "Park.png",
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
						ImageName = "DraccIsBack.png",
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
				"Bawling",
				new c00005d.c000060
				{
					Room = new c00005d.c000061
					{
						RoomId = 28UL,
						Name = "Bawling",
						Description = "Go to the Two Footware Coridor Bawling Coridor to admire off branded Raw Data, Play Jumbotron on 4 arcade cabinets (each with 4 player split screen, and 16 player multiplayer), take a ball and hit the white cubes, and conimplate life in front of the lockers in this Beta RRO!",
						CreatorPlayerId = 782441001UL,
						ImageName = "bawling.png",
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
			}
		};

		// Token: 0x0200002B RID: 43
		public enum enum05e
		{

		}

		// Token: 0x0200002C RID: 44
		public sealed class c00005f
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000FB RID: 251 RVA: 0x0000B4F0 File Offset: 0x000096F0
			// (set) Token: 0x060000FC RID: 252 RVA: 0x0000B508 File Offset: 0x00009708
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

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000FD RID: 253 RVA: 0x0000B514 File Offset: 0x00009714
			// (set) Token: 0x060000FE RID: 254 RVA: 0x0000B52C File Offset: 0x0000972C
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

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000FF RID: 255 RVA: 0x0000B538 File Offset: 0x00009738
			// (set) Token: 0x06000100 RID: 256 RVA: 0x0000B550 File Offset: 0x00009750
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

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000101 RID: 257 RVA: 0x0000B55C File Offset: 0x0000975C
			// (set) Token: 0x06000102 RID: 258 RVA: 0x0000B574 File Offset: 0x00009774
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

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000103 RID: 259 RVA: 0x0000B580 File Offset: 0x00009780
			// (set) Token: 0x06000104 RID: 260 RVA: 0x0000B598 File Offset: 0x00009798
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

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000105 RID: 261 RVA: 0x0000B5A4 File Offset: 0x000097A4
			// (set) Token: 0x06000106 RID: 262 RVA: 0x0000B5BC File Offset: 0x000097BC
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

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000107 RID: 263 RVA: 0x0000B5C8 File Offset: 0x000097C8
			// (set) Token: 0x06000108 RID: 264 RVA: 0x0000B5E0 File Offset: 0x000097E0
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

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000109 RID: 265 RVA: 0x0000B5EC File Offset: 0x000097EC
			// (set) Token: 0x0600010A RID: 266 RVA: 0x0000B604 File Offset: 0x00009804
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

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600010B RID: 267 RVA: 0x0000B610 File Offset: 0x00009810
			// (set) Token: 0x0600010C RID: 268 RVA: 0x0000B628 File Offset: 0x00009828
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

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600010D RID: 269 RVA: 0x0000B632 File Offset: 0x00009832
			// (set) Token: 0x0600010E RID: 270 RVA: 0x0000B63A File Offset: 0x0000983A
			public string ReplicationId { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600010F RID: 271 RVA: 0x0000B643 File Offset: 0x00009843
			// (set) Token: 0x06000110 RID: 272 RVA: 0x0000B64B File Offset: 0x0000984B
			public bool UseLevelBasedMatchmaking { get; set; }

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000111 RID: 273 RVA: 0x0000B654 File Offset: 0x00009854
			// (set) Token: 0x06000112 RID: 274 RVA: 0x0000B65C File Offset: 0x0000985C
			public bool UseAgeBasedMatchmaking { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000113 RID: 275 RVA: 0x0000B665 File Offset: 0x00009865
			// (set) Token: 0x06000114 RID: 276 RVA: 0x0000B66D File Offset: 0x0000986D
			public bool UseRecRoyaleMatchmaking { get; set; }

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000115 RID: 277 RVA: 0x0000B676 File Offset: 0x00009876
			// (set) Token: 0x06000116 RID: 278 RVA: 0x0000B67E File Offset: 0x0000987E
			public int ReleaseStatus { get; set; }

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000117 RID: 279 RVA: 0x0000B687 File Offset: 0x00009887
			// (set) Token: 0x06000118 RID: 280 RVA: 0x0000B68F File Offset: 0x0000988F
			public bool SupportsJoinInProgress { get; set; }

			// Token: 0x0400008F RID: 143
			private long f00002c;

			// Token: 0x04000090 RID: 144
			private ulong f000023;

			// Token: 0x04000091 RID: 145
			private string f000003;

			// Token: 0x04000092 RID: 146
			private string f000035;

			// Token: 0x04000093 RID: 147
			private bool f000073;

			// Token: 0x04000094 RID: 148
			private string f00000e;

			// Token: 0x04000095 RID: 149
			private int f000007;

			// Token: 0x04000096 RID: 150
			private bool f000017;

			// Token: 0x04000097 RID: 151
			private DateTime f000074;
		}

		// Token: 0x0200002D RID: 45
		public sealed class c000060
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600011A RID: 282 RVA: 0x0000B6A4 File Offset: 0x000098A4
			// (set) Token: 0x0600011B RID: 283 RVA: 0x0000B6BC File Offset: 0x000098BC
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

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600011C RID: 284 RVA: 0x0000B6C8 File Offset: 0x000098C8
			// (set) Token: 0x0600011D RID: 285 RVA: 0x0000B6E0 File Offset: 0x000098E0
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

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600011E RID: 286 RVA: 0x0000B6EC File Offset: 0x000098EC
			// (set) Token: 0x0600011F RID: 287 RVA: 0x0000B704 File Offset: 0x00009904
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

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000120 RID: 288 RVA: 0x0000B710 File Offset: 0x00009910
			// (set) Token: 0x06000121 RID: 289 RVA: 0x0000B728 File Offset: 0x00009928
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

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000122 RID: 290 RVA: 0x0000B734 File Offset: 0x00009934
			// (set) Token: 0x06000123 RID: 291 RVA: 0x0000B74C File Offset: 0x0000994C
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

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000124 RID: 292 RVA: 0x0000B758 File Offset: 0x00009958
			// (set) Token: 0x06000125 RID: 293 RVA: 0x0000B770 File Offset: 0x00009970
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

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000126 RID: 294 RVA: 0x0000B77C File Offset: 0x0000997C
			// (set) Token: 0x06000127 RID: 295 RVA: 0x0000B794 File Offset: 0x00009994
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

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000128 RID: 296 RVA: 0x0000B7A0 File Offset: 0x000099A0
			// (set) Token: 0x06000129 RID: 297 RVA: 0x0000B7B8 File Offset: 0x000099B8
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

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600012A RID: 298 RVA: 0x0000B7C4 File Offset: 0x000099C4
			// (set) Token: 0x0600012B RID: 299 RVA: 0x0000B7DC File Offset: 0x000099DC
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

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600012C RID: 300 RVA: 0x0000B7E8 File Offset: 0x000099E8
			// (set) Token: 0x0600012D RID: 301 RVA: 0x0000B800 File Offset: 0x00009A00
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

			// Token: 0x04000098 RID: 152
			private c00005d.c000061 f00002d;

			// Token: 0x04000099 RID: 153
			private List<c00005d.c00005f> f000031;

			// Token: 0x0400009A RID: 154
			private List<int> f000034;

			// Token: 0x0400009B RID: 155
			private List<int> f00002a;

			// Token: 0x0400009C RID: 156
			private int f000005;

			// Token: 0x0400009D RID: 157
			private int f000006;

			// Token: 0x0400009E RID: 158
			private int f000007;

			// Token: 0x0400009F RID: 159
			private List<c00005d.c000063> f000075;
		}

		// Token: 0x0200002E RID: 46
		public sealed class c000061
		{
			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600012F RID: 303 RVA: 0x0000B814 File Offset: 0x00009A14
			// (set) Token: 0x06000130 RID: 304 RVA: 0x0000B82C File Offset: 0x00009A2C
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

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000131 RID: 305 RVA: 0x0000B838 File Offset: 0x00009A38
			// (set) Token: 0x06000132 RID: 306 RVA: 0x0000B850 File Offset: 0x00009A50
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

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000133 RID: 307 RVA: 0x0000B85C File Offset: 0x00009A5C
			// (set) Token: 0x06000134 RID: 308 RVA: 0x0000B874 File Offset: 0x00009A74
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

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000135 RID: 309 RVA: 0x0000B880 File Offset: 0x00009A80
			// (set) Token: 0x06000136 RID: 310 RVA: 0x0000B898 File Offset: 0x00009A98
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

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000137 RID: 311 RVA: 0x0000B8A4 File Offset: 0x00009AA4
			// (set) Token: 0x06000138 RID: 312 RVA: 0x0000B8BC File Offset: 0x00009ABC
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

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000139 RID: 313 RVA: 0x0000B8C8 File Offset: 0x00009AC8
			// (set) Token: 0x0600013A RID: 314 RVA: 0x0000B8E0 File Offset: 0x00009AE0
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

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x0600013B RID: 315 RVA: 0x0000B8EC File Offset: 0x00009AEC
			// (set) Token: 0x0600013C RID: 316 RVA: 0x0000B904 File Offset: 0x00009B04
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

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600013D RID: 317 RVA: 0x0000B910 File Offset: 0x00009B10
			// (set) Token: 0x0600013E RID: 318 RVA: 0x0000B928 File Offset: 0x00009B28
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

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600013F RID: 319 RVA: 0x0000B934 File Offset: 0x00009B34
			// (set) Token: 0x06000140 RID: 320 RVA: 0x0000B94C File Offset: 0x00009B4C
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

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000141 RID: 321 RVA: 0x0000B958 File Offset: 0x00009B58
			// (set) Token: 0x06000142 RID: 322 RVA: 0x0000B970 File Offset: 0x00009B70
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

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000143 RID: 323 RVA: 0x0000B97C File Offset: 0x00009B7C
			// (set) Token: 0x06000144 RID: 324 RVA: 0x0000B994 File Offset: 0x00009B94
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

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000145 RID: 325 RVA: 0x0000B9A0 File Offset: 0x00009BA0
			// (set) Token: 0x06000146 RID: 326 RVA: 0x0000B9B8 File Offset: 0x00009BB8
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

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000147 RID: 327 RVA: 0x0000B9C4 File Offset: 0x00009BC4
			// (set) Token: 0x06000148 RID: 328 RVA: 0x0000B9DC File Offset: 0x00009BDC
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

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000149 RID: 329 RVA: 0x0000B9E6 File Offset: 0x00009BE6
			// (set) Token: 0x0600014A RID: 330 RVA: 0x0000B9EE File Offset: 0x00009BEE
			public string ReplicationId { get; set; }

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600014B RID: 331 RVA: 0x0000B9F7 File Offset: 0x00009BF7
			// (set) Token: 0x0600014C RID: 332 RVA: 0x0000B9FF File Offset: 0x00009BFF
			public int ReleaseStatus { get; set; }

			// Token: 0x040000A2 RID: 162
			private ulong f000001;

			// Token: 0x040000A3 RID: 163
			private string f000002;

			// Token: 0x040000A4 RID: 164
			private string f000003;

			// Token: 0x040000A5 RID: 165
			private ulong f000076;

			// Token: 0x040000A6 RID: 166
			private string f000036;

			// Token: 0x040000A7 RID: 167
			private int f000006;

			// Token: 0x040000A8 RID: 168
			private int f000007;

			// Token: 0x040000A9 RID: 169
			private bool f000017;

			// Token: 0x040000AA RID: 170
			private bool f000077;

			// Token: 0x040000AB RID: 171
			private bool f000018;

			// Token: 0x040000AC RID: 172
			private bool f000019;

			// Token: 0x040000AD RID: 173
			private bool f00001a;

			// Token: 0x040000AE RID: 174
			private bool f00001b;
		}

		// Token: 0x0200002F RID: 47
		public sealed class c000062
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600014E RID: 334 RVA: 0x0000BA14 File Offset: 0x00009C14
			// (set) Token: 0x0600014F RID: 335 RVA: 0x0000BA2C File Offset: 0x00009C2C
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

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000150 RID: 336 RVA: 0x0000BA38 File Offset: 0x00009C38
			// (set) Token: 0x06000151 RID: 337 RVA: 0x0000BA50 File Offset: 0x00009C50
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

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000152 RID: 338 RVA: 0x0000BA5C File Offset: 0x00009C5C
			// (set) Token: 0x06000153 RID: 339 RVA: 0x0000BA74 File Offset: 0x00009C74
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

			// Token: 0x040000AF RID: 175
			private string f00000a;

			// Token: 0x040000B0 RID: 176
			private long f00002e;

			// Token: 0x040000B1 RID: 177
			private string f000003;
		}

		// Token: 0x02000030 RID: 48
		public sealed class c000063
		{
			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000155 RID: 341 RVA: 0x0000BA88 File Offset: 0x00009C88
			// (set) Token: 0x06000156 RID: 342 RVA: 0x0000BAA0 File Offset: 0x00009CA0
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

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000157 RID: 343 RVA: 0x0000BAAC File Offset: 0x00009CAC
			// (set) Token: 0x06000158 RID: 344 RVA: 0x0000BAC4 File Offset: 0x00009CC4
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

			// Token: 0x040000B2 RID: 178
			private string f00000a;

			// Token: 0x040000B3 RID: 179
			private int f00000b;
		}

		// Token: 0x02000031 RID: 49
		public enum enum064
		{

		}

		// Token: 0x02000032 RID: 50
		public enum enum065
		{

		}

		// Token: 0x02000033 RID: 51
		public enum enum066
		{

		}

		// Token: 0x02000034 RID: 52
		public enum enum067
		{

		}
	}
}