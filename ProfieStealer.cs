using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace api
{
    class ProfieStealer
    {
        public static void ProfileSteal(string data)
        {
                List<Root> profile = JsonConvert.DeserializeObject<List<Root>>(data);
                File.WriteAllText("SaveData\\Profile\\username.txt", profile[0].username);
                byte[] profileimage = new WebClient().DownloadData("https://img.rec.net/" + profile[0].profileImage + "?cropSquare=true&width=192&height=192");
                File.WriteAllBytes("SaveData\\profileimage.png", profileimage);
            
            
        }
        
        public class Root
        {
            public int accountId { get; set; }
            public string username { get; set; }
            public string displayName { get; set; }
            public string profileImage { get; set; }
            public bool isJunior { get; set; }
            public int platforms { get; set; }
            public int personalPronouns { get; set; }
            public int identityFlags { get; set; }
            public DateTime createdAt { get; set; }
            public string bannerImage { get; set; }
        }
    }
}
