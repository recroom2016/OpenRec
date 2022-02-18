using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace api
{
	// Token: 0x0200003C RID: 60
	internal class Settings
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00002D10 File Offset: 0x00000F10
		public static string GetPlayerSettings()
		{
			if (Settings.playerSettings == null)
			{
				if (File.Exists(Settings.SettingsPath))
				{
					Settings.playerSettings = Settings.LoadSettings();
				}
				else
				{
					Settings.playerSettings = Settings.CreateDefaultSettings();
				}
			}
			return JsonConvert.SerializeObject(Settings.playerSettings);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000061FC File Offset: 0x000043FC
		public static void SetPlayerSettings(string jsonData)
		{
			if (jsonData == "")
			{
				Console.WriteLine("[Settings][Set] Json Data is empty.");
				return;
			}
			Setting setting = JsonConvert.DeserializeObject<Setting>(jsonData);
			for (int i = 0; i < Settings.playerSettings.Count; i++)
			{
				if (Settings.playerSettings[i].Key == setting.Key)
				{
					Settings.playerSettings[i].Value = setting.Value;
					Settings.SaveSettings(Settings.playerSettings);
					return;
				}
			}
			Settings.playerSettings.Add(new Setting
			{
				Key = setting.Key,
				Value = setting.Value
			});
			Settings.SaveSettings(Settings.playerSettings);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000062AC File Offset: 0x000044AC
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
					Value = 0f.ToString()
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

		// Token: 0x060001C4 RID: 452 RVA: 0x00006548 File Offset: 0x00004748
		public static List<Setting> LoadSettings()
		{
			List<Setting> list = new List<Setting>();
			using (BinaryReader binaryReader = new BinaryReader(File.Open(Settings.SettingsPath, FileMode.Open)))
			{
				while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
				{
					Setting item = new Setting
					{
						Key = binaryReader.ReadString(),
						Value = binaryReader.ReadString()
					};
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000065C8 File Offset: 0x000047C8
		public static void SaveSettings(List<Setting> settings)
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Create("SaveData\\")))
			{
				foreach (Setting setting in settings)
				{
					binaryWriter.Write(setting.Key);
					binaryWriter.Write(setting.Value);
				}
			}
		}

		// Token: 0x040000F0 RID: 240
		private static List<Setting> playerSettings;

		// Token: 0x040000F1 RID: 241
		public static string SettingsPath =  + "PlayerSettings.dat";
	}
}
