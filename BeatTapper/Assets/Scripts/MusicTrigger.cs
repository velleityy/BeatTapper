using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    [Header("Song to Play (Longer than 10s)")]
    public AudioClip songClip;

    [Header("Options")]
    public bool stopBackgroundMusic = true;
    public float volume = 0.8f;

    // Call this from a button or event to start the track
    public void PlaySong()
    {
        if (stopBackgroundMusic && AudioManager.Instance != null)
        {
            AudioManager.Instance.StopBGM();
        }

        if (AudioManager.Instance != null && songClip != null)
        {
            AudioManager.Instance.PlayBGM(songClip, volume, loop: false);
        }
        else
        {
            Debug.LogWarning("MusicTrigger: Missing AudioManager or songClip.");
        }
    }
}
