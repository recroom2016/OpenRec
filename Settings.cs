using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace api
{
	internal class Settings
	{
		public static void SetPlayerSettings(string jsonData)
		{
			if (jsonData == "")
			{ 
				return;
			}
			Setting setting = JsonConvert.DeserializeObject<Setting>(jsonData);
			Settings.playerSettings = Settings.LoadSettings();
			foreach (Setting setting2 in Settings.playerSettings)
			{
				if (setting2.Key == setting.Key)
				{
					setting2.Value = setting.Value;
					Settings.SaveSettings(Settings.playerSettings);
				}
			}
			Settings.playerSettings.Add(new Setting
			{
				Key = setting.Key,
				Value = setting.Value
			});
			Settings.SaveSettings(Settings.playerSettings);
		}
		public static List<Setting> LoadSettings()
		{
			return JsonConvert.DeserializeObject<List<Setting>>(File.ReadAllText(Environment.CurrentDirectory + Settings.SettingsPath));
		}
		public static void SaveSettings(List<Setting> settings)
		{
			File.WriteAllText(Environment.CurrentDirectory + Settings.SettingsPath, JsonConvert.SerializeObject(settings));
		}
		
		public static List<Setting> CreateDefaultSettings()
		{
			return new List<Setting>
			{
				new Setting
				{
					Key = "MOD_BLOCKED_TIME",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "MOD_BLOCKED_DURATION",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "PlayerSessionCount",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "ShowRoomCenter",
					Value = 1f.ToString()
				},
				new Setting
				{
					Key = "QualitySettings",
					Value = 3.ToString()
				},
				new Setting
				{
					Key = "Recroom.OOBE",
					Value = 100.ToString()
				},
				new Setting
				{
					Key = "VoiceFilter",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "VIGNETTED_TELEPORT_ENABLED",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "CONTINUOUS_ROTATION_MODE",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "ROTATION_INCREMENT",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "ROTATE_IN_PLACE_ENABLED",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "TeleportBuffer",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "VoiceChat",
					Value = 1f.ToString()
				},
				new Setting
				{
					Key = "PersonalBubble",
					Value = 0f.ToString()
				},
				new Setting
				{
					Key = "ShowNames",
					Value = 1f.ToString()
				},
				new Setting
				{
					Key = "H.264 plugin",
					Value = 1f.ToString()
				}
			};
		}
		
		private static List<Setting> playerSettings;

		
		public static string SettingsPath = "\\SaveData\\settings.txt";
	}
}
