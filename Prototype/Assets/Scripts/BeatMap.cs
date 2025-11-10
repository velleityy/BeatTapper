using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NoteEvent
{
    public int lane;      // 0..3
    public float timeMs;  // when the head should cross the hit line
}

[Serializable]
public class BeatMapData
{
    public string songId = "night_drive";
    public float bpm = 128f;
    public List<NoteEvent> notes = new List<NoteEvent>();
}

public class BeatMap : MonoBehaviour
{
    public string resourcePath = "BeatMaps/night_drive"; // Resources/BeatMaps/night_drive.json
    public AudioSource audioSource;

    [HideInInspector] public BeatMapData data;

    void Awake()
    {
        var text = Resources.Load<TextAsset>(resourcePath);
        data = JsonUtility.FromJson<BeatMapData>(text.text);
    }

    public void PlaySong()
    {
        if (audioSource != null) audioSource.Play();
        startDsp = (float)AudioSettings.dspTime;
    }

    public float SongTimeMs => ((float)AudioSettings.dspTime - startDsp) * 1000f;

    private float startDsp;
}
