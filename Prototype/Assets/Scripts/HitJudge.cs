using UnityEngine;

public class HitJudge : MonoBehaviour
{
    public BeatMap beatMap;
    public ScoreManager score;
    public Transform[] laneRoots; // same order as spawner.lanes
    public float perfectMs = 30f, greatMs = 60f, goodMs = 90f;

    KeyCode[] keys = { KeyCode.D, KeyCode.F, KeyCode.J, KeyCode.K };

    void Update()
    {
        for (int lane = 0; lane < 4; lane++)
        {
            if (Input.GetKeyDown(keys[lane]))
                TryJudge(lane);
        }
    }

    void TryJudge(int lane)
    {
        // Find closest note in this lane (simple nearest search)
        NoteTag best = null;
        float bestDelta = float.MaxValue;

        foreach (Transform child in laneRoots[lane])
        {
            var tag = child.GetComponent<NoteTag>();
            if (tag == null) continue;
            float delta = Mathf.Abs(beatMap.SongTimeMs - tag.timeMs);
            if (delta < bestDelta) { bestDelta = delta; best = tag; }
        }

        if (best == null) return;

        string judge;
        if (bestDelta <= perfectMs)      judge = "Perfect";
        else if (bestDelta <= greatMs)   judge = "Great";
        else if (bestDelta <= goodMs)    judge = "Good";
        else                             judge = "Miss";

        score.ApplyJudge(judge);

        if (judge != "Miss")
            Destroy(best.gameObject);
    }
}
