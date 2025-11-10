using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public BeatMap beatMap;
    public Transform[] lanes;         // size 4, parents for spawned notes
    public GameObject notePrefab;
    public float spawnY = 6f;         // world Y where notes appear
    public float hitY = 0f;           // world Y of hit line
    public float fallSpeed = 6f;      // world units per second

    private int nextIndex = 0;
    private readonly List<GameObject> spawned = new();

    void Start()
    {
        beatMap.PlaySong();
    }

    void Update()
    {
        var nowMs = beatMap.SongTimeMs;

        // Spawn when (time to fall) = distance / speed
        while (nextIndex < beatMap.data.notes.Count)
        {
            var n = beatMap.data.notes[nextIndex];
            float travelTimeSec = Mathf.Abs(spawnY - hitY) / Mathf.Max(0.01f, fallSpeed);
            float spawnMs = n.timeMs - (travelTimeSec * 1000f);
            if (nowMs >= spawnMs)
            {
                SpawnOne(n);
                nextIndex++;
            }
            else break;
        }

        // Move notes
        for (int i = spawned.Count - 1; i >= 0; i--)
        {
            var go = spawned[i];
            go.transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
            if (go.transform.position.y < hitY - 2f)
            {
                Destroy(go);
                spawned.RemoveAt(i);
            }
        }
    }

    private void SpawnOne(NoteEvent n)
    {
        var laneParent = lanes[Mathf.Clamp(n.lane, 0, lanes.Length - 1)];
        var pos = new Vector3(laneParent.position.x, spawnY, 0f);
        var go = Instantiate(notePrefab, pos, Quaternion.identity, laneParent);
        var tagger = go.AddComponent<NoteTag>();
        tagger.lane = n.lane;
        tagger.timeMs = n.timeMs;
        spawned.Add(go);
    }
}

public class NoteTag : MonoBehaviour
{
    public int lane;
    public float timeMs;
}
