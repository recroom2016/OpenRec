using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using vaultgamesesh;
using System.IO;
using server;

namespace api
{
    class CustomRooms
    {
        public static void RoomDecode(string roomname, string roomsceneid, string imagename, string datablob)
        {
            File.WriteAllText("SaveData\\Rooms\\Downloaded\\roomname.txt", roomname);
            File.WriteAllText("SaveData\\Rooms\\Downloaded\\datablob.txt", datablob);
            File.WriteAllText("SaveData\\Rooms\\Downloaded\\roomsceneid.txt", roomsceneid);
            File.WriteAllText("SaveData\\Rooms\\Downloaded\\imagename.txt", imagename);
            ulong rand = Convert.ToUInt64(new Random().Next(0, 99));
            room = new Room
            {
                RoomId = rand,
                Name = roomname,
                Description = "OpenRec Downloaded Room",
                ImageName = imagename,
                CreatorPlayerId = APIServer.CachedPlayerID,
                State = 0,
                Accessibility = 1,
                SupportsLevelVoting = false,
                IsAGRoom = false,
                CloningAllowed = false,
                SupportsScreens = true,
                SupportsWalkVR = true,
                SupportsTeleportVR = true,
                ReplicationId = null,
                ReleaseStatus = 0

            };
            scene = new List<Scene>
            {
                new Scene()
                {
                    RoomSceneId = 1,
                    RoomId = rand,
                    RoomSceneLocationId = "a75f7547-79eb-47c6-8986-6767abcb4f92",
                    Name = "Home",
                    IsSandbox = true,
                    DataBlobName = datablob,
                    MaxPlayers = 20,
                    CanMatchmakeInto = true,
                    DataModifiedAt = DateTime.Now,
                    ReplicationId = null,
                    UseLevelBasedMatchmaking = false,
                    UseAgeBasedMatchmaking = false,
                    UseRecRoyaleMatchmaking = false,
                    ReleaseStatus = 0,
                    SupportsJoinInProgress = true
                }
            };
            root = new Root
            {
                Room = room,
                Scenes = scene,
                CoOwners = new List<ulong>(),
                InvitedCoOwners = new List<ulong>(),
                Hosts = new List<ulong>(),
                InvitedHosts = new List<ulong>(),
                CheerCount = 999,
                FavoriteCount = 999,
                VisitCount = 999,
                Tags = new List<aTag>
                {
                    new aTag()
                    {
                        Tag = "rro",
                        Type = 2
                    }
                }

            };
            File.WriteAllText("SaveData\\Rooms\\Downloaded\\RoomDetails.json", JsonConvert.SerializeObject(root));
        }

        public static Room room { get; set; }
        public static List<Scene> scene { get; set; }
        public static Root root { get; set; }
        //2018 rooms
        public class Room
        {
            public ulong RoomId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public ulong CreatorPlayerId { get; set; }
            public string ImageName { get; set; }
            public int State { get; set; }
            public int Accessibility { get; set; }
            public bool SupportsLevelVoting { get; set; }
            public bool IsAGRoom { get; set; }
            public bool CloningAllowed { get; set; }
            public bool SupportsScreens { get; set; }
            public bool SupportsWalkVR { get; set; }
            public bool SupportsTeleportVR { get; set; }
            public object ReplicationId { get; set; }
            public int ReleaseStatus { get; set; }
        }
        
        public class Scene
        {
            public int RoomSceneId { get; set; }
            public ulong RoomId { get; set; }
            public string RoomSceneLocationId { get; set; }
            public string Name { get; set; }
            public bool IsSandbox { get; set; }
            public string DataBlobName { get; set; }
            public int MaxPlayers { get; set; }
            public bool CanMatchmakeInto { get; set; }
            public DateTime DataModifiedAt { get; set; }
            public object ReplicationId { get; set; }
            public bool UseLevelBasedMatchmaking { get; set; }
            public bool UseAgeBasedMatchmaking { get; set; }
            public bool UseRecRoyaleMatchmaking { get; set; }
            public int ReleaseStatus { get; set; }
            public bool SupportsJoinInProgress { get; set; }
        }
        
        public class Root
        {
            public Room Room { get; set; }
            public List<Scene> Scenes { get; set; }
            public List<ulong> CoOwners { get; set; }
            public List<ulong> InvitedCoOwners { get; set; }
            public List<ulong> Hosts { get; set; }
            public List<ulong> InvitedHosts { get; set; }
            public int CheerCount { get; set; }
            public int FavoriteCount { get; set; }
            public int VisitCount { get; set; }
            public List<aTag> Tags { get; set; }
        }
        public class aTag
        {
            public string Tag { get; set; }
            public int Type { get; set; }
        }
    }
}
