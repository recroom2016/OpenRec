using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using vaultgamesesh;

namespace gamesesh2
{
    class NewGameSessions
    {
        public static string JoinRoom(string text)
        {
            c00006b.c00006c apidata = JsonConvert.DeserializeObject<c00006b.c00006c>(text);
            return string.Empty;
               
        }
        public class GameSession
        {
            public int GameSessionId { get; set; }
            public string PhotonRegionId { get; set; }
            public string PhotonRoomId { get; set; }
            public string Name { get; set; }
            public int RoomId { get; set; }
            public int RoomSceneId { get; set; }
            public string RoomSceneLocationId { get; set; }
            public bool IsSandbox { get; set; }
            public string DataBlobName { get; set; }
            public object PlayerEventId { get; set; }
            public bool Private { get; set; }
            public bool GameInProgress { get; set; }
            public int MaxCapacity { get; set; }
            public bool IsFull { get; set; }
        }

        public class Room
        {
            public int RoomId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int CreatorPlayerId { get; set; }
            public string ImageName { get; set; }
            public int State { get; set; }
            public int Accessibility { get; set; }
            public bool SupportsLevelVoting { get; set; }
            public bool IsAGRoom { get; set; }
            public bool CloningAllowed { get; set; }
            public bool SupportsScreens { get; set; }
            public bool SupportsWalkVR { get; set; }
            public bool SupportsTeleportVR { get; set; }
            public string ReplicationId { get; set; }
            public int ReleaseStatus { get; set; }
        }

        public class Scene
        {
            public int RoomSceneId { get; set; }
            public int RoomId { get; set; }
            public string RoomSceneLocationId { get; set; }
            public string Name { get; set; }
            public bool IsSandbox { get; set; }
            public string DataBlobName { get; set; }
            public int MaxPlayers { get; set; }
            public bool CanMatchmakeInto { get; set; }
            public DateTime DataModifiedAt { get; set; }
            public string ReplicationId { get; set; }
            public bool UseLevelBasedMatchmaking { get; set; }
            public bool UseAgeBasedMatchmaking { get; set; }
            public bool UseRecRoyaleMatchmaking { get; set; }
            public int ReleaseStatus { get; set; }
            public bool SupportsJoinInProgress { get; set; }
        }

        public class aTag
        {
            public string Tag { get; set; }
            public int Type { get; set; }
        }

        public class RoomDetails
        {
            public Room Room { get; set; }
            public List<Scene> Scenes { get; set; }
            public List<object> CoOwners { get; set; }
            public List<object> InvitedCoOwners { get; set; }
            public List<object> Hosts { get; set; }
            public List<object> InvitedHosts { get; set; }
            public int CheerCount { get; set; }
            public int FavoriteCount { get; set; }
            public int VisitCount { get; set; }
            public List<aTag> Tags { get; set; }
        }

        public class Root
        {
            public int Result { get; set; }
            public GameSession GameSession { get; set; }
            public RoomDetails RoomDetails { get; set; }
        }


    }
}
