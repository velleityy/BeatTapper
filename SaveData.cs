using System;
using System.Collections.Generic;

[Serializable]
public class TrackBest {
    public string songId;
    public int bestScore;
    public float bestAccuracy;
    public int maxCombo;
}

[Serializable]
public class Settings {
    public float masterVolume = 1.0f;
    public int hitOffsetMs = 0;
    public string theme = "default";
}

[Serializable]
public class LastSession {
    public string lastSongId = "";
    public string lastDifficulty = "Normal";
    public string lastPlayedAtUtc = "";
}

[Serializable]
public class SaveData {
    public int version = 1;
    public Settings settings = new Settings();
    public List<TrackBest> bestByTrack = new List<TrackBest>();
    public List<string> unlockedTrackIds = new List<string>();
    public LastSession lastSession = new LastSession();
}
