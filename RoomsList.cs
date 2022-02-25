using System;
using System.Collections.Generic;

namespace rooms2018
{
	// Token: 0x02000063 RID: 99
	internal class Rooms
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00011590 File Offset: 0x0000F790
		public static Rooms.RoomDetail getRoomDetails(int roomID)
		{
			foreach (KeyValuePair<string, Rooms.RoomDetail> keyValuePair in Rooms.RecRoomOriginalRooms)
			{
				bool flag = keyValuePair.Value.Room.RoomId == (long)roomID;
				if (flag)
				{
					return keyValuePair.Value;
				}
			}
			return Rooms.RecRoomOriginalRooms["DormRoom"];
		}

		// Token: 0x0400021A RID: 538
		public static Dictionary<string, Rooms.RoomDetail> RecRoomOriginalRooms = new Dictionary<string, Rooms.RoomDetail>
		{
			{
				"DormRoom",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 1L,
						Name = "DormRoom",
						Description = "Your private room",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 1L,
							RoomSceneLocationId = "76d98498-60a1-430c-ab76-b54a29b7a163",
							Name = "dormroom2",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"RecCenter",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 2L,
						Name = "RecCenter",
						Description = "A social hub to meet and mingle with friends new and old.",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 2L,
							RoomSceneLocationId = "cbad71af-0831-44d8-b8ef-69edafa841f6",
							Name = "reccenter",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"3DCharades",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 3L,
						Name = "3DCharades",
						Description = "Take turns drawing, acting, and guessing funny phrases with your friends!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 3L,
							RoomId = 4L,
							RoomSceneLocationId = "4078dfed-24bb-4db7-863f-578ba48d726b",
							Name = "charades",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"DiscGolfLake",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 4L,
						Name = "DiscGolfLake",
						Description = "A leisurely stroll through the grass. Throw your disc into the goal. Sounds easy, right?",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 4L,
							RoomSceneLocationId = "f6f7256c-e438-4299-b99e-d20bef8cf7e0",
							Name = "discgolf",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"DiscGolfPropulsion",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 5L,
						Name = "DiscGolfPropulsion",
						Description = "Throw your disc through hazards and around wind machines on this challenging course!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 5L,
							RoomSceneLocationId = "d9378c9f-80bc-46fb-ad1e-1bed8a674f55",
							Name = "Discgolf_Propulsion",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Dodgeball",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 6L,
						Name = "Dodgeball",
						Description = "Throw dodgeballs to knock out your friends in this gym classic!",
						CreatorPlayerId = 1,
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
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 6L,
							RoomSceneLocationId = "3d474b26-26f7-45e9-9a36-9b02847d5e6f",
							Name = "dodgeball",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Paddleball",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 7L,
						Name = "Paddleball",
						Description = "A simple rally game between two players in a plexiglass tube with a zero-g ball.",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 7L,
							RoomSceneLocationId = "d89f74fa-d51e-477a-a425-025a891dd499",
							Name = "paddleball",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Paintball",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 8L,
						Name = "Paintball",
						Description = "Red and Blue teams splat each other in capture the flag and team battle.",
						CreatorPlayerId = 1,
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
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 8L,
							RoomSceneLocationId = "e122fe98-e7db-49e8-a1b1-105424b6e1f0",
							Name = "River",
							IsSandbox = false,
							DataBlobName = "",
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new Rooms.Scene
						{
							RoomSceneId = 2L,
							RoomId = 9L,
							RoomSceneLocationId = "a785267d-c579-42ea-be43-fec1992d1ca7",
							Name = "Homestead",
							IsSandbox = false,
							DataBlobName = "",
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new Rooms.Scene
						{
							RoomSceneId = 3L,
							RoomId = 10L,
							RoomSceneLocationId = "ff4c6427-7079-4f59-b22a-69b089420827",
							Name = "Quarry",
							IsSandbox = false,
							DataBlobName = "",
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new Rooms.Scene
						{
							RoomSceneId = 4L,
							RoomId = 11L,
							RoomSceneLocationId = "380d18b5-de9c-49f3-80f7-f4a95c1de161",
							Name = "Clearcut",
							IsSandbox = false,
							DataBlobName = "",
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new Rooms.Scene
						{
							RoomSceneId = 5L,
							RoomId = 12L,
							RoomSceneLocationId = "58763055-2dfb-4814-80b8-16fac5c85709",
							Name = "Spillway",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"GoldenTrophy",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 13L,
						Name = "GoldenTrophy",
						Description = "The goblin king stole Coach's Golden Trophy. Team up and embark on an epic quest to recover it!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 13L,
							RoomSceneLocationId = "91e16e35-f48f-4700-ab8a-a1b79e50e51b",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"TheRiseofJumbotron",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 14L,
						Name = "TheRiseofJumbotron",
						Description = "Robot invaders threaten the galaxy! Team up with your friends and bring the laser heat!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 14L,
							RoomSceneLocationId = "acc06e66-c2d0-4361-b0cd-46246a4c455c",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"CrimsonCauldron",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 15L,
						Name = "CrimsonCauldron",
						Description = "Can your band of adventurers brave the enchanted wilds, and lift the curse of the crimson cauldron?",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 15L,
							RoomSceneLocationId = "949fa41f-4347-45c0-b7ac-489129174045",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"IsleOfLostSkulls",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 16L,
						Name = "IsleOfLostSkulls",
						Description = "Can your pirate crew get to the Isle, defeat its fearsome guardian, and escape with the gold?",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 16L,
							RoomSceneLocationId = "7e01cfe0-820a-406f-b1b3-0a5bf575235c",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Soccer",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 17L,
						Name = "Soccer",
						Description = "Teams of three run around slamming themselves into an over-sized soccer ball. Goal!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 17L,
							RoomSceneLocationId = "6d5eea4b-f069-4ed0-9916-0e2f07df0d03",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"LaserTag",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 18L,
						Name = "LaserTag",
						Description = "Teams battle each other and waves of robots.",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 1L,
							RoomId = 18L,
							RoomSceneLocationId = "239e676c-f12f-489f-bf3a-d4c383d692c3",
							Name = "Hangar",
							IsSandbox = false,
							DataBlobName = "",
							MaxPlayers = 20,
							CanMatchmakeInto = true,
							DataModifiedAt = DateTime.Now
						},
						new Rooms.Scene
						{
							RoomSceneId = 2L,
							RoomId = 19L,
							RoomSceneLocationId = "9d6456ce-6264-48b4-808d-2d96b3d91038",
							Name = "CyberJunkCity",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"RecRoyaleSquads",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 20L,
						Name = "RecRoyaleSquads",
						Description = "Squads of three battle it out on Frontier Island. Last squad standing wins!",
						CreatorPlayerId = 1,
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
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 20L,
							RoomSceneLocationId = "253fa009-6e65-4c90-91a1-7137a56a267f",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"RecRoyaleSolos",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 21L,
						Name = "RecRoyaleSolos",
						Description = "Battle it out on Frontier Island. Last person standing wins!",
						CreatorPlayerId = 1,
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
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 21L,
							RoomSceneLocationId = "b010171f-4875-4e89-baba-61e878cd41e1",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Lounge",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 22L,
						Name = "Lounge",
						Description = "A low-key lounge to chill with your friends. Great for private parties!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 22L,
							RoomSceneLocationId = "a067557f-ca32-43e6-b6e5-daaec60b4f5a",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "recroomoriginal",
							Type = 2
						}
					}
				}
			},
			{
				"PerformanceHall",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 23L,
						Name = "PerformanceHall",
						Description = "A theater for plays, music, comedy and other performances.",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 23L,
							RoomSceneLocationId = "9932f88f-3929-43a0-a012-a40b5128e346",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"MakerRoom",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 24L,
						Name = "MakerRoom",
						Description = "This room is a blank canvas. Make it into whatever you like!",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 24L,
							RoomSceneLocationId = "a75f7547-79eb-47c6-8986-6767abcb4f92 ",
							Name = "Home",
							IsSandbox = true,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"Park",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 25L,
						Name = "Park",
						Description = "A sprawling park with amphitheater, play fields, and a cave.",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 25L,
							RoomSceneLocationId = "0a864c86-5a71-4e18-8041-8124e4dc9d98",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"GoKartQuest",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 27L,
						Name = "GoKartQuest",
						Description = "New",
						CreatorPlayerId = 1,
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
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 27L,
							RoomSceneLocationId = "49cb8993-a956-43e2-86f4-1318f279b22a",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			},
			{
				"HardMaybe",
				new Rooms.RoomDetail
				{
					Room = new Rooms.cRoom
					{
						RoomId = 28L,
						Name = "HardMaybe",
						Description = "New",
						CreatorPlayerId = 1,
						ImageName = "",
						State = 0,
						Accessibility = 1,
						SupportsLevelVoting = false,
						IsAGRoom = true,
						CloningAllowed = false,
						SupportsScreens = true,
						SupportsTeleportVR = true,
						SupportsWalkVR = true
					},
					Scenes = new List<Rooms.Scene>
					{
						new Rooms.Scene
						{
							RoomSceneId = 0L,
							RoomId = 28L,
							RoomSceneLocationId = "ae929543-9a07-41d5-8ee9-dbbee8c36800",
							Name = "Home",
							IsSandbox = false,
							DataBlobName = "",
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
					Tags = new List<Rooms.cTag>
					{
						new Rooms.cTag
						{
							Tag = "rro",
							Type = 2
						}
					}
				}
			}
		};

		// Token: 0x02000064 RID: 100
		public enum RoomTagTypes
		{
			// Token: 0x0400021C RID: 540
			General,
			// Token: 0x0400021D RID: 541
			Auto,
			// Token: 0x0400021E RID: 542
			AGOnly,
			// Token: 0x0400021F RID: 543
			Banned
		}

		// Token: 0x02000065 RID: 101
		public enum RoomStates
		{
			// Token: 0x04000221 RID: 545
			Active,
			// Token: 0x04000222 RID: 546
			PendingJunior = 11,
			// Token: 0x04000223 RID: 547
			Moderation_PendingReview = 100,
			// Token: 0x04000224 RID: 548
			Moderation_Closed,
			// Token: 0x04000225 RID: 549
			MarkedForDelete = 1000
		}

		// Token: 0x02000066 RID: 102
		public enum RoomAccessibility
		{
			// Token: 0x04000227 RID: 551
			Private,
			// Token: 0x04000228 RID: 552
			Public,
			// Token: 0x04000229 RID: 553
			Unlisted
		}

		// Token: 0x02000067 RID: 103
		public enum RoomScreenModeSupport
		{
			// Token: 0x0400022B RID: 555
			Isolated,
			// Token: 0x0400022C RID: 556
			Mixed,
			// Token: 0x0400022D RID: 557
			Blocked
		}

		// Token: 0x02000068 RID: 104
		public enum RoomSaveResult
		{
			// Token: 0x0400022F RID: 559
			Success,
			// Token: 0x04000230 RID: 560
			Unknown,
			// Token: 0x04000231 RID: 561
			PermissionDenied,
			// Token: 0x04000232 RID: 562
			RoomNotActive,
			// Token: 0x04000233 RID: 563
			RoomDoesNotExist,
			// Token: 0x04000234 RID: 564
			RoomHasNoDataBlob,
			// Token: 0x04000235 RID: 565
			DuplicateName = 10,
			// Token: 0x04000236 RID: 566
			ReservedName,
			// Token: 0x04000237 RID: 567
			InappropriateName,
			// Token: 0x04000238 RID: 568
			InappropriateDescription,
			// Token: 0x04000239 RID: 569
			TooManyRooms = 20,
			// Token: 0x0400023A RID: 570
			InvalidMaxPlayers = 30,
			// Token: 0x0400023B RID: 571
			DataHistoryDoesNotExist = 40,
			// Token: 0x0400023C RID: 572
			DataHistoryAlreadyActive,
			// Token: 0x0400023D RID: 573
			RoomUnderModerationReview = 100,
			// Token: 0x0400023E RID: 574
			PlayerHasRoomUnderModerationReview,
			// Token: 0x0400023F RID: 575
			AccessibilityUnderModerationLock,
			// Token: 0x04000240 RID: 576
			JuniorStatusFail = 200
		}

		// Token: 0x02000069 RID: 105
		public class RoomDetail
		{
			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x0600024D RID: 589 RVA: 0x00003036 File Offset: 0x00001236
			// (set) Token: 0x0600024E RID: 590 RVA: 0x0000303E File Offset: 0x0000123E
			public Rooms.cRoom Room { get; set; }

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600024F RID: 591 RVA: 0x00003047 File Offset: 0x00001247
			// (set) Token: 0x06000250 RID: 592 RVA: 0x0000304F File Offset: 0x0000124F
			public List<Rooms.Scene> Scenes { get; set; }

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000251 RID: 593 RVA: 0x00003058 File Offset: 0x00001258
			// (set) Token: 0x06000252 RID: 594 RVA: 0x00003060 File Offset: 0x00001260
			public List<int> CoOwners { get; set; }

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000253 RID: 595 RVA: 0x00003069 File Offset: 0x00001269
			// (set) Token: 0x06000254 RID: 596 RVA: 0x00003071 File Offset: 0x00001271
			public List<int> Hosts { get; set; }

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000255 RID: 597 RVA: 0x0000307A File Offset: 0x0000127A
			// (set) Token: 0x06000256 RID: 598 RVA: 0x00003082 File Offset: 0x00001282
			public int CheerCount { get; set; }

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000308B File Offset: 0x0000128B
			// (set) Token: 0x06000258 RID: 600 RVA: 0x00003093 File Offset: 0x00001293
			public int FavoriteCount { get; set; }

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000259 RID: 601 RVA: 0x0000309C File Offset: 0x0000129C
			// (set) Token: 0x0600025A RID: 602 RVA: 0x000030A4 File Offset: 0x000012A4
			public int VisitCount { get; set; }

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x0600025B RID: 603 RVA: 0x000030AD File Offset: 0x000012AD
			// (set) Token: 0x0600025C RID: 604 RVA: 0x000030B5 File Offset: 0x000012B5
			public List<Rooms.cTag> Tags { get; set; }
		}

		// Token: 0x0200006A RID: 106
		public class cRoom
		{
			// Token: 0x170000EA RID: 234
			// (get) Token: 0x0600025E RID: 606 RVA: 0x000030BE File Offset: 0x000012BE
			// (set) Token: 0x0600025F RID: 607 RVA: 0x000030C6 File Offset: 0x000012C6
			public long RoomId { get; set; }

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000260 RID: 608 RVA: 0x000030CF File Offset: 0x000012CF
			// (set) Token: 0x06000261 RID: 609 RVA: 0x000030D7 File Offset: 0x000012D7
			public string Name { get; set; }

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000262 RID: 610 RVA: 0x000030E0 File Offset: 0x000012E0
			// (set) Token: 0x06000263 RID: 611 RVA: 0x000030E8 File Offset: 0x000012E8
			public string Description { get; set; }

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000264 RID: 612 RVA: 0x000030F1 File Offset: 0x000012F1
			// (set) Token: 0x06000265 RID: 613 RVA: 0x000030F9 File Offset: 0x000012F9
			public int CreatorPlayerId { get; set; }

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000266 RID: 614 RVA: 0x00003102 File Offset: 0x00001302
			// (set) Token: 0x06000267 RID: 615 RVA: 0x0000310A File Offset: 0x0000130A
			public string ImageName { get; set; }

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000268 RID: 616 RVA: 0x00003113 File Offset: 0x00001313
			// (set) Token: 0x06000269 RID: 617 RVA: 0x0000311B File Offset: 0x0000131B
			public int State { get; set; }

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600026A RID: 618 RVA: 0x00003124 File Offset: 0x00001324
			// (set) Token: 0x0600026B RID: 619 RVA: 0x0000312C File Offset: 0x0000132C
			public int Accessibility { get; set; }

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x0600026C RID: 620 RVA: 0x00003135 File Offset: 0x00001335
			// (set) Token: 0x0600026D RID: 621 RVA: 0x0000313D File Offset: 0x0000133D
			public bool SupportsLevelVoting { get; set; }

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x0600026E RID: 622 RVA: 0x00003146 File Offset: 0x00001346
			// (set) Token: 0x0600026F RID: 623 RVA: 0x0000314E File Offset: 0x0000134E
			public bool IsAGRoom { get; set; }

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000270 RID: 624 RVA: 0x00003157 File Offset: 0x00001357
			// (set) Token: 0x06000271 RID: 625 RVA: 0x0000315F File Offset: 0x0000135F
			public bool CloningAllowed { get; set; }

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000272 RID: 626 RVA: 0x00003168 File Offset: 0x00001368
			// (set) Token: 0x06000273 RID: 627 RVA: 0x00003170 File Offset: 0x00001370
			public bool SupportsScreens { get; set; }

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000274 RID: 628 RVA: 0x00003179 File Offset: 0x00001379
			// (set) Token: 0x06000275 RID: 629 RVA: 0x00003181 File Offset: 0x00001381
			public bool SupportsWalkVR { get; set; }

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000276 RID: 630 RVA: 0x0000318A File Offset: 0x0000138A
			// (set) Token: 0x06000277 RID: 631 RVA: 0x00003192 File Offset: 0x00001392
			public bool SupportsTeleportVR { get; set; }
		}

		// Token: 0x0200006B RID: 107
		public class Scene
		{
			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000279 RID: 633 RVA: 0x0000319B File Offset: 0x0000139B
			// (set) Token: 0x0600027A RID: 634 RVA: 0x000031A3 File Offset: 0x000013A3
			public long RoomSceneId { get; set; }

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600027B RID: 635 RVA: 0x000031AC File Offset: 0x000013AC
			// (set) Token: 0x0600027C RID: 636 RVA: 0x000031B4 File Offset: 0x000013B4
			public long RoomId { get; set; }

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600027D RID: 637 RVA: 0x000031BD File Offset: 0x000013BD
			// (set) Token: 0x0600027E RID: 638 RVA: 0x000031C5 File Offset: 0x000013C5
			public string RoomSceneLocationId { get; set; }

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600027F RID: 639 RVA: 0x000031CE File Offset: 0x000013CE
			// (set) Token: 0x06000280 RID: 640 RVA: 0x000031D6 File Offset: 0x000013D6
			public string Name { get; set; }

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000281 RID: 641 RVA: 0x000031DF File Offset: 0x000013DF
			// (set) Token: 0x06000282 RID: 642 RVA: 0x000031E7 File Offset: 0x000013E7
			public bool IsSandbox { get; set; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000283 RID: 643 RVA: 0x000031F0 File Offset: 0x000013F0
			// (set) Token: 0x06000284 RID: 644 RVA: 0x000031F8 File Offset: 0x000013F8
			public string DataBlobName { get; set; }

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000285 RID: 645 RVA: 0x00003201 File Offset: 0x00001401
			// (set) Token: 0x06000286 RID: 646 RVA: 0x00003209 File Offset: 0x00001409
			public int MaxPlayers { get; set; }

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000287 RID: 647 RVA: 0x00003212 File Offset: 0x00001412
			// (set) Token: 0x06000288 RID: 648 RVA: 0x0000321A File Offset: 0x0000141A
			public bool CanMatchmakeInto { get; set; }

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000289 RID: 649 RVA: 0x00003223 File Offset: 0x00001423
			// (set) Token: 0x0600028A RID: 650 RVA: 0x0000322B File Offset: 0x0000142B
			public DateTime DataModifiedAt { get; set; }
		}

		// Token: 0x0200006C RID: 108
		public class cTag
		{
			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600028C RID: 652 RVA: 0x00003234 File Offset: 0x00001434
			// (set) Token: 0x0600028D RID: 653 RVA: 0x0000323C File Offset: 0x0000143C
			public string Tag { get; set; }

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x0600028E RID: 654 RVA: 0x00003245 File Offset: 0x00001445
			// (set) Token: 0x0600028F RID: 655 RVA: 0x0000324D File Offset: 0x0000144D
			public int Type { get; set; }
		}

		// Token: 0x0200006D RID: 109
		public class RoomPlayPage
		{
			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000291 RID: 657 RVA: 0x00003256 File Offset: 0x00001456
			// (set) Token: 0x06000292 RID: 658 RVA: 0x0000325E File Offset: 0x0000145E
			public string RoomName { get; set; }

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000293 RID: 659 RVA: 0x00003267 File Offset: 0x00001467
			// (set) Token: 0x06000294 RID: 660 RVA: 0x0000326F File Offset: 0x0000146F
			public long RoomId { get; set; }

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000295 RID: 661 RVA: 0x00003278 File Offset: 0x00001478
			// (set) Token: 0x06000296 RID: 662 RVA: 0x00003280 File Offset: 0x00001480
			public string ImageName { get; set; }
		}
	}
}
