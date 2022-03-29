using System;
using System.Collections.Generic;
using System.Text;

namespace api
{
    class ModernRooms
    {
        public class Stats
        {
            public int CheerCount { get; set; }
            public int FavoriteCount { get; set; }
            public int VisitorCount { get; set; }
            public int VisitCount { get; set; }
        }

        public class SubRoom
        {
            public int SubRoomId { get; set; }
            public ulong RoomId { get; set; }
            public string UnitySceneId { get; set; }
            public string Name { get; set; }
            public string DataBlob { get; set; }
            public DateTime DataSavedAt { get; set; }
            public bool IsSandbox { get; set; }
            public int MaxPlayers { get; set; }
            public int Accessibility { get; set; }
        }

        public class Root
        {
            public ulong RoomId { get; set; }
            public bool IsDorm { get; set; }
            public int MaxPlayerCalculationMode { get; set; }
            public int MaxPlayers { get; set; }
            public bool CloningAllowed { get; set; }
            public bool DisableMicAutoMute { get; set; }
            public bool DisableRoomComments { get; set; }
            public bool EncryptVoiceChat { get; set; }
            public bool LoadScreenLocked { get; set; }
            public int Version { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageName { get; set; }
            public int WarningMask { get; set; }
            public object CustomWarning { get; set; }
            public int CreatorAccountId { get; set; }
            public int State { get; set; }
            public int Accessibility { get; set; }
            public bool SupportsLevelVoting { get; set; }
            public bool IsRRO { get; set; }
            public bool SupportsScreens { get; set; }
            public bool SupportsWalkVR { get; set; }
            public bool SupportsTeleportVR { get; set; }
            public bool SupportsVRLow { get; set; }
            public bool SupportsQuest2 { get; set; }
            public bool SupportsMobile { get; set; }
            public bool SupportsJuniors { get; set; }
            public int MinLevel { get; set; }
            public DateTime CreatedAt { get; set; }
            public Stats Stats { get; set; }
            public List<SubRoom> SubRooms { get; set; }
            public List<object> Tags { get; set; }
            public List<object> PromoImages { get; set; }
            public List<object> PromoExternalContent { get; set; }
            public List<object> LoadScreens { get; set; }
        }


    }
}
