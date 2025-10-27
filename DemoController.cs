using UnityEngine;
using UnityEngine.UI;

public class DemoSaveController : MonoBehaviour
{
    public Slider volumeSlider;    // 0..1
    public InputField offsetField; // int ms
    public Dropdown themeDropdown; // "default","neon","mono"
    public Text statusText;

    SaveData data = new SaveData();

    void Start()
    {
        if (SaveSystem.TryLoad(out data))
            statusText.text = "Loaded existing save";
        else
            statusText.text = "No save found (using defaults)";

        volumeSlider.value = data.settings.masterVolume;
        offsetField.text = data.settings.hitOffsetMs.ToString();
        themeDropdown.value = themeDropdown.options.FindIndex(o => o.text == data.settings.theme);
    }

    // Simulate “Do Something”: update progress after a fake song
    public void SimulateSongResult()
    {
        var best = data.bestByTrack.Find(b => b.songId == "night_drive");
        if (best == null) { best = new TrackBest { songId = "night_drive" }; data.bestByTrack.Add(best); }
        best.bestScore = Mathf.Max(best.bestScore, Random.Range(150000, 350000));
        best.bestAccuracy = Mathf.Max(best.bestAccuracy, Random.Range(80f, 98.5f));
        best.maxCombo = Mathf.Max(best.maxCombo, Random.Range(20, 80));

        if (!data.unlockedTrackIds.Contains("city_pop_01"))
            data.unlockedTrackIds.Add("city_pop_01");

        data.lastSession.lastSongId = "night_drive";
        data.lastSession.lastDifficulty = "Normal";
        data.lastSession.lastPlayedAtUtc = System.DateTime.UtcNow.ToString("o");

        statusText.text = "Simulated results updated";
    }

    public void Save()
    {
        data.settings.masterVolume = volumeSlider.value;
        int.TryParse(offsetField.text, out data.settings.hitOffsetMs);
        data.settings.theme = themeDropdown.options[themeDropdown.value].text;

        SaveSystem.Save(data);
        statusText.text = "Saved";
    }

    public void Load()
    {
        SaveSystem.TryLoad(out data);
        volumeSlider.value = data.settings.masterVolume;
        offsetField.text = data.settings.hitOffsetMs.ToString();
        themeDropdown.value = themeDropdown.options.FindIndex(o => o.text == data.settings.theme);
        statusText.text = "Loaded";
    }

    public void ResetSave()
    {
        SaveSystem.Delete();
        data = new SaveData();
        Start(); // rebind defaults
        statusText.text = "Save deleted";
    }
}
using UnityEngine;
using UnityEngine.UI;

public class DemoSaveController : MonoBehaviour
{
    public Slider volumeSlider;    // 0..1
    public InputField offsetField; // int ms
    public Dropdown themeDropdown; // "default","neon","mono"
    public Text statusText;

    SaveData data = new SaveData();

    void Start()
    {
        if (SaveSystem.TryLoad(out data))
            statusText.text = "Loaded existing save";
        else
            statusText.text = "No save found (using defaults)";

        volumeSlider.value = data.settings.masterVolume;
        offsetField.text = data.settings.hitOffsetMs.ToString();
        themeDropdown.value = themeDropdown.options.FindIndex(o => o.text == data.settings.theme);
    }

    // Simulate “Do Something”: update progress after a fake song
    public void SimulateSongResult()
    {
        var best = data.bestByTrack.Find(b => b.songId == "night_drive");
        if (best == null) { best = new TrackBest { songId = "night_drive" }; data.bestByTrack.Add(best); }
        best.bestScore = Mathf.Max(best.bestScore, Random.Range(150000, 350000));
        best.bestAccuracy = Mathf.Max(best.bestAccuracy, Random.Range(80f, 98.5f));
        best.maxCombo = Mathf.Max(best.maxCombo, Random.Range(20, 80));

        if (!data.unlockedTrackIds.Contains("city_pop_01"))
            data.unlockedTrackIds.Add("city_pop_01");

        data.lastSession.lastSongId = "night_drive";
        data.lastSession.lastDifficulty = "Normal";
        data.lastSession.lastPlayedAtUtc = System.DateTime.UtcNow.ToString("o");

        statusText.text = "Simulated results updated";
    }

    public void Save()
    {
        data.settings.masterVolume = volumeSlider.value;
        int.TryParse(offsetField.text, out data.settings.hitOffsetMs);
        data.settings.theme = themeDropdown.options[themeDropdown.value].text;

        SaveSystem.Save(data);
        statusText.text = "Saved";
    }

    public void Load()
    {
        SaveSystem.TryLoad(out data);
        volumeSlider.value = data.settings.masterVolume;
        offsetField.text = data.settings.hitOffsetMs.ToString();
        themeDropdown.value = themeDropdown.options.FindIndex(o => o.text == data.settings.theme);
        statusText.text = "Loaded";
    }

    public void ResetSave()
    {
        SaveSystem.Delete();
        data = new SaveData();
        Start(); // rebind defaults
        statusText.text = "Save deleted";
    }
}
