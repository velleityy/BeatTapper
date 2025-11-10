using UnityEngine;
using UnityEngine.UI;

public class ResultsController : MonoBehaviour
{
    public Text scoreValue, accuracyValue, maxComboValue;

    void Start()
    {
        int score = PlayerPrefs.GetInt("lastScore", 0);
        int maxCombo = PlayerPrefs.GetInt("lastMaxCombo", 0);
        float acc = PlayerPrefs.GetFloat("lastAccuracy", 0f);

        if (scoreValue) scoreValue.text = score.ToString();
        if (accuracyValue) accuracyValue.text = acc.ToString("0.0") + "%";
        if (maxComboValue) maxComboValue.text = maxCombo.ToString();
    }
}
