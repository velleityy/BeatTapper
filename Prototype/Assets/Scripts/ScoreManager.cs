using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText, comboText, judgeText;

    public int score;
    public int combo;
    public int maxCombo;
    public int perfect, great, good, miss;

    void Start() { Refresh(); }

    public void ApplyJudge(string judge)
    {
        switch (judge)
        {
            case "Perfect": score += 1000 + combo * 5; combo++; perfect++; break;
            case "Great":   score += 700  + combo * 3; combo++; great++;   break;
            case "Good":    score += 400;             combo = Mathf.Max(0, combo-1); good++; break;
            default:        combo = 0; miss++; break;
        }
        maxCombo = Mathf.Max(maxCombo, combo);
        if (judgeText != null) judgeText.text = judge;
        Refresh();
    }

    void Refresh()
    {
        if (scoreText != null) scoreText.text = $"Score: {score}";
        if (comboText != null) comboText.text = $"Combo: {combo}";
    }

    public float Accuracy()
    {
        int total = perfect + great + good + miss;
        if (total == 0) return 0f;
        float weighted = perfect * 1f + great * 0.8f + good * 0.5f;
        return (weighted / Mathf.Max(1, total)) * 100f;
    }

    // Call when song ends (via timeline length or AudioSource time check)
    public void PushToResults()
    {
        PlayerPrefs.SetInt("lastScore", score);
        PlayerPrefs.SetInt("lastMaxCombo", maxCombo);
        PlayerPrefs.SetFloat("lastAccuracy", Accuracy());
        PlayerPrefs.Save();

        var nav = FindObjectOfType<SceneNav>();
        if (nav != null) nav.LoadResults();
    }
}
