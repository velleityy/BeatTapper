using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static readonly string FileName = "beattapper_save_v1.json";

    private static string PathForSave()
    {
        // cross-platform per-user writable location
        return System.IO.Path.Combine(Application.persistentDataPath, FileName);
    }

    public static void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, prettyPrint: true);
        File.WriteAllText(PathForSave(), json);
        // lightweight key/values that the engine might read on boot
        PlayerPrefs.SetFloat("masterVolume", data.settings.masterVolume);
        PlayerPrefs.SetInt("hitOffsetMs", data.settings.hitOffsetMs);
        PlayerPrefs.SetString("theme", data.settings.theme);
        PlayerPrefs.Save();
#if UNITY_EDITOR
        Debug.Log($"Saved to: {PathForSave()}");
#endif
    }

    public static bool TryLoad(out SaveData data)
    {
        string path = PathForSave();
        if (File.Exists(path))
        {
            var json = File.ReadAllText(path);
            data = JsonUtility.FromJson<SaveData>(json);
            // hydrate runtime from PlayerPrefs if needed
            if (PlayerPrefs.HasKey("masterVolume"))
                data.settings.masterVolume = PlayerPrefs.GetFloat("masterVolume");
            if (PlayerPrefs.HasKey("hitOffsetMs"))
                data.settings.hitOffsetMs = PlayerPrefs.GetInt("hitOffsetMs");
            if (PlayerPrefs.HasKey("theme"))
                data.settings.theme = PlayerPrefs.GetString("theme");
            return true;
        }
        data = new SaveData(); // fresh default
        return false;
    }

    public static void Delete()
    {
        string path = PathForSave();
        if (File.Exists(path)) File.Delete(path);
        PlayerPrefs.DeleteKey("masterVolume");
        PlayerPrefs.DeleteKey("hitOffsetMs");
        PlayerPrefs.DeleteKey("theme");
    }
}
